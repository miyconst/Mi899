using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Mi899.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Mi899.Domain;

namespace Mi899
{
    public partial class ToolPartialForm : UserControl, II18nCompatible
    {
        private readonly Model _model;
        private readonly MdToHtmlConverter _mdToHtmlConverter;
        private IMotherboard _motherboard;
        private ITool _tool;
        private readonly WebBrowser _webBrowserReadme;
        private readonly ToolManager _toolManager;

        public ToolPartialForm([NotNull] Model model, [NotNull] MdToHtmlConverter mdToHtmlConverter, [NotNull] ToolManager toolManager)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _mdToHtmlConverter = mdToHtmlConverter ?? throw new ArgumentNullException(nameof(mdToHtmlConverter));
            _toolManager = toolManager ?? throw new ArgumentNullException(nameof(toolManager));
            InitializeComponent();
            comboBoxBioses.DisplayMember = nameof(BiosRowData.Name);
            comboBoxBioses.ValueMember = nameof(BiosRowData.Id);
            textReadme.Visible = false;
            _webBrowserReadme = new WebBrowser()
            {
                Dock = DockStyle.Fill
            };
            tlpRightColumn.Controls.Add(_webBrowserReadme, 0, 0);
        }

        public void LoadData([NotNull] IMotherboard motherboard, [NotNull] ITool tool, IBios selectedBios = null)
        {
            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard)); ;
            _tool = tool ?? throw new ArgumentNullException(nameof(tool));

            textMotherboard.Text = motherboard.Name;
            textMotherboardVersion.Text = motherboard.Version;
            textMotherboardDescription.Text = motherboard.Description;
            textTool.Text = tool.Name;
            textToolVersion.Text = tool.Version;

            {
                var bioses = _model
                    .Bioses
                    .Where(x => x.MotherboardIds.Contains(motherboard.Id))
                    .OrderBy(x => x.Name)
                    .Select(x => new BiosRowData(x))
                    .ToArray();
                comboBoxBioses.Items.Clear();
                comboBoxBioses.Items.AddRange(bioses);

                comboBoxBioses.SelectedItem = selectedBios == null 
                    ? bioses.FirstOrDefault() 
                    : bioses.First(x => x.Source.Equals(selectedBios));
            }
        }

        public void ApplyI18n([NotNull] I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);

            var md = i18n.Get(textReadme.Text, this.GetI18nCompatibleParent().Name, Name, textReadme.Name, nameof(TextBox.Text));
            var html = _mdToHtmlConverter.Convert(md);
            _webBrowserReadme.DocumentText = html;
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new IComponent[]
            {
                labelBios,
                labelMotherboard,
                labelTool,
                buttonDump,
                buttonFlash,
                checkBoxExecuteScript,
                buttonSelectBiosFile
            };
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            _toolManager.Dump(_motherboard, _tool, checkBoxExecuteScript.Checked);
            Cursor = Cursors.Default;
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            var bios = comboBoxBioses.SelectedItem as BiosRowData;

            if (bios == null)
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            _toolManager.Flash(_motherboard, bios, _tool, checkBoxExecuteScript.Checked);
            Cursor = Cursors.Default;
        }

        private void ddlBioses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;

            if (comboBox.SelectedItem is BiosRowData bios)
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
            var dialogResult = ofdBiosFile.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            var fileInfo = new FileInfo(ofdBiosFile.FileName);

            if (!fileInfo.Exists)
            {
                MessageBox.Show("File not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bios = _model.AddBiosFromFile(_motherboard, fileInfo.FullName);
            LoadData(_motherboard, _tool, bios);
        }
    }
}
