using Mi899.Data;

namespace Mi899.Domain
{
    internal class Tool : ITool
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Version { get; set; }

        public string DumpCommand { get; set; }

        public string FlashCommand { get; set; }

        public string FileName { get; set; }
    }
}
