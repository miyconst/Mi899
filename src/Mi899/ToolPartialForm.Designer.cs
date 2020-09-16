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
            this.txtTool = new System.Windows.Forms.TextBox();
            this.lblTool = new System.Windows.Forms.Label();
            this.txtBiosDescription = new System.Windows.Forms.TextBox();
            this.txtMotherboardVersion = new System.Windows.Forms.TextBox();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.txtMotherboard = new System.Windows.Forms.TextBox();
            this.lblBios = new System.Windows.Forms.Label();
            this.ddlBioses = new System.Windows.Forms.ComboBox();
            this.txtBiosProperties = new System.Windows.Forms.TextBox();
            this.txtToolVersion = new System.Windows.Forms.TextBox();
            this.tlpRightColumn = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDump = new System.Windows.Forms.Button();
            this.btnFlash = new System.Windows.Forms.Button();
            this.cbExecuteScript = new System.Windows.Forms.CheckBox();
            this.txtReadme = new System.Windows.Forms.RichTextBox();
            this.tlpMain.SuspendLayout();
            this.tlpInfo.SuspendLayout();
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
            this.tlpInfo.Controls.Add(this.txtTool, 0, 8);
            this.tlpInfo.Controls.Add(this.lblTool, 0, 7);
            this.tlpInfo.Controls.Add(this.txtBiosDescription, 0, 6);
            this.tlpInfo.Controls.Add(this.txtMotherboardVersion, 0, 2);
            this.tlpInfo.Controls.Add(this.lblMotherboard, 0, 0);
            this.tlpInfo.Controls.Add(this.txtMotherboard, 0, 1);
            this.tlpInfo.Controls.Add(this.lblBios, 0, 3);
            this.tlpInfo.Controls.Add(this.ddlBioses, 0, 4);
            this.tlpInfo.Controls.Add(this.txtBiosProperties, 0, 5);
            this.tlpInfo.Controls.Add(this.txtToolVersion, 0, 9);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 10;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpInfo.Size = new System.Drawing.Size(444, 694);
            this.tlpInfo.TabIndex = 1;
            // 
            // txtTool
            // 
            this.txtTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTool.Location = new System.Drawing.Point(3, 521);
            this.txtTool.Multiline = true;
            this.txtTool.Name = "txtTool";
            this.txtTool.ReadOnly = true;
            this.txtTool.Size = new System.Drawing.Size(438, 139);
            this.txtTool.TabIndex = 1;
            // 
            // lblTool
            // 
            this.lblTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTool.AutoSize = true;
            this.lblTool.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTool.Location = new System.Drawing.Point(3, 496);
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(438, 14);
            this.lblTool.TabIndex = 0;
            this.lblTool.Text = "Tool:";
            // 
            // txtBiosDescription
            // 
            this.txtBiosDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiosDescription.Location = new System.Drawing.Point(3, 322);
            this.txtBiosDescription.Multiline = true;
            this.txtBiosDescription.Name = "txtBiosDescription";
            this.txtBiosDescription.ReadOnly = true;
            this.txtBiosDescription.Size = new System.Drawing.Size(438, 163);
            this.txtBiosDescription.TabIndex = 1;
            // 
            // txtMotherboardVersion
            // 
            this.txtMotherboardVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotherboardVersion.Location = new System.Drawing.Point(3, 63);
            this.txtMotherboardVersion.Name = "txtMotherboardVersion";
            this.txtMotherboardVersion.ReadOnly = true;
            this.txtMotherboardVersion.Size = new System.Drawing.Size(438, 23);
            this.txtMotherboardVersion.TabIndex = 1;
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMotherboard.Location = new System.Drawing.Point(3, 8);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(438, 14);
            this.lblMotherboard.TabIndex = 0;
            this.lblMotherboard.Text = "Motherboard:";
            // 
            // txtMotherboard
            // 
            this.txtMotherboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotherboard.Location = new System.Drawing.Point(3, 33);
            this.txtMotherboard.Name = "txtMotherboard";
            this.txtMotherboard.ReadOnly = true;
            this.txtMotherboard.Size = new System.Drawing.Size(438, 23);
            this.txtMotherboard.TabIndex = 1;
            // 
            // lblBios
            // 
            this.lblBios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBios.AutoSize = true;
            this.lblBios.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBios.Location = new System.Drawing.Point(3, 98);
            this.lblBios.Name = "lblBios";
            this.lblBios.Size = new System.Drawing.Size(438, 14);
            this.lblBios.TabIndex = 0;
            this.lblBios.Text = "BIOS:";
            // 
            // ddlBioses
            // 
            this.ddlBioses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlBioses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlBioses.FormattingEnabled = true;
            this.ddlBioses.Location = new System.Drawing.Point(3, 123);
            this.ddlBioses.Name = "ddlBioses";
            this.ddlBioses.Size = new System.Drawing.Size(438, 23);
            this.ddlBioses.TabIndex = 2;
            this.ddlBioses.SelectedIndexChanged += new System.EventHandler(this.ddlBioses_SelectedIndexChanged);
            // 
            // txtBiosProperties
            // 
            this.txtBiosProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBiosProperties.Location = new System.Drawing.Point(3, 153);
            this.txtBiosProperties.Multiline = true;
            this.txtBiosProperties.Name = "txtBiosProperties";
            this.txtBiosProperties.ReadOnly = true;
            this.txtBiosProperties.Size = new System.Drawing.Size(438, 163);
            this.txtBiosProperties.TabIndex = 3;
            // 
            // txtToolVersion
            // 
            this.txtToolVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToolVersion.Location = new System.Drawing.Point(3, 667);
            this.txtToolVersion.Name = "txtToolVersion";
            this.txtToolVersion.ReadOnly = true;
            this.txtToolVersion.Size = new System.Drawing.Size(438, 23);
            this.txtToolVersion.TabIndex = 4;
            // 
            // tlpRightColumn
            // 
            this.tlpRightColumn.ColumnCount = 1;
            this.tlpRightColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRightColumn.Controls.Add(this.tlpButtons, 0, 1);
            this.tlpRightColumn.Controls.Add(this.txtReadme, 0, 0);
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
            this.tlpButtons.Controls.Add(this.btnDump, 2, 0);
            this.tlpButtons.Controls.Add(this.btnFlash, 3, 0);
            this.tlpButtons.Controls.Add(this.cbExecuteScript, 0, 0);
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
            this.btnDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDump.Location = new System.Drawing.Point(47, 3);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(194, 23);
            this.btnDump.TabIndex = 0;
            this.btnDump.Text = "Dump current BIOS";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // btnFlash
            // 
            this.btnFlash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlash.Location = new System.Drawing.Point(247, 3);
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.Size = new System.Drawing.Size(194, 23);
            this.btnFlash.TabIndex = 1;
            this.btnFlash.Text = "Flash selected BIOS";
            this.btnFlash.UseVisualStyleBackColor = true;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // cbExecuteScript
            // 
            this.cbExecuteScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExecuteScript.AutoSize = true;
            this.cbExecuteScript.Enabled = false;
            this.cbExecuteScript.Location = new System.Drawing.Point(3, 5);
            this.cbExecuteScript.Name = "cbExecuteScript";
            this.cbExecuteScript.Size = new System.Drawing.Size(18, 19);
            this.cbExecuteScript.TabIndex = 2;
            this.cbExecuteScript.Text = "Execute script";
            this.cbExecuteScript.UseVisualStyleBackColor = true;
            this.cbExecuteScript.Visible = false;
            // 
            // txtReadme
            // 
            this.txtReadme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReadme.Location = new System.Drawing.Point(3, 3);
            this.txtReadme.Name = "txtReadme";
            this.txtReadme.ReadOnly = true;
            this.txtReadme.Size = new System.Drawing.Size(444, 659);
            this.txtReadme.TabIndex = 1;
            this.txtReadme.Text = resources.GetString("txtReadme.Text");
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
            this.tlpRightColumn.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.Label lblBios;
        private System.Windows.Forms.TextBox txtMotherboard;
        private System.Windows.Forms.TextBox txtMotherboardVersion;
        private System.Windows.Forms.TextBox txtBiosDescription;
        private System.Windows.Forms.Label lblTool;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.TableLayoutPanel tlpRightColumn;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Button btnFlash;
        private System.Windows.Forms.RichTextBox txtReadme;
        private System.Windows.Forms.CheckBox cbExecuteScript;
        private System.Windows.Forms.ComboBox ddlBioses;
        private System.Windows.Forms.TextBox txtBiosProperties;
        private System.Windows.Forms.TextBox txtToolVersion;
    }
}
