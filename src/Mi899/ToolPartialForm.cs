using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using CommonMark;

namespace Mi899
{
    public partial class ToolPartialForm : UserControl, II18nCompatible
    {
        private Model _model;
        private MdToHtmlConverter _mdToHtmlConverter;
        private IMotherboard _motherboard;
        private ITool _tool;
        private WebBrowser _wbReadme;

        public ToolPartialForm([NotNull] Model model, [NotNull] MdToHtmlConverter mdToHtmlConverter)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            _mdToHtmlConverter = mdToHtmlConverter ?? throw new ArgumentNullException(nameof(mdToHtmlConverter));
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

            picMotherboard.ImageLocation = motherboard.Images.FirstOrDefault()?.Url;
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
            string path = Path.GetTempPath();
            FileInfo toolFi = new FileInfo(_tool.FileName);
            FileInfo tempToolFi = new FileInfo(Path.Combine(path, toolFi.Name));
            FileInfo tempBatFi = new FileInfo(Path.Combine(path, "dump.bat"));
            string dumpFileName = $"{_motherboard.Id}-{DateTime.Now:yyyyMMdd-HHmmss}.rom";

            File.Copy(toolFi.FullName, tempToolFi.FullName);
            ZipFile.ExtractToDirectory(tempToolFi.FullName, tempToolFi.Directory.FullName);

            using TextWriter writer = new StreamWriter(tempBatFi.FullName);

            writer.WriteLine($":: {nameof(Mi899)} - {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            writer.WriteLine($":: {_motherboard.Name} {_motherboard.Version}");
            writer.WriteLine($":: {_tool.Name} {_tool.Version}");
            writer.WriteLine();
            writer.WriteLine(string.Format(_tool.DumpCommand, dumpFileName));
            writer.WriteLine("PAUSE");

            ProcessStartInfo psi = new ProcessStartInfo(path)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
