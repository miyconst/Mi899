using System;
using System.IO;
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
        private readonly Model _model;
        private readonly MdToHtmlConverter _mdToHtmlConverter;
        private IMotherboard _motherboard;
        private ITool _tool;
        private readonly WebBrowser _wbReadme;
        private readonly ToolManager _toolManager;

        public ToolPartialForm([NotNull] Model model, [NotNull] MdToHtmlConverter mdToHtmlConverter, [NotNull] ToolManager toolManager)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _mdToHtmlConverter = mdToHtmlConverter ?? throw new ArgumentNullException(nameof(mdToHtmlConverter));
            _toolManager = toolManager ?? throw new ArgumentNullException(nameof(toolManager));
            InitializeComponent();
            ddlBioses.DisplayMember = nameof(BiosRowData.Name);
            ddlBioses.ValueMember = nameof(BiosRowData.Id);
            txtReadme.Visible = false;
            _wbReadme = new WebBrowser()
            {
                Dock = DockStyle.Fill
            };
            tlpRightColumn.Controls.Add(_wbReadme, 0, 0);
        }

        public void LoadData([NotNull] IMotherboard motherboard, [NotNull] ITool tool, IBios selectedBios = null)
        {
            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard)); ;
            _tool = tool ?? throw new ArgumentNullException(nameof(tool));

            txtMotherboard.Text = motherboard.Name;
            txtMotherboardVersion.Text = motherboard.Version;
            txtMotherboardDescription.Text = motherboard.Description;
            txtTool.Text = tool.Name;
            txtToolVersion.Text = tool.Version;

            {
                BiosRowData[] bioses = _model
                    .Bioses
                    .Where(x => x.MotherboardIds.Contains(motherboard.Id))
                    .OrderBy(x => x.Name)
                    .Select(x => new BiosRowData(x))
                    .ToArray();
                ddlBioses.Items.Clear();
                ddlBioses.Items.AddRange(bioses);

                if (selectedBios == null)
                {
                    ddlBioses.SelectedItem = bioses.FirstOrDefault();
                }
                else
                {
                    ddlBioses.SelectedItem = bioses.First(x => x.Source.Equals(selectedBios));
                }
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
                btnSelectBiosFile
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
            BiosRowData bios = ddlBioses.SelectedItem as BiosRowData;

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

            if (ddl.SelectedItem is BiosRowData bios)
            {
                txtBiosDescription.Text = bios.Description;

                if (!string.IsNullOrEmpty(bios.ChipsetsStrings))
                {
                    txtBiosProperties.Text = $"Chipsets: {bios.ChipsetsStrings}.";
                    txtBiosProperties.Text += Environment.NewLine;
                    txtBiosProperties.Text += bios.PropertiesString;
                }
                else
                {
                    txtBiosProperties.Text = bios.PropertiesString;
                }
            }
            else
            {
                txtBiosDescription.Text = string.Empty;
                txtBiosProperties.Text = string.Empty;
            }
        }

        private void btnSelectBiosFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdBiosFile.ShowDialog();

            if (dr != DialogResult.OK)
            {
                return;
            }

            FileInfo fi = new FileInfo(ofdBiosFile.FileName);

            if (!fi.Exists)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IBios bios = _model.AddBiosFromFile(_motherboard, fi.FullName);
            LoadData(_motherboard, _tool, bios);
        }
    }
}
