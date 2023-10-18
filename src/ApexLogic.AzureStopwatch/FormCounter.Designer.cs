using System.Drawing;
using System.Windows.Forms;

namespace ApexLogic.AzureStopwatch
{
    partial class FormCounter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCounter));
            cbxTasks = new ComboBox();
            btnRefresh = new Button();
            lblTime = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            chkIsTracking = new CheckBox();
            trayIcon = new NotifyIcon(components);
            mainMenu = new ContextMenuStrip(components);
            trackingTableToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            mainMenu.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbxTasks
            // 
            cbxTasks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbxTasks.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTasks.FormattingEnabled = true;
            cbxTasks.Location = new Point(12, 27);
            cbxTasks.Name = "cbxTasks";
            cbxTasks.Size = new Size(310, 23);
            cbxTasks.TabIndex = 0;
            cbxTasks.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // btnRefresh
            // 
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Image = Properties.Resources.Refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleRight;
            btnRefresh.Location = new Point(0, 0);
            btnRefresh.Margin = new Padding(0, 0, 3, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(152, 36);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh tasks";
            btnRefresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(12, 53);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(310, 51);
            lblTime.TabIndex = 3;
            lblTime.Text = "00:00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(chkIsTracking, 1, 0);
            tableLayoutPanel1.Controls.Add(btnRefresh, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 109);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(310, 36);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // chkIsTracking
            // 
            chkIsTracking.Appearance = Appearance.Button;
            chkIsTracking.AutoSize = true;
            chkIsTracking.Dock = DockStyle.Fill;
            chkIsTracking.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkIsTracking.Image = Properties.Resources.StartTime;
            chkIsTracking.ImageAlign = ContentAlignment.MiddleRight;
            chkIsTracking.Location = new Point(158, 0);
            chkIsTracking.Margin = new Padding(3, 0, 0, 0);
            chkIsTracking.Name = "chkIsTracking";
            chkIsTracking.Size = new Size(152, 36);
            chkIsTracking.TabIndex = 5;
            chkIsTracking.Text = "Track";
            chkIsTracking.TextAlign = ContentAlignment.MiddleCenter;
            chkIsTracking.TextImageRelation = TextImageRelation.ImageBeforeText;
            chkIsTracking.UseVisualStyleBackColor = true;
            chkIsTracking.CheckedChanged += chkIsTracking_CheckedChanged;
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = mainMenu;
            trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
            trayIcon.Text = "Azure Stopwatch";
            trayIcon.Visible = true;
            trayIcon.DoubleClick += trayIcon_DoubleClick;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { trackingTableToolStripMenuItem, settingsToolStripMenuItem, exitToolStripMenuItem });
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(148, 70);
            // 
            // trackingTableToolStripMenuItem
            // 
            trackingTableToolStripMenuItem.Image = Properties.Resources.TimePickerList;
            trackingTableToolStripMenuItem.Name = "trackingTableToolStripMenuItem";
            trackingTableToolStripMenuItem.Size = new Size(147, 22);
            trackingTableToolStripMenuItem.Text = "Tracking table";
            trackingTableToolStripMenuItem.Click += trackingTableToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = Properties.Resources.Settings;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(147, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.Close;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(147, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(334, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.TimePickerList;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Tracking table";
            toolStripMenuItem1.Click += trackingTableToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.Settings;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Settings";
            toolStripMenuItem2.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = Properties.Resources.Close;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Exit";
            toolStripMenuItem3.Click += exitToolStripMenuItem_Click;
            // 
            // FormCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 154);
            Controls.Add(menuStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTime);
            Controls.Add(cbxTasks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCounter";
            StartPosition = FormStartPosition.Manual;
            Text = "Azure Stopwatch";
            TopMost = true;
            FormClosing += FormCounter_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            mainMenu.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxTasks;
        private Button btnRefresh;
        private Label lblTime;
        private TableLayoutPanel tableLayoutPanel1;
        private NotifyIcon trayIcon;
        private ContextMenuStrip mainMenu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private CheckBox chkIsTracking;
        private ToolStripMenuItem trackingTableToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}