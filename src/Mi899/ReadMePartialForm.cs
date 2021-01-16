using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CommonMark;
using Mi899.Data;

namespace Mi899
{
    public partial class ReadMePartialForm : UserControl, II18nCompatible
    {
        private readonly WebBrowser _browser = new WebBrowser();
        private readonly MdToHtmlConverter _mdToHtmlConverter;

        public ReadMePartialForm(MdToHtmlConverter mdToHtmlConverter)
        {
            _mdToHtmlConverter = mdToHtmlConverter ?? throw new ArgumentNullException(nameof(mdToHtmlConverter));
            InitializeComponent();
            _browser.Name = "wbReadme";
            _browser.Dock = DockStyle.Fill;
            Controls.Add(_browser);
        }

        public void ApplyI18n(I18n i18n)
        {
            var path = GetReadmeMdPath(i18n);
            using TextReader reader = new StreamReader(path);
            var md = reader.ReadToEnd();
            var html = _mdToHtmlConverter.Convert(md);

            _browser.DocumentText = html;
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new List<IComponent>();
        }

        private string GetReadmeMdPath(I18n i18n)
        {
            var path = typeof(ReadMePartialForm).Assembly.Location;
            var fileInfo = new FileInfo(path);
            var name = i18n.Get("README.md", Name, _browser.Name, nameof(WebBrowser.DocumentText));

            if (fileInfo.Directory != null)
            {
                path = Path.Join(fileInfo.Directory.FullName, name);
            }

            return path;
        }
    }
}
