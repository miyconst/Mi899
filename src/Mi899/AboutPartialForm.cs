using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.Diagnostics;

namespace Mi899
{
    public partial class AboutPartialForm : UserControl, II18nCompatible
    {
        public AboutPartialForm()
        {
            InitializeComponent();
        }

        public void ApplyI18n(I18n i18n)
        {
            this.ApplyI18nToChildren(i18n);
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new List<IComponent>()
            {
                lblAuthorCaption,
                lblToolSet,
                lblVersionCaption
            };
        }

        private void OnLinkLabelClick(LinkLabel label)
        {
            string url = label.Text;
            ProcessStartInfo psi = new ProcessStartInfo(url)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void lblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnLinkLabelClick((LinkLabel)sender);
        }

        private void lblYouTube_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnLinkLabelClick((LinkLabel)sender);
        }

        private void lblAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnLinkLabelClick((LinkLabel)sender);
        }
    }
}
