using System.Drawing;
using System.Windows.Forms;

namespace ApexLogic.AzureStopwatch
{
    partial class FormTrackedTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrackedTimes));
            btnUpload = new Button();
            btnClear = new Button();
            btnCancler = new Button();
            dgvTrackData = new DataGridView();
            btnCombine = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrackData).BeginInit();
            SuspendLayout();
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpload.Image = Properties.Resources.UploadDatabase;
            btnUpload.Location = new Point(476, 406);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(100, 32);
            btnUpload.TabIndex = 0;
            btnUpload.Text = "Upload";
            btnUpload.TextAlign = ContentAlignment.MiddleRight;
            btnUpload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Image = Properties.Resources.ClearCollection;
            btnClear.Location = new Point(582, 406);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancler
            // 
            btnCancler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancler.DialogResult = DialogResult.Cancel;
            btnCancler.Image = Properties.Resources.Cancel;
            btnCancler.Location = new Point(688, 406);
            btnCancler.Name = "btnCancler";
            btnCancler.Size = new Size(100, 32);
            btnCancler.TabIndex = 2;
            btnCancler.Text = "Cancel";
            btnCancler.TextAlign = ContentAlignment.MiddleRight;
            btnCancler.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancler.UseVisualStyleBackColor = true;
            // 
            // dgvTrackData
            // 
            dgvTrackData.AllowUserToAddRows = false;
            dgvTrackData.AllowUserToDeleteRows = false;
            dgvTrackData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTrackData.BackgroundColor = SystemColors.ControlLight;
            dgvTrackData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrackData.Location = new Point(12, 12);
            dgvTrackData.Name = "dgvTrackData";
            dgvTrackData.RowHeadersVisible = false;
            dgvTrackData.RowTemplate.Height = 25;
            dgvTrackData.Size = new Size(776, 388);
            dgvTrackData.TabIndex = 3;
            // 
            // btnCombine
            // 
            btnCombine.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCombine.Image = Properties.Resources.StructureCollection;
            btnCombine.Location = new Point(12, 406);
            btnCombine.Name = "btnCombine";
            btnCombine.Size = new Size(129, 32);
            btnCombine.TabIndex = 4;
            btnCombine.Text = "Combine times";
            btnCombine.TextAlign = ContentAlignment.MiddleRight;
            btnCombine.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCombine.UseVisualStyleBackColor = true;
            btnCombine.Click += btnCombine_Click;
            // 
            // FormTrackedTimes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCombine);
            Controls.Add(dgvTrackData);
            Controls.Add(btnCancler);
            Controls.Add(btnClear);
            Controls.Add(btnUpload);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTrackedTimes";
            Text = "Tracked times";
            ((System.ComponentModel.ISupportInitialize)dgvTrackData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpload;
        private Button btnClear;
        private Button btnCancler;
        private DataGridView dgvTrackData;
        private Button btnCombine;
    }
}