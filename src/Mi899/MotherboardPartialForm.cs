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
        private readonly BiosManager _biosManager;
        public event EventHandler<ITool> ToolSelected;
        public MotherboardRowData Motherboard { get; private set; }

        public MotherboardPartialForm(Model model, BiosManager biosManager)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _biosManager = biosManager ?? throw new ArgumentNullException(nameof(biosManager));

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

            grdBioses.DataSource = new GenericBindingList<BiosRowData>
            (
                _model
                    .Bioses
                    .Where(x => x.MotherboardIds.Contains(motherboard.Id))
                    .Select(x => new BiosRowData(x))
            );
            grdBioses.AutoResizeColumns();

            grdLinks.DataSource = motherboard.Links;
            grdLinks.AutoResizeColumns();
        }

        public void ApplyI18n(I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
            _biosManager.ApplyI18n(i18n);
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
                lblTools,
                tpInfo,
                tpImages,
                tpBioses,
                tpLinks
            });
            components.AddRange(grdBioses.Columns.OfType<IComponent>());
            components.AddRange(grdImages.Columns.OfType<IComponent>());
            components.AddRange(grdLinks.Columns.OfType<IComponent>());

            return components;
        }

        public override void Refresh()
        {
            base.Refresh();
            grdImages.Columns[0].Width = grdImages.RowTemplate.Height;
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
                Width = grdImages.RowTemplate.Height,
                MinimumWidth = grdImages.RowTemplate.Height,
                Resizable = DataGridViewTriState.False
            });

            grdImages.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colPath",
                HeaderText = "Path",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = nameof(BiosRowData.Id),
                DataPropertyName = nameof(BiosRowData.Id),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(BiosRowData.Name),
                DataPropertyName = nameof(BiosRowData.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colProperties",
                HeaderText = nameof(BiosRowData.Properties),
                DataPropertyName = nameof(BiosRowData.PropertiesString),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colChipsets",
                HeaderText = nameof(BiosRowData.Chipsets),
                DataPropertyName = nameof(BiosRowData.ChipsetsStrings),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdBioses.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colPath",
                HeaderText = "Path",
                DataPropertyName = nameof(BiosRowData.FileName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdBioses.RowTemplate.Height = 60;
            grdBioses.AutoGenerateColumns = false;

            grdLinks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colAuthor",
                HeaderText = nameof(ILink.Author),
                DataPropertyName = nameof(ILink.Author),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdLinks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(ILink.Name),
                DataPropertyName = nameof(ILink.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdLinks.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colUrl",
                HeaderText = "URL",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            grdLinks.AutoGenerateColumns = false;
        }

        private async void grd_PathCellContentClick(object sender, DataGridViewCellEventArgs e)
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

            Cursor.Current = Cursors.WaitCursor;

            if (grid.DataSource is GenericBindingList<BiosRowData> list)
            {
                BiosRowData bios = list[e.RowIndex];

                if (bios.IsCommercial)
                {
                    UrlManager.OpenUrl(bios.DownloadUrl);
                    Cursor = Cursors.Default;
                    return;
                }

                if (!await _biosManager.DownloadBiosIfMissingAsync(bios))
                {
                    Cursor = Cursors.Default;
                    return;
                }
            }

            string path = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            if (string.IsNullOrEmpty(path))
            {
                Cursor = Cursors.Default;
                return;
            }

            FileInfo fi = new FileInfo(path);
            ProcessStartInfo startInfo = new ProcessStartInfo(fi.FullName)
            {
                UseShellExecute = true
            };

            Process.Start(startInfo);
            Cursor = Cursors.Default;
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
