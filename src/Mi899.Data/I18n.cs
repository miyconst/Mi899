using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mi899.Data
{
    public static class I18n
    {
        public const string LanguageEn = "En";
        public const string LanguageUa = "Ua";

        private static string _language = "En";
        private static Dictionary<string, Dictionary<string, string>> _values;

        public static string Language
        {
            get => _language;
            set => _language = value ?? throw new ArgumentNullException(nameof(value));
        }

        static I18n()
        {
            string dataPath = GetDataPath();
            FileInfo fi = new FileInfo(dataPath);

            if (!fi.Exists)
            {
                throw new FileNotFoundException(fi.FullName);
            }

            using TextReader reader = new StreamReader(fi.FullName);
            string json = reader.ReadToEnd();

            _values = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
        }

        public static string Get(string text, params string[] ids)
        {
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

        public static void Dump()
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
