using System;

namespace Mi899.Data
{
    internal class Bios : IBios
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string[] MotherboardIds { get; set; }
        public string Description { get; set; }
        public string[] Tags { get; set; }
    }
}
