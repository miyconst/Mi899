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
        private Model _model;
        private GenericBindingList<IMotherboard> _motherboards;

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
            List<IComponent> components = new List<IComponent>();

            components.Add(lblSearch);
            components.AddRange(grdMotherboards.Columns.OfType<DataGridViewColumn>());

            return components;
        }

        private void MotherboardsPartialForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeDataGridComponent()
        {
            grdMotherboards.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "colSelect",
                Text = "Select",
                UseColumnTextForButtonValue = true
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = nameof(IMotherboard.Id),
                DataPropertyName = nameof(IMotherboard.Id),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic,
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colBrand",
                HeaderText = nameof(IMotherboard.Brand),
                DataPropertyName = nameof(IMotherboard.Brand),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colModel",
                HeaderText = nameof(IMotherboard.Model),
                DataPropertyName = nameof(IMotherboard.Model),
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

            grdMotherboards.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "colFpt",
                HeaderText = "FPT",
                ToolTipText = "Indicates whether this motherboard is compatible with FPT",
                DataPropertyName = nameof(IMotherboard.IsFptCompatible),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "colAfuWin",
                HeaderText = "AfuWin",
                ToolTipText = "Indicates whether this motherboard is compatible with AfuWin",
                DataPropertyName = nameof(IMotherboard.IsAfuWinCompatible),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            bsMotherboards.DataSource = _motherboards;
            grdMotherboards.AutoGenerateColumns = false;
            grdMotherboards.DataSource = bsMotherboards;
            grdMotherboards.AutoResizeColumns();
        }

        private void grdMotherboards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                IMotherboard motherboard = _motherboards[e.RowIndex];
                MotherboardSelected?.Invoke(this, motherboard);
            }
        }
    }
}
