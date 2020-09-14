using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.Linq;

namespace Mi899
{
    public partial class MotherboardsPartialForm : UserControl, II18nCompatible
    {
        private readonly Model _model;
        private readonly GenericBindingList<IMotherboard> _motherboards;

        public event EventHandler<IMotherboard> MotherboardSelected;

        public MotherboardsPartialForm(Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _motherboards = new GenericBindingList<IMotherboard>(_model.Motherboards);
            InitializeComponent();
            InitializeDataGridComponent();
        }

        public void ApplyI18n(I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            List<IComponent> components = new List<IComponent>()
            {
                lblSearch,
                btnSearch
            };

            components.AddRange(grdMotherboards.Columns.OfType<DataGridViewColumn>());

            return components;
        }

        private void MotherboardsPartialForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeDataGridComponent()
        {
            grdMotherboards.RowTemplate.Height = 120;

            grdMotherboards.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "colSelect",
                Text = "Select",
                UseColumnTextForButtonValue = true
            });

            grdMotherboards.Columns.Add(new DataGridViewImageColumn()
            {
                Name = "colImage",
                HeaderText = "Image",
                DataPropertyName = nameof(MotherboardRowData.DefaultImage),
                ReadOnly = true,
                Width = grdMotherboards.RowTemplate.Height,
                ImageLayout = DataGridViewImageCellLayout.Stretch,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(IMotherboard.Name),
                DataPropertyName = nameof(IMotherboard.Name),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colVersion",
                HeaderText = nameof(IMotherboard.Version),
                DataPropertyName = nameof(IMotherboard.Version),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDescription",
                HeaderText = nameof(IMotherboard.Description),
                DataPropertyName = nameof(IMotherboard.Description),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTags",
                HeaderText = nameof(IMotherboard.Tags),
                DataPropertyName = nameof(MotherboardRowData.TagsString),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            PopulateDataSource();
            grdMotherboards.AutoGenerateColumns = false;
            grdMotherboards.DataSource = bsMotherboards;
            grdMotherboards.AutoResizeColumns();
        }

        private void PopulateDataSource()
        {
            string key = txtSearch.Text;
            IEnumerable<MotherboardRowData> source = _motherboards.Select(x => new MotherboardRowData(x));

            if (!string.IsNullOrWhiteSpace(key))
            {
                source = source.Where
                (
                    x => x.Name.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.TagsString.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.Description.Contains(key, StringComparison.OrdinalIgnoreCase)
                );
            }

            bsMotherboards.DataSource = new GenericBindingList<MotherboardRowData>(source);
        }

        private void grdMotherboards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                GenericBindingList<MotherboardRowData> list = (GenericBindingList<MotherboardRowData>)bsMotherboards.DataSource;

                MotherboardRowData motherboard = list[e.RowIndex];
                MotherboardSelected?.Invoke(this, motherboard.Source);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
