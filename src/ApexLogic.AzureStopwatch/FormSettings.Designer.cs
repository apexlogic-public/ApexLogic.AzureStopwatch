using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApexLogic.AzureStopwatch
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupBox groupBox1;
            Label label5;
            Label label4;
            Label label3;
            Label label1;
            GroupBox groupBox2;
            Label label9;
            Label label8;
            Label label7;
            Label label6;
            Label label2;
            Label label10;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            cbxAuthType = new ComboBox();
            tbxPAT = new TextBox();
            tbxPass = new TextBox();
            tbxUsername = new TextBox();
            chkAutoSend = new CheckBox();
            dtpAferHours = new DateTimePicker();
            tbxIteration = new TextBox();
            tbxProject = new TextBox();
            tbxHost = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tbxSpentTimeField = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxAuthType);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxPAT);
            groupBox1.Controls.Add(tbxPass);
            groupBox1.Controls.Add(tbxUsername);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Auth settings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 112);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 7;
            label5.Text = "PAT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 5;
            label3.Text = "Authentication type:";
            // 
            // cbxAuthType
            // 
            cbxAuthType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAuthType.FormattingEnabled = true;
            cbxAuthType.Items.AddRange(new object[] { "Personal Authentication token (PAT)", "AD username & password" });
            cbxAuthType.Location = new Point(128, 22);
            cbxAuthType.Name = "cbxAuthType";
            cbxAuthType.Size = new Size(235, 23);
            cbxAuthType.TabIndex = 4;
            cbxAuthType.SelectedIndexChanged += cbxAuthType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // tbxPAT
            // 
            tbxPAT.Location = new Point(128, 109);
            tbxPAT.Name = "tbxPAT";
            tbxPAT.Size = new Size(378, 23);
            tbxPAT.TabIndex = 2;
            // 
            // tbxPass
            // 
            tbxPass.Location = new Point(128, 80);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '*';
            tbxPass.Size = new Size(235, 23);
            tbxPass.TabIndex = 1;
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(128, 51);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(235, 23);
            tbxUsername.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(tbxSpentTimeField);
            groupBox2.Controls.Add(chkAutoSend);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtpAferHours);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbxIteration);
            groupBox2.Controls.Add(tbxProject);
            groupBox2.Controls.Add(tbxHost);
            groupBox2.Location = new Point(12, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 213);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Azure DevOps settings";
            // 
            // chkAutoSend
            // 
            chkAutoSend.AutoSize = true;
            chkAutoSend.Location = new Point(128, 171);
            chkAutoSend.Name = "chkAutoSend";
            chkAutoSend.Size = new Size(15, 14);
            chkAutoSend.TabIndex = 11;
            chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Location = new Point(10, 170);
            label9.Name = "label9";
            label9.Size = new Size(112, 33);
            label9.TabIndex = 10;
            label9.Text = "Auto-send tracked time in after-hours:";
            // 
            // dtpAferHours
            // 
            dtpAferHours.CustomFormat = "HH:mm";
            dtpAferHours.Format = DateTimePickerFormat.Custom;
            dtpAferHours.Location = new Point(128, 138);
            dtpAferHours.Name = "dtpAferHours";
            dtpAferHours.ShowCheckBox = true;
            dtpAferHours.ShowUpDown = true;
            dtpAferHours.Size = new Size(87, 23);
            dtpAferHours.TabIndex = 9;
            dtpAferHours.Value = new DateTime(2023, 10, 7, 17, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 144);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 7;
            label8.Text = "Track in after-hours:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 83);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 5;
            label7.Text = "Iteration path:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 54);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 4;
            label6.Text = "Project name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 25);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Host URL:";
            // 
            // tbxIteration
            // 
            tbxIteration.Location = new Point(128, 80);
            tbxIteration.Name = "tbxIteration";
            tbxIteration.Size = new Size(235, 23);
            tbxIteration.TabIndex = 2;
            // 
            // tbxProject
            // 
            tbxProject.Location = new Point(128, 51);
            tbxProject.Name = "tbxProject";
            tbxProject.Size = new Size(235, 23);
            tbxProject.TabIndex = 1;
            // 
            // tbxHost
            // 
            tbxHost.Location = new Point(128, 22);
            tbxHost.Name = "tbxHost";
            tbxHost.Size = new Size(378, 23);
            tbxHost.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Image = Properties.Resources.Save;
            btnSave.Location = new Point(330, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 32);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Image = Properties.Resources.Cancel;
            btnCancel.Location = new Point(436, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxSpentTimeField
            // 
            tbxSpentTimeField.Location = new Point(128, 109);
            tbxSpentTimeField.Name = "tbxSpentTimeField";
            tbxSpentTimeField.Size = new Size(235, 23);
            tbxSpentTimeField.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 112);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 13;
            label10.Text = "Spend time field:";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 427);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSettings";
            Text = "Settings";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbxPAT;
        private TextBox tbxPass;
        private TextBox tbxUsername;
        private TextBox tbxIteration;
        private TextBox tbxProject;
        private TextBox tbxHost;
        private ComboBox cbxAuthType;
        private DateTimePicker dtpAferHours;
        private Button btnSave;
        private Button btnCancel;
        private CheckBox chkAutoSend;
        private TextBox tbxSpentTimeField;
    }
}