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
        Model _model;

        public MotherboardPartialForm(Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));

            InitializeComponent();
            InitializeExtraComponent();
        }

        public void LoadData(IMotherboard motherboard)
        {
            if (motherboard == null) throw new ArgumentNullException(nameof(motherboard));

            picMotherboard.ImageLocation = motherboard.Images.FirstOrDefault()?.Url;
            txtId.Text = motherboard.Id;
            txtName.Text = motherboard.Name;
            txtBrand.Text = motherboard.Brand;
            txtModel.Text = motherboard.Model;
            txtVersion.Text = motherboard.Version;
            txtTags.Text = motherboard.TagsString;
            txtDescription.Text = motherboard.Description;
            cbFpt.Checked = motherboard.IsFptCompatible;
            cbAfuWin.Checked = motherboard.IsAfuWinCompatible;

            grdImages.DataSource = motherboard.Images.Select(x => new
            {
                x.Name,
                x.Url,
                Image = new Bitmap(x.Url)
            }).ToList();
            grdImages.AutoResizeColumns();

            grdBioses.DataSource = new GenericBindingList<IBios>(_model.Bioses.Where(x => x.MotherboardIds.Contains(motherboard.Id)));
            grdBioses.AutoResizeColumns();

            grdLinks.DataSource = motherboard.Links;
            grdLinks.AutoResizeColumns();
        }

        private void InitializeExtraComponent()
        {
            tcTabs.SelectedTab = tcTabs.TabPages[0];

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

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IBios.Id),
                DataPropertyName = nameof(IBios.Id),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IBios.Name),
                DataPropertyName = nameof(IBios.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "TU Driver",
                ToolTipText = "Turbo Boost Unlock Driver",
                DataPropertyName = nameof(IBios.TurboUnlockDriver),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewLinkColumn()
            {
                HeaderText = "Path",
                DataPropertyName = nameof(IBios.FileName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.AutoGenerateColumns = false;

            grdLinks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(ILink.Name),
                DataPropertyName = nameof(ILink.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdLinks.Columns.Add(new DataGridViewLinkColumn()
            {
                HeaderText = "URL",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdLinks.AutoGenerateColumns = false;
        }

        private void grd_PathCellContentClick(object sender, DataGridViewCellEventArgs e)
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
            ProcessStartInfo startInfo = new ProcessStartInfo(fi.FullName)
            {
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }

        private void grdImages_CellContentClick(object sender, DataGridViewCellEventArgs e) => grd_PathCellContentClick(sender, e);

        private void grdBioses_CellContentClick(object sender, DataGridViewCellEventArgs e) => grd_PathCellContentClick(sender, e);

        private void grdLinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            string url = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            ProcessStartInfo psi = new ProcessStartInfo(url)
            {
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
