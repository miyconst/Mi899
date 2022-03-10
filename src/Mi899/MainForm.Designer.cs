namespace Mi899
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msiFileReadMe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExplore = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExploreMotherboards = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExploreBioses = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelpHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelpHowToTurboUnlock = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelpHowToRamTimings = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelpHowToUseCh341a = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.msiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpMain.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.msMenu, 0, 0);
            this.tlpMain.Controls.Add(this.ssStatus, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Size = new System.Drawing.Size(1008, 636);
            this.tlpMain.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msMenu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile,
            this.msiExplore,
            this.msiHelp,
            this.msiLanguage});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1008, 30);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msiFile
            // 
            this.msiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFileReadMe,
            this.toolStripSeparator2,
            this.msiExit});
            this.msiFile.Name = "msiFile";
            this.msiFile.Size = new System.Drawing.Size(47, 26);
            this.msiFile.Text = "&File";
            // 
            // msiFileReadMe
            // 
            this.msiFileReadMe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msiFileReadMe.Name = "msiFileReadMe";
            this.msiFileReadMe.Size = new System.Drawing.Size(130, 22);
            this.msiFileReadMe.Text = "Read me!";
            this.msiFileReadMe.Click += new System.EventHandler(this.msiFileReadMe_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // msiExit
            // 
            this.msiExit.Name = "msiExit";
            this.msiExit.Size = new System.Drawing.Size(130, 22);
            this.msiExit.Text = "E&xit";
            this.msiExit.Click += new System.EventHandler(this.msiExit_Click);
            // 
            // msiExplore
            // 
            this.msiExplore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiExploreMotherboards,
            this.msiExploreBioses});
            this.msiExplore.Name = "msiExplore";
            this.msiExplore.Size = new System.Drawing.Size(68, 26);
            this.msiExplore.Text = "&Explore";
            // 
            // msiExploreMotherboards
            // 
            this.msiExploreMotherboards.Name = "msiExploreMotherboards";
            this.msiExploreMotherboards.Size = new System.Drawing.Size(158, 22);
            this.msiExploreMotherboards.Text = "Motherboards";
            this.msiExploreMotherboards.Click += new System.EventHandler(this.msiExploreMotherboards_Click);
            // 
            // msiExploreBioses
            // 
            this.msiExploreBioses.Name = "msiExploreBioses";
            this.msiExploreBioses.Size = new System.Drawing.Size(158, 22);
            this.msiExploreBioses.Text = "BIOS";
            this.msiExploreBioses.Click += new System.EventHandler(this.msiExploreBioses_Click);
            // 
            // msiHelp
            // 
            this.msiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiHelpHowTo,
            this.toolStripSeparator5,
            this.msiHelpAbout});
            this.msiHelp.Name = "msiHelp";
            this.msiHelp.Size = new System.Drawing.Size(47, 26);
            this.msiHelp.Text = "&Help";
            // 
            // msiHelpHowTo
            // 
            this.msiHelpHowTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiHelpHowToTurboUnlock,
            this.msiHelpHowToRamTimings,
            this.msiHelpHowToUseCh341a});
            this.msiHelpHowTo.Name = "msiHelpHowTo";
            this.msiHelpHowTo.Size = new System.Drawing.Size(130, 22);
            this.msiHelpHowTo.Text = "How to";
            // 
            // msiHelpHowToTurboUnlock
            // 
            this.msiHelpHowToTurboUnlock.Name = "msiHelpHowToTurboUnlock";
            this.msiHelpHowToTurboUnlock.Size = new System.Drawing.Size(305, 22);
            this.msiHelpHowToTurboUnlock.Text = "Unlock Turbo Boost";
            this.msiHelpHowToTurboUnlock.Click += new System.EventHandler(this.msiHelpHowToTurboUnlock_Click);
            // 
            // msiHelpHowToRamTimings
            // 
            this.msiHelpHowToRamTimings.Name = "msiHelpHowToRamTimings";
            this.msiHelpHowToRamTimings.Size = new System.Drawing.Size(305, 22);
            this.msiHelpHowToRamTimings.Text = "Tighten RAM timings";
            this.msiHelpHowToRamTimings.Click += new System.EventHandler(this.msiHelpHowToRamTimings_Click);
            // 
            // msiHelpHowToUseCh341a
            // 
            this.msiHelpHowToUseCh341a.Name = "msiHelpHowToUseCh341a";
            this.msiHelpHowToUseCh341a.Size = new System.Drawing.Size(305, 22);
            this.msiHelpHowToUseCh341a.Text = "How to use CH341A BIOS Programmer";
            this.msiHelpHowToUseCh341a.Click += new System.EventHandler(this.msiHelpHowToUseCh341a_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
            // 
            // msiHelpAbout
            // 
            this.msiHelpAbout.Name = "msiHelpAbout";
            this.msiHelpAbout.Size = new System.Drawing.Size(130, 22);
            this.msiHelpAbout.Text = "&About...";
            this.msiHelpAbout.Click += new System.EventHandler(this.msiHelpAbout_Click);
            // 
            // msiLanguage
            // 
            this.msiLanguage.Name = "msiLanguage";
            this.msiLanguage.Size = new System.Drawing.Size(75, 26);
            this.msiLanguage.Text = "&Language";
            // 
            // ssStatus
            // 
            this.ssStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion});
            this.ssStatus.Location = new System.Drawing.Point(0, 606);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1008, 30);
            this.ssStatus.TabIndex = 1;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(301, 25);
            this.tsslVersion.Text = "Mi899 Version 1.2.6 - Copyright © Miyconst";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 636);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(1024, 675);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi899 - X99 Tool Set";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msiFileReadMe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msiExit;
        private System.Windows.Forms.ToolStripMenuItem msiExplore;
        private System.Windows.Forms.ToolStripMenuItem msiHelp;
        private System.Windows.Forms.ToolStripMenuItem msiHelpHowTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem msiHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem msiExploreMotherboards;
        private System.Windows.Forms.ToolStripMenuItem msiHelpHowToTurboUnlock;
        private System.Windows.Forms.ToolStripMenuItem msiHelpHowToRamTimings;
        private System.Windows.Forms.ToolStripMenuItem msiExploreBioses;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripMenuItem msiFile;
        private System.Windows.Forms.ToolStripMenuItem msiLanguage;
        private System.Windows.Forms.ToolStripMenuItem msiHelpHowToUseCh341a;
    }
}