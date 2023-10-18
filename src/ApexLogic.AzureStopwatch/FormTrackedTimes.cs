using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexLogic.AzureStopwatch
{
    public partial class FormTrackedTimes : Form
    {
        public FormTrackedTimes()
        {
            InitializeComponent();
            foreach (TrackedTime time in Globals.TimeTracker.UncommitedTracks)
            {
                time.CalculateSpentTimeCorrected();
            }

            this.dgvTrackData.DataSource = Globals.TimeTracker.UncommitedTracks;
            this.dgvTrackData.DataBindingComplete += DataGridView1_DataBindingComplete;
        }

        private void DataGridView1_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            var cols = this.dgvTrackData.Columns.Cast<DataGridViewColumn>();

            cols.First(col => col.DataPropertyName == nameof(TrackedTime.Title)).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cols.First(col => col.DataPropertyName == nameof(TrackedTime.ToUpload)).ReadOnly = false;
            cols.First(col => col.DataPropertyName == nameof(TrackedTime.SpentTimeCorrected)).DefaultCellStyle.BackColor = Color.LemonChiffon;
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            Globals.TimeTracker.CombineTrackData();
            foreach (TrackedTime time in Globals.TimeTracker.UncommitedTracks)
            {
                time.CalculateSpentTimeCorrected();
            }
            this.dgvTrackData.DataSource = Globals.TimeTracker.UncommitedTracks;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function not available yet.", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Function not available yet.", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
