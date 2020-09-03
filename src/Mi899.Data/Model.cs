using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Mi899.Data
{
    public class Model
    {
        private List<Motherboard> _motherboards;
        private List<Bios> _bioses;

        public IReadOnlyList<IMotherboard> Motherboards => _motherboards;
        public IReadOnlyList<IBios> Bioses => _bioses;

        public Model()
        {
            _motherboards = new List<Motherboard>();
            _bioses = new List<Bios>();
        }

        public static Model LoadFromJson()
        {
            string assemblyLocation = System.Reflection.Assembly.GetAssembly(typeof(Model)).Location;
            FileInfo fi = new FileInfo(assemblyLocation);
            DirectoryInfo di = fi.Directory;
            string dataPath = Path.Combine(fi.DirectoryName, nameof(Model) + ".json");
            fi = new FileInfo(dataPath);

            if (!fi.Exists)
            {
                throw new FileNotFoundException(fi.FullName);
            }

            using TextReader reader = new StreamReader(fi.FullName);
            string json = reader.ReadToEnd();
            Model model = JsonConvert.DeserializeObject<Model>(json);

            foreach (Motherboard m in model._motherboards)
            {
                foreach (Link i in m.Images)
                {
                    i.Url = Path.Combine(di.FullName, i.Url);
                }
            }

            foreach (Bios b in model._bioses)
            {
                b.FileName = Path.Combine(di.FullName, b.FileName);
            }

            return model;
        }
    }
}
