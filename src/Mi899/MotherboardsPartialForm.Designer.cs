namespace Mi899
{
    partial class MotherboardsPartialForm
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdMotherboards = new System.Windows.Forms.DataGridView();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ddlMotherboardName = new System.Windows.Forms.ComboBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.bsMotherboards = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMotherboards)).BeginInit();
            this.tlpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotherboards)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grdMotherboards, 0, 1);
            this.tlpMain.Controls.Add(this.tlpSearch, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(903, 536);
            this.tlpMain.TabIndex = 1;
            // 
            // grdMotherboards
            // 
            this.grdMotherboards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMotherboards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMotherboards.Location = new System.Drawing.Point(3, 33);
            this.grdMotherboards.Name = "grdMotherboards";
            this.grdMotherboards.Size = new System.Drawing.Size(897, 500);
            this.grdMotherboards.TabIndex = 0;
            this.grdMotherboards.Text = "dataGridView1";
            this.grdMotherboards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMotherboards_CellContentClick);
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 5;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpSearch.Controls.Add(this.txtSearch, 2, 0);
            this.tlpSearch.Controls.Add(this.lblSearch, 0, 0);
            this.tlpSearch.Controls.Add(this.btnSearch, 3, 0);
            this.tlpSearch.Controls.Add(this.ddlMotherboardName, 1, 0);
            this.tlpSearch.Controls.Add(this.btnClearSearch, 4, 0);
            this.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearch.Location = new System.Drawing.Point(0, 0);
            this.tlpSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 1;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Size = new System.Drawing.Size(903, 30);
            this.tlpSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(330, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(606, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Apply";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ddlMotherboardName
            // 
            this.ddlMotherboardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlMotherboardName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMotherboardName.FormattingEnabled = true;
            this.ddlMotherboardName.Location = new System.Drawing.Point(54, 3);
            this.ddlMotherboardName.Name = "ddlMotherboardName";
            this.ddlMotherboardName.Size = new System.Drawing.Size(270, 23);
            this.ddlMotherboardName.TabIndex = 3;
            this.ddlMotherboardName.SelectedIndexChanged += new System.EventHandler(this.ddlMotherboardName_SelectedIndexChanged);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSearch.Location = new System.Drawing.Point(726, 3);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(174, 23);
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "Show All";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // MotherboardsPartialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "MotherboardsPartialForm";
            this.Size = new System.Drawing.Size(903, 536);
            this.Load += new System.EventHandler(this.MotherboardsPartialForm_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMotherboards)).EndInit();
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotherboards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMotherboards;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.BindingSource bsMotherboards;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox ddlMotherboardName;
        private System.Windows.Forms.Button btnClearSearch;
    }
}
