using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Mi899
{
    public static class UrlManager
    {
        public static void OpenUrl(string url)
        {
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
