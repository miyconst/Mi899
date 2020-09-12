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

namespace Mi899
{
    public partial class ToolPartialForm : UserControl, II18nCompatible
    {
        private Model _model;
        private IMotherboard _motherboard;
        private ITool _tool;
        private IBios _bios;

        public ToolPartialForm([NotNull] Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            InitializeComponent();
        }

        public void LoadData([NotNull] IMotherboard motherboard, [NotNull] ITool tool, IBios bios)
        {
            _motherboard = motherboard ?? throw new ArgumentNullException(nameof(motherboard)); ;
            _tool = tool ?? throw new ArgumentNullException(nameof(tool));
            _bios = bios;

            ILink img = motherboard.Images.FirstOrDefault();

            if (img != null)
            {
                picMotherboard.Image = new Bitmap(img.Url);
            }
            else
            {
                picMotherboard.Image = null;
            }

            txtMotherboard.Text = motherboard.Name;
            txtMotherboardVersion.Text = motherboard.Version;
            txtTool.Text = tool.Name;

            if (bios == null)
            {
                txtBios.Text = string.Empty;
                txtBiosTurboUnlockDriver.Text = string.Empty;
            }
            else
            {
                txtBios.Text = bios.Name;
                txtBiosTurboUnlockDriver.Text = bios.TurboUnlockDriver;
            }
        }

        public void ApplyI18n([NotNull] I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
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
