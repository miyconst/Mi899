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

        public string FileName { get; set; }

        public string TurboUnlockDriver { get; set; }

        public bool IsTurboUnlocked { get; set; }

        public string[] Chipsets { get; set; }
    }
}
