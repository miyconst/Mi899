using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Mi899.Data;
using Newtonsoft.Json;

namespace Mi899.Domain
{
    public class Model
    {
        private readonly List<Motherboard> _motherboards;
        private readonly List<Bios> _bioses;
        private readonly List<Tool> _tools;
        private readonly List<Language> _languages;

        public IEnumerable<IMotherboard> Motherboards => _motherboards;
        public IEnumerable<IBios> Bioses => _bioses;
        public IEnumerable<ITool> Tools => _tools;
        public IEnumerable<ILanguage> Languages => _languages;

        public Model()
        {
            _motherboards = new List<Motherboard>();
            _bioses = new List<Bios>();
            _tools = new List<Tool>();
            _languages = new List<Language>();
        }

        public IBios AddBiosFromFile([NotNull] IMotherboard motherboard, [NotNull] string fileName)
        {
            if (motherboard == null) throw new ArgumentNullException(nameof(motherboard));
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));

            var fileInfo = new FileInfo(fileName);

            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException("File not found", fileInfo.FullName);
            }

            var oldBios = _bioses.FirstOrDefault(x => fileInfo.FullName.Equals(x.FileName, StringComparison.OrdinalIgnoreCase));
            var newBios = new Bios()
            {
                Name = fileInfo.Name,
                FileName = fileInfo.FullName,
                IsZipped = false,
                Description = "User selected file",
                Properties = new Dictionary<string, string>() 
                {
                    { "Path", fileInfo.FullName }
                },
                MotherboardIds = new string[] { motherboard.Id },
                Chipsets = new string[0]
            };

            if (oldBios != null)
            {
                _bioses.Remove(oldBios);
            }

            _bioses.Add(newBios);

            return newBios;
        }

        public static Model LoadFromJson()
        {
            var assemblyLocation = System.Reflection.Assembly.GetAssembly(typeof(Model)).Location;
            var fileInfo = new FileInfo(assemblyLocation);
            var directoryInfo = fileInfo.Directory;
            var dataPath = Path.Combine(fileInfo.DirectoryName ?? string.Empty, nameof(Model) + ".json");
            fileInfo = new FileInfo(dataPath);

            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException(fileInfo.FullName);
            }

            using TextReader reader = new StreamReader(fileInfo.FullName);
            var json = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<Model>(json);

            foreach (var link in model._motherboards.SelectMany(m => m.Images))
            {
                if (directoryInfo != null)
                {
                    link.Url = Path.Combine(directoryInfo.FullName, link.Url);
                }
            }

            foreach (var bios in model._bioses)
            {
                if (directoryInfo != null)
                {
                    bios.FileName = Path.Combine(directoryInfo.FullName, bios.FileName);
                }
                bios.IsZipped = true;
            }

            foreach (var tool in model._tools.Where(tool => directoryInfo != null))
            {
                tool.FileName = Path.Combine(directoryInfo?.FullName ?? string.Empty, tool.FileName);
            }

            return model;
        }
    }
}
