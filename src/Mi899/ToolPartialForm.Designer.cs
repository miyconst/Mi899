namespace Mi899
{
    partial class ToolPartialForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolPartialForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.textTool = new System.Windows.Forms.TextBox();
            this.labelTool = new System.Windows.Forms.Label();
            this.txtBiosDescription = new System.Windows.Forms.TextBox();
            this.textMotherboardVersion = new System.Windows.Forms.TextBox();
            this.labelMotherboard = new System.Windows.Forms.Label();
            this.textMotherboard = new System.Windows.Forms.TextBox();
            this.comboBoxBioses = new System.Windows.Forms.ComboBox();
            this.txtBiosProperties = new System.Windows.Forms.TextBox();
            this.textToolVersion = new System.Windows.Forms.TextBox();
            this.tlpBios = new System.Windows.Forms.TableLayoutPanel();
            this.labelBios = new System.Windows.Forms.Label();
            this.buttonSelectBiosFile = new System.Windows.Forms.Button();
            this.textMotherboardDescription = new System.Windows.Forms.TextBox();
            this.tlpRightColumn = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDump = new System.Windows.Forms.Button();
            this.buttonFlash = new System.Windows.Forms.Button();
            this.checkBoxExecuteScript = new System.Windows.Forms.CheckBox();
            this.textReadme = new System.Windows.Forms.RichTextBox();
            this.ofdBiosFile = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.tlpBios.SuspendLayout();
            this.tlpRightColumn.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpInfo, 0, 0);
            this.tlpMain.Controls.Add(this.tlpRightColumn, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(900, 700);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.textTool, 0, 9);
            this.tlpInfo.Controls.Add(this.labelTool, 0, 8);
            this.tlpInfo.Controls.Add(this.txtBiosDescription, 0, 7);
            this.tlpInfo.Controls.Add(this.textMotherboardVersion, 0, 2);
            this.tlpInfo.Controls.Add(this.labelMotherboard, 0, 0);
            this.tlpInfo.Controls.Add(this.textMotherboard, 0, 1);
            this.tlpInfo.Controls.Add(this.comboBoxBioses, 0, 5);
            this.tlpInfo.Controls.Add(this.txtBiosProperties, 0, 6);
            this.tlpInfo.Controls.Add(this.textToolVersion, 0, 10);
            this.tlpInfo.Controls.Add(this.tlpBios, 0, 4);
            this.tlpInfo.Controls.Add(this.textMotherboardDescription, 0, 3);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 11;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.Size = new System.Drawing.Size(444, 694);
            this.tlpInfo.TabIndex = 1;
            // 
            // txtTool
            // 
            this.textTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTool.Location = new System.Drawing.Point(3, 558);
            this.textTool.Multiline = true;
            this.textTool.Name = "textTool";
            this.textTool.ReadOnly = true;
            this.textTool.Size = new System.Drawing.Size(438, 101);
            this.textTool.TabIndex = 1;
            // 
            // lblTool
            // 
            this.labelTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTool.AutoSize = true;
            this.labelTool.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTool.Location = new System.Drawing.Point(3, 533);
            this.labelTool.Name = "labelTool";
            this.labelTool.Size = new System.Drawing.Size(438, 14);
            this.labelTool.TabIndex = 0;
            this.labelTool.Text = "Tool:";
            // 
            // txtBiosDescription
            // 
            this.txtBiosDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiosDescription.Location = new System.Drawing.Point(3, 403);
            this.txtBiosDescription.Multiline = true;
            this.txtBiosDescription.Name = "txtBiosDescription";
            this.txtBiosDescription.ReadOnly = true;
            this.txtBiosDescription.Size = new System.Drawing.Size(438, 119);
            this.txtBiosDescription.TabIndex = 1;
            // 
            // txtMotherboardVersion
            // 
            this.textMotherboardVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMotherboardVersion.Location = new System.Drawing.Point(3, 63);
            this.textMotherboardVersion.Name = "textMotherboardVersion";
            this.textMotherboardVersion.ReadOnly = true;
            this.textMotherboardVersion.Size = new System.Drawing.Size(438, 23);
            this.textMotherboardVersion.TabIndex = 1;
            // 
            // lblMotherboard
            // 
            this.labelMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMotherboard.AutoSize = true;
            this.labelMotherboard.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMotherboard.Location = new System.Drawing.Point(3, 8);
            this.labelMotherboard.Name = "labelMotherboard";
            this.labelMotherboard.Size = new System.Drawing.Size(438, 14);
            this.labelMotherboard.TabIndex = 0;
            this.labelMotherboard.Text = "Motherboard:";
            // 
            // txtMotherboard
            // 
            this.textMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMotherboard.Location = new System.Drawing.Point(3, 33);
            this.textMotherboard.Name = "textMotherboard";
            this.textMotherboard.ReadOnly = true;
            this.textMotherboard.Size = new System.Drawing.Size(438, 23);
            this.textMotherboard.TabIndex = 1;
            // 
            // ddlBioses
            // 
            this.comboBoxBioses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBioses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBioses.FormattingEnabled = true;
            this.comboBoxBioses.Location = new System.Drawing.Point(3, 248);
            this.comboBoxBioses.Name = "comboBoxBioses";
            this.comboBoxBioses.Size = new System.Drawing.Size(438, 23);
            this.comboBoxBioses.TabIndex = 2;
            this.comboBoxBioses.SelectedIndexChanged += new System.EventHandler(this.ddlBioses_SelectedIndexChanged);
            // 
            // txtBiosProperties
            // 
            this.txtBiosProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiosProperties.Location = new System.Drawing.Point(3, 278);
            this.txtBiosProperties.Multiline = true;
            this.txtBiosProperties.Name = "txtBiosProperties";
            this.txtBiosProperties.ReadOnly = true;
            this.txtBiosProperties.Size = new System.Drawing.Size(438, 119);
            this.txtBiosProperties.TabIndex = 3;
            // 
            // txtToolVersion
            // 
            this.textToolVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textToolVersion.Location = new System.Drawing.Point(3, 666);
            this.textToolVersion.Name = "textToolVersion";
            this.textToolVersion.ReadOnly = true;
            this.textToolVersion.Size = new System.Drawing.Size(438, 23);
            this.textToolVersion.TabIndex = 4;
            // 
            // tlpBios
            // 
            this.tlpBios.ColumnCount = 2;
            this.tlpBios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpBios.Controls.Add(this.labelBios, 0, 0);
            this.tlpBios.Controls.Add(this.buttonSelectBiosFile, 1, 0);
            this.tlpBios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBios.Location = new System.Drawing.Point(0, 215);
            this.tlpBios.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBios.Name = "tlpBios";
            this.tlpBios.RowCount = 1;
            this.tlpBios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBios.Size = new System.Drawing.Size(444, 30);
            this.tlpBios.TabIndex = 5;
            // 
            // lblBios
            // 
            this.labelBios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBios.AutoSize = true;
            this.labelBios.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBios.Location = new System.Drawing.Point(3, 8);
            this.labelBios.Name = "labelBios";
            this.labelBios.Size = new System.Drawing.Size(138, 14);
            this.labelBios.TabIndex = 0;
            this.labelBios.Text = "BIOS:";
            // 
            // btnSelectBiosFile
            // 
            this.buttonSelectBiosFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectBiosFile.Location = new System.Drawing.Point(147, 3);
            this.buttonSelectBiosFile.Name = "buttonSelectBiosFile";
            this.buttonSelectBiosFile.Size = new System.Drawing.Size(294, 23);
            this.buttonSelectBiosFile.TabIndex = 1;
            this.buttonSelectBiosFile.Text = "Select BIOS file";
            this.buttonSelectBiosFile.UseVisualStyleBackColor = true;
            this.buttonSelectBiosFile.Click += new System.EventHandler(this.btnSelectBiosFile_Click);
            // 
            // txtMotherboardDescription
            // 
            this.textMotherboardDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMotherboardDescription.Location = new System.Drawing.Point(3, 93);
            this.textMotherboardDescription.Multiline = true;
            this.textMotherboardDescription.Name = "textMotherboardDescription";
            this.textMotherboardDescription.ReadOnly = true;
            this.textMotherboardDescription.Size = new System.Drawing.Size(438, 119);
            this.textMotherboardDescription.TabIndex = 6;
            // 
            // tlpRightColumn
            // 
            this.tlpRightColumn.ColumnCount = 1;
            this.tlpRightColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightColumn.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpRightColumn.Controls.Add(this.textReadme, 0, 0);
            this.tlpRightColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRightColumn.Location = new System.Drawing.Point(450, 0);
            this.tlpRightColumn.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRightColumn.Name = "tlpRightColumn";
            this.tlpRightColumn.RowCount = 2;
            this.tlpRightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpRightColumn.Size = new System.Drawing.Size(450, 700);
            this.tlpRightColumn.TabIndex = 3;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 4;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpButtons.Controls.Add(this.buttonDump, 2, 0);
            this.tlpButtons.Controls.Add(this.buttonFlash, 3, 0);
            this.tlpButtons.Controls.Add(this.checkBoxExecuteScript, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 668);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(444, 29);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnDump
            // 
            this.buttonDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDump.Location = new System.Drawing.Point(47, 3);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Size = new System.Drawing.Size(194, 23);
            this.buttonDump.TabIndex = 0;
            this.buttonDump.Text = "Dump current BIOS";
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // btnFlash
            // 
            this.buttonFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlash.Location = new System.Drawing.Point(247, 3);
            this.buttonFlash.Name = "buttonFlash";
            this.buttonFlash.Size = new System.Drawing.Size(194, 23);
            this.buttonFlash.TabIndex = 1;
            this.buttonFlash.Text = "Flash selected BIOS";
            this.buttonFlash.UseVisualStyleBackColor = true;
            this.buttonFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // cbExecuteScript
            // 
            this.checkBoxExecuteScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExecuteScript.AutoSize = true;
            this.checkBoxExecuteScript.Enabled = false;
            this.checkBoxExecuteScript.Location = new System.Drawing.Point(3, 5);
            this.checkBoxExecuteScript.Name = "checkBoxExecuteScript";
            this.checkBoxExecuteScript.Size = new System.Drawing.Size(18, 19);
            this.checkBoxExecuteScript.TabIndex = 2;
            this.checkBoxExecuteScript.Text = "Execute script";
            this.checkBoxExecuteScript.UseVisualStyleBackColor = true;
            this.checkBoxExecuteScript.Visible = false;
            // 
            // txtReadme
            // 
            this.textReadme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textReadme.Location = new System.Drawing.Point(3, 3);
            this.textReadme.Name = "textReadme";
            this.textReadme.ReadOnly = true;
            this.textReadme.Size = new System.Drawing.Size(444, 659);
            this.textReadme.TabIndex = 1;
            this.textReadme.Text = resources.GetString("txtReadme.Text");
            // 
            // ofdBiosFile
            // 
            this.ofdBiosFile.Filter = "BIOS files (*.bin;*.rom)|*.bin;*.rom|All files (*.*)|*.*";
            // 
            // ToolPartialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ToolPartialForm";
            this.Size = new System.Drawing.Size(900, 700);
            this.tlpMain.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tlpBios.ResumeLayout(false);
            this.tlpBios.PerformLayout();
            this.tlpRightColumn.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label labelMotherboard;
        private System.Windows.Forms.Label labelBios;
        private System.Windows.Forms.TextBox textMotherboard;
        private System.Windows.Forms.TextBox textMotherboardVersion;
        private System.Windows.Forms.TextBox txtBiosDescription;
        private System.Windows.Forms.Label labelTool;
        private System.Windows.Forms.TextBox textTool;
        private System.Windows.Forms.TableLayoutPanel tlpRightColumn;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button buttonDump;
        private System.Windows.Forms.Button buttonFlash;
        private System.Windows.Forms.RichTextBox textReadme;
        private System.Windows.Forms.CheckBox checkBoxExecuteScript;
        private System.Windows.Forms.ComboBox comboBoxBioses;
        private System.Windows.Forms.TextBox txtBiosProperties;
        private System.Windows.Forms.TextBox textToolVersion;
        private System.Windows.Forms.TableLayoutPanel tlpBios;
        private System.Windows.Forms.Button buttonSelectBiosFile;
        private System.Windows.Forms.OpenFileDialog ofdBiosFile;
        private System.Windows.Forms.TextBox textMotherboardDescription;
    }
}
