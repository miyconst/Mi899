using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Mi899.Data;
using System.Linq;
using Mi899.Domain;

namespace Mi899
{
    public partial class MotherboardsPartialForm : UserControl, II18nCompatible
    {
        private readonly GenericBindingList<IMotherboard> _motherboards;

        public event EventHandler<IMotherboard> MotherboardSelected;

        public MotherboardsPartialForm(Model model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _motherboards = new GenericBindingList<IMotherboard>(model.Motherboards);
            InitializeComponent();
            InitializeDataGridComponent();
        }

        public void ApplyI18n(I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            var compatibleComponents = new List<IComponent>()
            {
                labelSearch,
                buttonSearch
            };

            compatibleComponents.AddRange(gridMotherboards.Columns.OfType<DataGridViewColumn>());

            return compatibleComponents;
        }

        private void MotherboardsPartialForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeDataGridComponent()
        {
            gridMotherboards.RowTemplate.Height = 120;

            gridMotherboards.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "colSelect",
                Text = "Select",
                UseColumnTextForButtonValue = true
            });

            gridMotherboards.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "colImage",
                HeaderText = "Image",
                DataPropertyName = nameof(MotherboardRowData.DefaultImage),
                ReadOnly = true,
                Width = gridMotherboards.RowTemplate.Height,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            gridMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(IMotherboard.Name),
                DataPropertyName = nameof(IMotherboard.Name),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            gridMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colVersion",
                HeaderText = nameof(IMotherboard.Version),
                DataPropertyName = nameof(IMotherboard.Version),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            gridMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDescription",
                HeaderText = nameof(IMotherboard.Description),
                DataPropertyName = nameof(IMotherboard.Description),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            gridMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTags",
                HeaderText = nameof(IMotherboard.Tags),
                DataPropertyName = nameof(MotherboardRowData.TagsString),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            PopulateDataSource();
            gridMotherboards.AutoGenerateColumns = false;
            gridMotherboards.DataSource = bindingSourceMotherboards;
            gridMotherboards.AutoResizeColumns();
        }

        private void PopulateDataSource()
        {
            var key = txtSearch.Text;
            var motherboardRowDatas = _motherboards.Select(x => new MotherboardRowData(x));

            if (!string.IsNullOrWhiteSpace(key))
            {
                motherboardRowDatas = motherboardRowDatas.Where
                (
                    x => x.Name.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.TagsString.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.Description.Contains(key, StringComparison.OrdinalIgnoreCase)
                );
            }

            bindingSourceMotherboards.DataSource = new GenericBindingList<MotherboardRowData>(motherboardRowDatas);
        }

        private void gridMotherboards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (!(grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
            {
                return;
            }
            var motherboardRowDatas = (GenericBindingList<MotherboardRowData>)bindingSourceMotherboards.DataSource;

            var motherboard = motherboardRowDatas[e.RowIndex];
            MotherboardSelected?.Invoke(this, motherboard.Source);
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char KEY_ENTER = (char)13;
            if (e.KeyChar == KEY_ENTER)
            {
                PopulateDataSource();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateDataSource();
        }
    }
}
