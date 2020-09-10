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
    public partial class BiosesPartialForm : UserControl, II18nCompatible
    {
        private Model _model;

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
            List<IComponent> components = new List<IComponent>();

            components.Add(lblSearch);
            components.AddRange(grdBioses.Columns.OfType<IComponent>());

            return components;
        }

        private void InitializeDataGridComponent()
        {
            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = nameof(IBios.Id),
                DataPropertyName = nameof(IBios.Id),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic,
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = nameof(IBios.Name),
                DataPropertyName = nameof(IBios.Name),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTuDriver",
                HeaderText = "TU Driver",
                DataPropertyName = nameof(IBios.TurboUnlockDriver),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdBioses.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "colTags",
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
