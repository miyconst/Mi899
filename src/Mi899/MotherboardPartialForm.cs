using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.IO;
using System.Diagnostics;

namespace Mi899
{
    public partial class MotherboardPartialForm : UserControl
    {
        private IMotherboard _motherboard;

        public MotherboardPartialForm(IMotherboard motherboard)
        {
            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard));
            InitializeComponent();
            InitializeExtraComponent();
        }

        private void InitializeExtraComponent()
        {
            tcTabs.SelectedTab = tcTabs.TabPages[0];
            picMotherboard.ImageLocation = _motherboard.Images.FirstOrDefault()?.Url;
            txtId.Text = _motherboard.Id;
            txtName.Text = _motherboard.Name;
            txtBrand.Text = _motherboard.Brand;
            txtModel.Text = _motherboard.Model;
            txtVersion.Text = _motherboard.Version;
            txtTags.Text = _motherboard.TagsString;
            txtDescription.Text = _motherboard.Description;

            grdImages.Columns.Add(new DataGridViewImageColumn()
            {
                HeaderText = "Image",
                DataPropertyName = "Image",
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = 120
            });

            grdImages.Columns.Add(new DataGridViewLinkColumn()
            {
                HeaderText = "Path",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdImages.RowTemplate.Height = 120;
            grdImages.AutoGenerateColumns = false;
            grdImages.DataSource = _motherboard.Images.Select(x => new
            {
                x.Name,
                x.Url,
                Image = new Bitmap(x.Url)
            }).ToList();
            grdImages.AutoResizeColumns();
        }

        private void grdImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridView grid = (DataGridView)sender;

            if (!(grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn))
            {
                return;
            }

            string path = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            FileInfo fi = new FileInfo(path);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = fi.Directory.FullName,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }
    }
}
