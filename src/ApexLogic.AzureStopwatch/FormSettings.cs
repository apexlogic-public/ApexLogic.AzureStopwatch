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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            this.cbxAuthType.SelectedIndex = Globals.Configuration.AuthenticateWithPAT ? 0 : 1;
            this.tbxUsername.Text = Globals.Configuration.Username;
            this.tbxPass.Text = Globals.Configuration.Password;
            this.tbxPAT.Text = Globals.Configuration.PersonalAccessToken;
            this.tbxHost.Text = Globals.Configuration.Host;
            this.tbxProject.Text = Globals.Configuration.Project;
            this.tbxIteration.Text = Globals.Configuration.IterationPath;
            this.chkAutoSend.Checked = Globals.Configuration.AutoSendOnAfterHours;
            this.tbxSpentTimeField.Text = Globals.Configuration.SpentTimeField;
            this.dtpAferHours.Checked = Globals.Configuration.StopTrackingInAfterHours;
            this.dtpAferHours.Value = new DateTime(1971, 1, 1, Globals.Configuration.AfterHoursStart.Hour, Globals.Configuration.AfterHoursStart.Minute, 0);
        }

        private void cbxAuthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tbxUsername.Enabled = cbxAuthType.SelectedIndex == 1;
            this.tbxPass.Enabled = cbxAuthType.SelectedIndex == 1;
            this.tbxPAT.Enabled = cbxAuthType.SelectedIndex == 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Globals.Configuration.AuthenticateWithPAT = this.cbxAuthType.SelectedIndex == 0;
            Globals.Configuration.Username = this.tbxUsername.Text;
            Globals.Configuration.Password = this.tbxPass.Text;
            Globals.Configuration.PersonalAccessToken = this.tbxPAT.Text;
            Globals.Configuration.Host = this.tbxHost.Text;
            Globals.Configuration.Project = this.tbxProject.Text;
            Globals.Configuration.IterationPath = this.tbxIteration.Text;
            Globals.Configuration.AutoSendOnAfterHours = this.chkAutoSend.Checked;
            Globals.Configuration.SpentTimeField = this.tbxSpentTimeField.Text;
            Globals.Configuration.StopTrackingInAfterHours = this.dtpAferHours.Checked;
            Globals.Configuration.AfterHoursStart = TimeOnly.FromDateTime(this.dtpAferHours.Value);

            Globals.Configuration.Save(Configuration.DEFAULT_FILE);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
