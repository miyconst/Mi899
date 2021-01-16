using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;
using Mi899.Data;
using Mi899.Domain;

namespace Mi899
{
    public partial class BiosesPartialForm : UserControl, II18nCompatible
    {
        private readonly Model _model;

        public BiosesPartialForm(Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
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
                lblSearch,
                btnSearch
            };

            compatibleComponents.AddRange(grdBioses.Columns.OfType<IComponent>());

            return compatibleComponents;
        }

        private void InitializeDataGridComponent()
        {
            grdBioses.RowTemplate.Height = 80;

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(BiosRowData.Name),
                DataPropertyName = nameof(BiosRowData.Name),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle() 
                { 
                    WrapMode = DataGridViewTriState.True 
                }
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colProperties",
                HeaderText = nameof(BiosRowData.Properties),
                DataPropertyName = nameof(BiosRowData.PropertiesString),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colDescription",
                HeaderText = nameof(BiosRowData.Description),
                DataPropertyName = nameof(BiosRowData.Description),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTags",
                HeaderText = nameof(BiosRowData.Tags),
                DataPropertyName = nameof(BiosRowData.TagsString),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
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
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            grdBioses.Columns.Add(new DataGridViewLinkColumn()
            {
                Name = "colFileName",
                HeaderText = "File path",
                DataPropertyName = nameof(BiosRowData.FileName),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                SortMode = DataGridViewColumnSortMode.Automatic,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    WrapMode = DataGridViewTriState.True
                }
            });

            PopulateDataSource();
            grdBioses.AutoGenerateColumns = false;
            grdBioses.DataSource = bsBioses;
            grdBioses.AutoResizeColumns();
        }

        private void PopulateDataSource()
        {
            var key = txtSearch.Text;
            var biosRowDatas = _model.Bioses.Select(x => new BiosRowData(x));

            if (!string.IsNullOrWhiteSpace(key))
            { 
                biosRowDatas = biosRowDatas.Where
                (
                    x => x.Name.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.TagsString.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.Description.Contains(key, StringComparison.OrdinalIgnoreCase)
                        || x.PropertiesString.Contains(key, StringComparison.OrdinalIgnoreCase)
                );
            }

            bsBioses.DataSource = new GenericBindingList<BiosRowData>(biosRowDatas);
        }

        private void grdBioses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (!(grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn) || e.RowIndex < 0)
            {
                return;
            }
            var list = (GenericBindingList<BiosRowData>)bsBioses.DataSource;

            var bios = list[e.RowIndex];
            var processStartInfo = new ProcessStartInfo(bios.FileName)
            {
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
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
