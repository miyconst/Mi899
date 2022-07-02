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
using System.Diagnostics;

namespace Mi899
{
    public partial class ReadMePartialForm : UserControl, II18nCompatible
    {
        private WebBrowser _browser = new WebBrowser();
        private MdToHtmlConverter _mdToHtmlConverter;

        public ReadMePartialForm(MdToHtmlConverter mdToHtmlConverter)
        {
            _mdToHtmlConverter = mdToHtmlConverter ?? throw new ArgumentNullException(nameof(mdToHtmlConverter));
            InitializeComponent();
            _browser.Name = "wbReadme";
            _browser.Dock = DockStyle.Fill;
            _browser.Navigating += OnBrowser_Navigating;
            Controls.Add(_browser);
        }

        public void ApplyI18n(I18n i18n)
        {
            string path = GetReadmeMdPath(i18n);
            using TextReader reader = new StreamReader(path);
            string md = reader.ReadToEnd();
            string html = _mdToHtmlConverter.Convert(md);

            _browser.DocumentText = html;
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new List<IComponent>();
        }

        private string GetReadmeMdPath(I18n i18n)
        {
            string path = typeof(ReadMePartialForm).Assembly.Location;
            FileInfo fi = new FileInfo(path);
            string name = i18n.Get("README.md", Name, _browser.Name, nameof(WebBrowser.DocumentText));

            path = Path.Join(fi.Directory.FullName, name);

            return path;
        }

        private void OnBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsolutePath == "blank")
                return;

            e.Cancel = true;

            string url = e.Url.ToString();

            try
            {
                Process.Start(url);
                return;
            }
            catch
            { 
            }

            try
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                return;
            }
            catch
            {
            }

            MessageBox.Show(url);
        }
    }
}
