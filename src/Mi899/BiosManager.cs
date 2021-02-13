using Mi899.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi899
{
    public class BiosManager : II18nCompatible
    {
        private string _errorString = "Error";
        private string _unableToDownloadBiosFileString = "Unable to download required BIOS file. Check your internet connection.";

        public BiosManager()
        {
        }

        public string Name => nameof(BiosManager);

        public void ApplyI18n(I18n i18n)
        {
            _errorString = i18n.Get(_errorString, this.Name, nameof(_errorString));
            _unableToDownloadBiosFileString = i18n.Get(_unableToDownloadBiosFileString, this.Name, nameof(_unableToDownloadBiosFileString));
        }

        public async Task<bool> DownloadBiosIfMissingAsync(BiosRowData bios)
        {
            if (File.Exists(bios.FileName))
            {
                return true;
            }

            try
            {
                HttpClient client = new HttpClient();
                using Stream stream = await client.GetStreamAsync(bios.DownloadUrl);
                using FileStream file = File.OpenWrite(bios.FileName);

                stream.CopyTo(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(_unableToDownloadBiosFileString + " " + ex.ToString(), _errorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public IEnumerable<IComponent> SelectI18nCompatibleComponents()
        {
            return new IComponent[0];
        }
    }
}
