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
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExplore = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExploreMotherboards = new System.Windows.Forms.ToolStripMenuItem();
            this.msiExploreBioses = new System.Windows.Forms.ToolStripMenuItem();
            this.msiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.fptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afuWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockTurboBoostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tightenRamTimingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.msiLanguageUkrainian = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tlpMain.Size = new System.Drawing.Size(1188, 636);
            this.tlpMain.TabIndex = 0;
            // 
            // msMenu
            // 
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msMenu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiFile,
            this.msiExplore,
            this.msiTools,
            this.msiHelp,
            this.msiLanguage});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1188, 30);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // msiFile
            // 
            this.msiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.toolStripSeparator2,
            this.msiExit});
            this.msiFile.Name = "msiFile";
            this.msiFile.Size = new System.Drawing.Size(47, 26);
            this.msiFile.Text = "&File";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.readMeToolStripMenuItem.Text = "Read me!";
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
            // msiTools
            // 
            this.msiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fptToolStripMenuItem,
            this.afuWinToolStripMenuItem});
            this.msiTools.Name = "msiTools";
            this.msiTools.Size = new System.Drawing.Size(54, 26);
            this.msiTools.Text = "&Tools";
            // 
            // fptToolStripMenuItem
            // 
            this.fptToolStripMenuItem.Name = "fptToolStripMenuItem";
            this.fptToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fptToolStripMenuItem.Text = "FPT";
            // 
            // afuWinToolStripMenuItem
            // 
            this.afuWinToolStripMenuItem.Name = "afuWinToolStripMenuItem";
            this.afuWinToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.afuWinToolStripMenuItem.Text = "AfuWin";
            // 
            // msiHelp
            // 
            this.msiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.msiHelp.Name = "msiHelp";
            this.msiHelp.Size = new System.Drawing.Size(47, 26);
            this.msiHelp.Text = "&Help";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unlockTurboBoostToolStripMenuItem,
            this.tightenRamTimingsToolStripMenuItem});
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.howToToolStripMenuItem.Text = "How to";
            // 
            // unlockTurboBoostToolStripMenuItem
            // 
            this.unlockTurboBoostToolStripMenuItem.Name = "unlockTurboBoostToolStripMenuItem";
            this.unlockTurboBoostToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.unlockTurboBoostToolStripMenuItem.Text = "Unlock Turbo Boost";
            // 
            // tightenRamTimingsToolStripMenuItem
            // 
            this.tightenRamTimingsToolStripMenuItem.Name = "tightenRamTimingsToolStripMenuItem";
            this.tightenRamTimingsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.tightenRamTimingsToolStripMenuItem.Text = "Tighten RAM timings";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(127, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // msiLanguage
            // 
            this.msiLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiLanguageEnglish,
            this.msiLanguageUkrainian});
            this.msiLanguage.Name = "msiLanguage";
            this.msiLanguage.Size = new System.Drawing.Size(75, 26);
            this.msiLanguage.Text = "&Language";
            // 
            // msiLanguageEnglish
            // 
            this.msiLanguageEnglish.Name = "msiLanguageEnglish";
            this.msiLanguageEnglish.Size = new System.Drawing.Size(144, 22);
            this.msiLanguageEnglish.Text = "English";
            this.msiLanguageEnglish.Click += new System.EventHandler(this.msiLanguageEnglish_Click);
            // 
            // msiLanguageUkrainian
            // 
            this.msiLanguageUkrainian.Name = "msiLanguageUkrainian";
            this.msiLanguageUkrainian.Size = new System.Drawing.Size(144, 22);
            this.msiLanguageUkrainian.Text = "Українська";
            this.msiLanguageUkrainian.Click += new System.EventHandler(this.msiLanguageUkrainian_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion});
            this.ssStatus.Location = new System.Drawing.Point(0, 606);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1188, 30);
            this.ssStatus.TabIndex = 1;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(301, 25);
            this.tsslVersion.Text = "Mi899 Version 1.0.0 - Copyright © Miyconst";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 636);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(1024, 675);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi899 - X99 Tool Set";
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msiExit;
        private System.Windows.Forms.ToolStripMenuItem msiExplore;
        private System.Windows.Forms.ToolStripMenuItem msiTools;
        private System.Windows.Forms.ToolStripMenuItem fptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afuWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiHelp;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiExploreMotherboards;
        private System.Windows.Forms.ToolStripMenuItem unlockTurboBoostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tightenRamTimingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msiExploreBioses;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripMenuItem msiFile;
        private System.Windows.Forms.ToolStripMenuItem msiLanguage;
        private System.Windows.Forms.ToolStripMenuItem msiLanguageEnglish;
        private System.Windows.Forms.ToolStripMenuItem msiLanguageUkrainian;
    }
}