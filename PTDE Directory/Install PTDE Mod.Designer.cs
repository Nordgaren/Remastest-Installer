
namespace PTDE_Installer
{
    partial class InstallerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerForm));
            this.browse = new System.Windows.Forms.Button();
            this.installPathBox = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressUpdate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.install = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(544, 533);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(97, 37);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // installPathBox
            // 
            this.installPathBox.Location = new System.Drawing.Point(28, 536);
            this.installPathBox.Name = "installPathBox";
            this.installPathBox.Size = new System.Drawing.Size(510, 26);
            this.installPathBox.TabIndex = 1;
            this.installPathBox.Text = "Select PTDE Install Folder";
            this.installPathBox.Click += new System.EventHandler(this.installPathBox_Click);
            // 
            // instructions
            // 
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.instructions.Location = new System.Drawing.Point(21, 360);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(620, 137);
            this.instructions.TabIndex = 2;
            this.instructions.Text = "Please select the Dark Souls: Prepare To Die Edition EXE you wish to install this" +
    " mod to.";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.InitialImage = null;
            this.icon.Location = new System.Drawing.Point(161, 28);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(330, 330);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 5;
            this.icon.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(28, 525);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(510, 5);
            this.progressBar.TabIndex = 6;
            // 
            // progressUpdate
            // 
            this.progressUpdate.AutoSize = true;
            this.progressUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressUpdate.Location = new System.Drawing.Point(28, 499);
            this.progressUpdate.MaximumSize = new System.Drawing.Size(510, 20);
            this.progressUpdate.Name = "progressUpdate";
            this.progressUpdate.Size = new System.Drawing.Size(0, 20);
            this.progressUpdate.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.install, 0, 8);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 619);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // install
            // 
            this.install.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.install.BackColor = System.Drawing.SystemColors.Window;
            this.install.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.install.ForeColor = System.Drawing.SystemColors.ControlText;
            this.install.Location = new System.Drawing.Point(218, 567);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(208, 49);
            this.install.TabIndex = 3;
            this.install.Text = "Install/Update";
            this.install.UseVisualStyleBackColor = false;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(668, 648);
            this.Controls.Add(this.progressUpdate);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.installPathBox);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 704);
            this.MinimumSize = new System.Drawing.Size(690, 704);
            this.Name = "InstallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Install Remastest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InstallerForm_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        public System.Windows.Forms.TextBox installPathBox;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button install;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

