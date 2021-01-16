using System.Collections.Generic;
using Mi899.Data;

namespace Mi899.Domain
{
    internal class Bios : IBios
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string[] MotherboardIds { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
        public string TagsString => string.Join(", ", Tags);

        public string FileName { get; set; }
        public bool IsZipped { get; set; }

        public string[] Chipsets { get; set; }
        public Dictionary<string, string> Properties { get; set; }

        IReadOnlyDictionary<string, string> IBios.Properties => Properties;
    }
}
