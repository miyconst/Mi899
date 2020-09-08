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
        private GenericBindingList<IBios> _bioses;

        public MotherboardPartialForm(IMotherboard motherboard, Model model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard));
            _bioses = new GenericBindingList<IBios>(model.Bioses.Where(x => x.MotherboardIds.Contains(motherboard.Id)));
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
            grdBioses.DataSource = _bioses;
            grdBioses.AutoResizeColumns();

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
            grdLinks.DataSource = _motherboard.Links;
            grdLinks.AutoResizeColumns();
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
