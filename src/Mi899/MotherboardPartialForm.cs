using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Mi899.Data;
using System.IO;
using System.Diagnostics;
using Mi899.Domain;

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

            pictureBoxMotherboard.ImageLocation = Motherboard.Images.FirstOrDefault()?.Url;
            textBoxId.Text = Motherboard.Id;
            textBoxName.Text = Motherboard.Name;
            textBoxBrand.Text = Motherboard.Brand;
            textBoxModel.Text = Motherboard.Model;
            textBoxVersion.Text = Motherboard.Version;
            textBoxTags.Text = Motherboard.TagsString;
            textBoxDescription.Text = Motherboard.Description;

            {
                var tools = _model.Tools.Where(x => motherboard.ToolIds.Contains(x.Id)).ToList();

                flowLayoutPanel.Controls.Clear();

                foreach (var tool in tools)
                {
                    var linkLabel = new LinkLabel()
                    {
                        Text = tool.Name,
                        AutoSize = true,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    flowLayoutPanel.Controls.Add(linkLabel);

                    linkLabel.Click += (s, a) =>
                    {
                        ToolSelected?.Invoke(this, tool);
                    };
                }
            }

            gridImages.DataSource = motherboard.Images.Select(x => new
            {
                x.Name,
                x.Url,
                Image = new Bitmap(x.Url)
            }).ToList();
            gridImages.AutoResizeColumns();

            gridBioses.DataSource = new GenericBindingList<BiosRowData>
            (
                _model
                    .Bioses
                    .Where(x => x.MotherboardIds.Contains(motherboard.Id))
                    .Select(x => new BiosRowData(x))
            );
            gridBioses.AutoResizeColumns();

            gridLinks.DataSource = motherboard.Links;
            gridLinks.AutoResizeColumns();
        }

        public void ApplyI18n(I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            var compatibleComponents = new List<IComponent>();

            compatibleComponents.AddRange(new Control[]
            {
                labelId,
                labelName,
                labelBrand,
                labelModel,
                labelVersion,
                labelTags,
                labelDescription,
                labelTools,
                tabPageInfo,
                tabPageImages,
                tabPageBioses,
                tabPageLinks
            });
            compatibleComponents.AddRange(gridBioses.Columns.OfType<IComponent>());
            compatibleComponents.AddRange(gridImages.Columns.OfType<IComponent>());
            compatibleComponents.AddRange(gridLinks.Columns.OfType<IComponent>());

            return compatibleComponents;
        }

        public override void Refresh()
        {
            base.Refresh();
            gridImages.Columns[0].Width = gridImages.RowTemplate.Height;
        }

        private void InitializeExtraComponent()
        {
            tabControlTabs.SelectedTab = tabControlTabs.TabPages[0];

            gridImages.RowTemplate.Height = 120;
            gridImages.AutoGenerateColumns = false;

            gridImages.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "colImage",
                HeaderText = "Image",
                DataPropertyName = "Image",
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                Width = gridImages.RowTemplate.Height,
                MinimumWidth = gridImages.RowTemplate.Height,
                Resizable = DataGridViewTriState.False
            });

            gridImages.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colPath",
                HeaderText = "Path",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = nameof(BiosRowData.Id),
                DataPropertyName = nameof(BiosRowData.Id),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(BiosRowData.Name),
                DataPropertyName = nameof(BiosRowData.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridBioses.Columns.Add(new DataGridViewTextBoxColumn()
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

            gridBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colChipsets",
                HeaderText = nameof(BiosRowData.Chipsets),
                DataPropertyName = nameof(BiosRowData.ChipsetsStrings),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridBioses.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colPath",
                HeaderText = "Path",
                DataPropertyName = nameof(BiosRowData.FileName),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridBioses.RowTemplate.Height = 60;
            gridBioses.AutoGenerateColumns = false;

            gridLinks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colAuthor",
                HeaderText = nameof(ILink.Author),
                DataPropertyName = nameof(ILink.Author),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridLinks.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(ILink.Name),
                DataPropertyName = nameof(ILink.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridLinks.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colUrl",
                HeaderText = "URL",
                DataPropertyName = nameof(ILink.Url),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            gridLinks.AutoGenerateColumns = false;
        }

        private void grid_PathCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var grid = (DataGridView)sender;

            if (!(grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn))
            {
                return;
            }

            var path = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var fileInfo = new FileInfo(path);
            var processStartInfo = new ProcessStartInfo(fileInfo.FullName)
            {
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }

        private void gridImages_CellContentClick(object sender, DataGridViewCellEventArgs e) => grid_PathCellContentClick(sender, e);

        private void gridBioses_CellContentClick(object sender, DataGridViewCellEventArgs e) => grid_PathCellContentClick(sender, e);

        private void gridLinks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var grid = (DataGridView)sender;

            if (!(grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn))
            {
                return;
            }

            var url = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            var processStartInfo = new ProcessStartInfo(url)
            {
                UseShellExecute = true
            };
            Process.Start(processStartInfo);
        }
    }
}
