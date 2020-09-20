using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mi899.Data
{
    public class I18n
    {
        private string _language = "En";
        private Dictionary<string, Dictionary<string, string>> _values;

        public string Language
        {
            get => _language;
            set => _language = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Get(string text, params string[] ids)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            if (ids == null || !ids.Any())
            {
                throw new ArgumentException(nameof(ids));
            }

            string id = string.Join(".", ids);
            Dictionary<string, string> localValues;

            if (!_values.TryGetValue(Language, out localValues))
            {
                localValues = new Dictionary<string, string>();
                _values.Add(Language, localValues);
            }

            string value;

            if (!localValues.TryGetValue(id, out value))
            {
                value = text;
                localValues.Add(id, value);
            }

            return value;
        }

        public void Dump()
        {
            Dictionary<string, Dictionary<string, string>> result = _values
                .OrderBy(x => x.Key)
                .ToDictionary
                (
                    k => k.Key,
                    v => v.Value
                        .OrderBy(x => x.Key)
                        .ToDictionary(k => k.Key, v => v.Value)
                );
            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            string dataPath = GetDataPath();
            using TextWriter writer = new StreamWriter(dataPath, false, Encoding.UTF8);
            writer.Write(json);
            writer.Flush();
        }

        public static I18n LoadFromJson()
        {
            I18n result = new I18n();
            string dataPath = GetDataPath();
            FileInfo fi = new FileInfo(dataPath);

            if (!fi.Exists)
            {
                throw new FileNotFoundException(fi.FullName);
            }

            using TextReader reader = new StreamReader(fi.FullName);
            string json = reader.ReadToEnd();

            result._values = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);

            return result;
        }

        private static string GetDataPath()
        {
            string assemblyLocation = System.Reflection.Assembly.GetAssembly(typeof(I18n)).Location;
            FileInfo fi = new FileInfo(assemblyLocation);
            DirectoryInfo di = fi.Directory;
            string dataPath = Path.Combine(fi.DirectoryName, nameof(I18n) + ".json");

            return dataPath;
        }
    }
}
