using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexLogic.AzureStopwatch
{
    public partial class FormCounter : Form
    {
        private bool m_shutDownSignalled;
        private List<WorkItem> m_workItems = new List<WorkItem>();

        public FormCounter()
        {
            InitializeComponent();

            Tuple<bool, Configuration> config = Configuration.Load(Configuration.DEFAULT_FILE);

            if (config.Item1)
            {
                MessageBox.Show("Configuration required!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                new FormSettings().ShowDialog();
            }


            Globals.Configuration = config.Item2;
            Globals.DevopsApi = new DevopsApi("");
            Globals.TimeTracker = new TimeTracker();

            this.RefreshTaskList();

            this.cbxTasks.DataSource = this.m_workItems;
            this.cbxTasks.ValueMember = nameof(WorkItem.Id);
            this.cbxTasks.DisplayMember = nameof(WorkItem.Title);

            Globals.TimeTracker.ChangeToWorkitem(this.cbxTasks.SelectedItem as WorkItem);
            Globals.TimeTracker.TimeChanged += M_timeTracker_TimeChanged;
            Globals.TimeTracker.AfterHoursHit += TimeTracker_AfterHoursHit;
        }

        private void TimeTracker_AfterHoursHit(object? sender, EventArgs e)
        {
            this.Invoke(() =>
            {
                this.chkIsTracking.Checked = Globals.TimeTracker.IsTracking;
                MessageBox.Show("After-hours reached!?", "After-hours", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }

        private void RefreshTaskList()
        {
            List<WorkItem> workItems = Globals.DevopsApi.GetActiveTasks();
            foreach (WorkItem newItem in workItems)
            {
                WorkItem oldItem = this.m_workItems.FirstOrDefault(wi => wi.Id == newItem.Id);
                if (oldItem == null)
                {
                    this.m_workItems.Add(newItem);
                }
                else
                {
                    oldItem.BaseSpentTime = newItem.BaseSpentTime;
                }
            }
        }

        private void M_timeTracker_TimeChanged(object? sender, EventArgs e)
        {
            this.Invoke(() =>
            {
                this.lblTime.Text = Globals.TimeTracker.CurrentTracking.Time.ToString(@"hh\:mm\:ss");
            });
        }

        private void FormCounter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.m_shutDownSignalled)
            {
                this.trayIcon.Visible = false;
            }
            else
            {
                this.Visible = false;
                e.Cancel = true;
            }
        }

        private void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void chkIsTracking_CheckedChanged(object sender, EventArgs e)
        {
            Globals.TimeTracker.IsTracking = this.chkIsTracking.Checked;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.btnRefresh.Enabled = false;
            Task.Run(this.RefreshTaskList).ContinueWith(delegate
            {
                this.Invoke(() =>
                {
                    this.cbxTasks.DataSource = this.m_workItems;
                    this.btnRefresh.Enabled = true;
                });
            });
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Globals.TimeTracker.ChangeToWorkitem(this.cbxTasks.SelectedItem as WorkItem);
            this.lblTime.Text = "00:00:00";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.Yes;
            if (Globals.TimeTracker.IsTracking)
            {
                res = MessageBox.Show("You are still tracking worktime. Exit anyway?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else if (Globals.TimeTracker.UncommitedTracks.Any(t => t.Time.TotalSeconds > 0))
            {
                res = MessageBox.Show("You have uncommited tracing times Exit anyway?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (res == DialogResult.Yes)
            {
                this.m_shutDownSignalled = true;
                this.Close();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();
        }

        private void trackingTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool temp = Globals.TimeTracker.IsTracking;
            Globals.TimeTracker.IsTracking = false;

            new FormTrackedTimes().ShowDialog();

            Globals.TimeTracker.IsTracking = temp;
        }
    }
}