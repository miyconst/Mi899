namespace Mi899
{
    partial class MotherboardPartialForm
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.picMotherboard = new System.Windows.Forms.PictureBox();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTools = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tpImages = new System.Windows.Forms.TabPage();
            this.grdImages = new System.Windows.Forms.DataGridView();
            this.tpBioses = new System.Windows.Forms.TabPage();
            this.grdBioses = new System.Windows.Forms.DataGridView();
            this.tpLinks = new System.Windows.Forms.TabPage();
            this.grdLinks = new System.Windows.Forms.DataGridView();
            this.txtTools = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMotherboard)).BeginInit();
            this.tcTabs.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdImages)).BeginInit();
            this.tpBioses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBioses)).BeginInit();
            this.tpLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpMain.Controls.Add(this.tcTabs, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMain.Size = new System.Drawing.Size(874, 514);
            this.tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.picMotherboard, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 508);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // picMotherboard
            // 
            this.picMotherboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMotherboard.Location = new System.Drawing.Point(3, 3);
            this.picMotherboard.Name = "picMotherboard";
            this.picMotherboard.Size = new System.Drawing.Size(188, 194);
            this.picMotherboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMotherboard.TabIndex = 0;
            this.picMotherboard.TabStop = false;
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tpInfo);
            this.tcTabs.Controls.Add(this.tpImages);
            this.tcTabs.Controls.Add(this.tpBioses);
            this.tcTabs.Controls.Add(this.tpLinks);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(203, 3);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 2;
            this.tcTabs.Size = new System.Drawing.Size(668, 508);
            this.tcTabs.TabIndex = 0;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.tableLayoutPanel1);
            this.tpInfo.Location = new System.Drawing.Point(4, 24);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(660, 480);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtTools, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTools, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBrand, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblModel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblVersion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTags, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDescription, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBrand, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtModel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtVersion, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTags, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblTools
            // 
            this.lblTools.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTools.AutoSize = true;
            this.lblTools.Location = new System.Drawing.Point(3, 287);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(37, 15);
            this.lblTools.TabIndex = 1;
            this.lblTools.Text = "Tools:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(79, 33);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(572, 23);
            this.txtName.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 7);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(3, 67);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 15);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Brand:";
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(3, 97);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(44, 15);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(3, 127);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version:";
            // 
            // lblTags
            // 
            this.lblTags.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(3, 157);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(33, 15);
            this.lblTags.TabIndex = 6;
            this.lblTags.Text = "Tags:";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 222);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Location = new System.Drawing.Point(79, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(572, 23);
            this.txtId.TabIndex = 8;
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBrand.Location = new System.Drawing.Point(79, 63);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(572, 23);
            this.txtBrand.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.Location = new System.Drawing.Point(79, 93);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(572, 23);
            this.txtModel.TabIndex = 10;
            // 
            // txtVersion
            // 
            this.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVersion.Location = new System.Drawing.Point(79, 123);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(572, 23);
            this.txtVersion.TabIndex = 11;
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTags.Location = new System.Drawing.Point(79, 153);
            this.txtTags.Name = "txtTags";
            this.txtTags.ReadOnly = true;
            this.txtTags.Size = new System.Drawing.Size(572, 23);
            this.txtTags.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(79, 183);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(572, 94);
            this.txtDescription.TabIndex = 13;
            // 
            // tpImages
            // 
            this.tpImages.Controls.Add(this.grdImages);
            this.tpImages.Location = new System.Drawing.Point(4, 24);
            this.tpImages.Name = "tpImages";
            this.tpImages.Padding = new System.Windows.Forms.Padding(3);
            this.tpImages.Size = new System.Drawing.Size(660, 480);
            this.tpImages.TabIndex = 2;
            this.tpImages.Text = "Images";
            this.tpImages.UseVisualStyleBackColor = true;
            // 
            // grdImages
            // 
            this.grdImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdImages.Location = new System.Drawing.Point(3, 3);
            this.grdImages.Name = "grdImages";
            this.grdImages.Size = new System.Drawing.Size(654, 474);
            this.grdImages.TabIndex = 0;
            this.grdImages.Text = "dataGridView1";
            this.grdImages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdImages_CellContentClick);
            // 
            // tpBioses
            // 
            this.tpBioses.Controls.Add(this.grdBioses);
            this.tpBioses.Location = new System.Drawing.Point(4, 24);
            this.tpBioses.Name = "tpBioses";
            this.tpBioses.Size = new System.Drawing.Size(660, 480);
            this.tpBioses.TabIndex = 3;
            this.tpBioses.Text = "BIOS";
            // 
            // grdBioses
            // 
            this.grdBioses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBioses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBioses.Location = new System.Drawing.Point(0, 0);
            this.grdBioses.Name = "grdBioses";
            this.grdBioses.Size = new System.Drawing.Size(660, 480);
            this.grdBioses.TabIndex = 0;
            this.grdBioses.Text = "dataGridView1";
            this.grdBioses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBioses_CellContentClick);
            // 
            // tpLinks
            // 
            this.tpLinks.Controls.Add(this.grdLinks);
            this.tpLinks.Location = new System.Drawing.Point(4, 24);
            this.tpLinks.Name = "tpLinks";
            this.tpLinks.Padding = new System.Windows.Forms.Padding(3);
            this.tpLinks.Size = new System.Drawing.Size(660, 480);
            this.tpLinks.TabIndex = 1;
            this.tpLinks.Text = "Links";
            this.tpLinks.UseVisualStyleBackColor = true;
            // 
            // grdLinks
            // 
            this.grdLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLinks.Location = new System.Drawing.Point(3, 3);
            this.grdLinks.Name = "grdLinks";
            this.grdLinks.Size = new System.Drawing.Size(654, 474);
            this.grdLinks.TabIndex = 0;
            this.grdLinks.Text = "dataGridView1";
            this.grdLinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLinks_CellContentClick);
            // 
            // txtTools
            // 
            this.txtTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTools.Location = new System.Drawing.Point(79, 283);
            this.txtTools.Name = "txtTools";
            this.txtTools.ReadOnly = true;
            this.txtTools.Size = new System.Drawing.Size(572, 23);
            this.txtTools.TabIndex = 1;
            // 
            // MotherboardPartialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "MotherboardPartialForm";
            this.Size = new System.Drawing.Size(874, 514);
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMotherboard)).EndInit();
            this.tcTabs.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdImages)).EndInit();
            this.tpBioses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBioses)).EndInit();
            this.tpLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.PictureBox picMotherboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TabPage tpLinks;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TabPage tpImages;
        private System.Windows.Forms.DataGridView grdImages;
        private System.Windows.Forms.TabPage tpBioses;
        private System.Windows.Forms.DataGridView grdBioses;
        private System.Windows.Forms.DataGridView grdLinks;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.TextBox txtTools;
    }
}
