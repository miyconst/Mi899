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
    public partial class MotherboardPartialForm : UserControl, II18nCompatible
    {
        private readonly Model _model;
        public event EventHandler<ITool> ToolSelected;
        public MotherboardRowData Motherboard { get; private set; }

        public MotherboardPartialForm(Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));

            InitializeComponent();
            InitializeExtraComponent();
        }

        public void LoadData(IMotherboard motherboard)
        {
            Motherboard = new MotherboardRowData(motherboard ?? throw new ArgumentNullException(nameof(motherboard)));

            picMotherboard.ImageLocation = Motherboard.Images.FirstOrDefault()?.Url;
            txtId.Text = Motherboard.Id;
            txtName.Text = Motherboard.Name;
            txtBrand.Text = Motherboard.Brand;
            txtModel.Text = Motherboard.Model;
            txtVersion.Text = Motherboard.Version;
            txtTags.Text = Motherboard.TagsString;
            txtDescription.Text = Motherboard.Description;

            {
                List<ITool> tools = _model.Tools.Where(x => motherboard.ToolIds.Contains(x.Id)).ToList();

                flpTools.Controls.Clear();

                foreach (ITool item in tools)
                {
                    ITool tool = item;
                    LinkLabel lbl = new LinkLabel()
                    {
                        Text = tool.Name,
                        AutoSize = true,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    flpTools.Controls.Add(lbl);

                    lbl.Click += (s, a) =>
                    {
                        ToolSelected?.Invoke(this, tool);
                    };
                }
            }

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

        public void ApplyI18n(I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            List<IComponent> components = new List<IComponent>();

            components.AddRange(new Control[]
            {
                lblId,
                lblName,
                lblBrand,
                lblModel,
                lblVersion,
                lblTags,
                lblDescription,
                lblTools
            });
            components.AddRange(grdBioses.Columns.OfType<IComponent>());
            components.AddRange(grdImages.Columns.OfType<IComponent>());
            components.AddRange(grdLinks.Columns.OfType<IComponent>());

            return components;
        }

        private void InitializeExtraComponent()
        {
            tcTabs.SelectedTab = tcTabs.TabPages[0];

            grdImages.RowTemplate.Height = 120;
            grdImages.AutoGenerateColumns = false;

            grdImages.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "colImage",
                HeaderText = "Image",
                DataPropertyName = "Image",
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = grdImages.RowTemplate.Height
            });

            grdImages.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colPath",
                HeaderText = "Path",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = nameof(IBios.Id),
                DataPropertyName = nameof(IBios.Id),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(IBios.Name),
                DataPropertyName = nameof(IBios.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTuDriver",
                HeaderText = "TU Driver",
                ToolTipText = "Turbo Boost Unlock Driver",
                DataPropertyName = nameof(IBios.TurboUnlockDriver),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colPath",
                HeaderText = "Path",
                DataPropertyName = nameof(IBios.FileName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdBioses.AutoGenerateColumns = false;

            grdLinks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(ILink.Name),
                DataPropertyName = nameof(ILink.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grdLinks.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colUrl",
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
