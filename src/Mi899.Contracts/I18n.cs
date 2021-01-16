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

            var id = string.Join(".", ids);

            if (!_values.TryGetValue(Language, out var localValues))
            {
                localValues = new Dictionary<string, string>();
                _values.Add(Language, localValues);
            }

            if (!localValues.TryGetValue(id, out var value))
            {
                value = text;
                localValues.Add(id, value);
            }

            return value;
        }

        public void Dump()
        {
            var result = _values
                .OrderBy(x => x.Key)
                .ToDictionary
                (
                    k => k.Key,
                    v => v.Value
                        .OrderBy(x => x.Key)
                        .ToDictionary(k => k.Key, v => v.Value)
                );
            var json = JsonConvert.SerializeObject(result, Formatting.Indented);
            var dataPath = GetDataPath();
            using TextWriter writer = new StreamWriter(dataPath, false, Encoding.UTF8);
            writer.Write(json);
            writer.Flush();
        }

        public static I18n LoadFromJson()
        {
            I18n result = new I18n();
            string dataPath = GetDataPath();
            var fileInfo = new FileInfo(dataPath);

            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException(fileInfo.FullName);
            }

            using TextReader reader = new StreamReader(fileInfo.FullName);
            var json = reader.ReadToEnd();

            result._values = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);

            return result;
        }

        private static string GetDataPath()
        {
            var assemblyLocation = System.Reflection.Assembly.GetAssembly(typeof(I18n)).Location;
            var fileInfo = new FileInfo(assemblyLocation);
            var directoryInfo = fileInfo.Directory;
            var dataPath = Path.Combine(fileInfo.DirectoryName ?? string.Empty, nameof(I18n) + ".json");

            return dataPath;
        }
    }
}
