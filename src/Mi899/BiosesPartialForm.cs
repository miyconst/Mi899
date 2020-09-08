using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;

namespace Mi899
{
    public partial class BiosesPartialForm : UserControl
    {
        private Model _model;

        public BiosesPartialForm(Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            InitializeComponent();
            InitializeDataGridComponent();
        }

        private void InitializeDataGridComponent()
        {
            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IBios.Id),
                DataPropertyName = nameof(IBios.Id),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic,
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IBios.Name),
                DataPropertyName = nameof(IBios.Name),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "TU Driver",
                DataPropertyName = nameof(IBios.TurboUnlockDriver),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IBios.Tags),
                DataPropertyName = nameof(IBios.TagsString),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            bsBioses.DataSource = new GenericBindingList<IBios>(_model.Bioses);
            grdBioses.AutoGenerateColumns = false;
            grdBioses.DataSource = bsBioses;
            grdBioses.AutoResizeColumns();
        }
    }
}
