using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
