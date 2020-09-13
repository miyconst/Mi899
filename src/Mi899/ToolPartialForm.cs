using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Mi899
{
    public partial class ToolPartialForm : UserControl, II18nCompatible
    {
        private Model _model;
        private MdToHtmlConverter _mdToHtmlConverter;
        private IMotherboard _motherboard;
        private ITool _tool;
        private WebBrowser _wbReadme;
        private ToolManager _toolManager;

        public ToolPartialForm([NotNull] Model model, [NotNull] MdToHtmlConverter mdToHtmlConverter, [NotNull] ToolManager toolManager)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _mdToHtmlConverter = mdToHtmlConverter ?? throw new ArgumentNullException(nameof(mdToHtmlConverter));
            _toolManager = toolManager ?? throw new ArgumentNullException(nameof(toolManager));
            InitializeComponent();
            ddlBioses.DisplayMember = nameof(IBios.Name);
            ddlBioses.ValueMember = nameof(IBios.Id);
            txtReadme.Visible = false;
            _wbReadme = new WebBrowser();
            _wbReadme.Dock = DockStyle.Fill;
            tlpRightColumn.Controls.Add(_wbReadme, 0, 0);
        }

        public void LoadData([NotNull] IMotherboard motherboard, [NotNull] ITool tool)
        {
            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard)); ;
            _tool = tool ?? throw new ArgumentNullException(nameof(tool));

            txtMotherboard.Text = motherboard.Name;
            txtMotherboardVersion.Text = motherboard.Version;
            txtTool.Text = tool.Name;

            {
                IBios[] bioses = _model
                    .Bioses
                    .Where(x => x.MotherboardIds.Contains(motherboard.Id))
                    .OrderBy(x => x.Name)
                    .ToArray();
                ddlBioses.Items.Clear();
                ddlBioses.Items.AddRange(bioses);
                ddlBioses.SelectedItem = bioses.FirstOrDefault();
            }
        }

        public void ApplyI18n([NotNull] I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);

            string md = i18n.Get(txtReadme.Text, this.GetI18nCompatibleParent().Name, Name, txtReadme.Name, nameof(TextBox.Text));
            string html = _mdToHtmlConverter.Convert(md);
            _wbReadme.DocumentText = html;

        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new IComponent[]
            {
                lblBios,
                lblMotherboard,
                lblTool,
                btnDump,
                btnFlash,
                cbExecuteScript,
            };
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _toolManager.Dump(_motherboard, _tool, cbExecuteScript.Checked);
            Cursor = Cursors.Default;
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            IBios bios = ddlBioses.SelectedItem as IBios;

            if (bios == null)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            _toolManager.Flash(_motherboard, bios, _tool, cbExecuteScript.Checked);
            Cursor = Cursors.Default;
        }

        private void ddlBioses_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox ddl = (ComboBox)sender;

            if (ddl.SelectedItem is IBios bios)
            {
                txtBiosDescription.Text = bios.Description;
            }
            else
            {
                txtBiosDescription.Text = string.Empty;
            }
        }
    }
}
