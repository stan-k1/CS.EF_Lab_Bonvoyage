using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasCultural { get; set; } = false;
        public bool HasBeaches { get; set; } = false;
        public bool HasSnow { get; set; } = false;
    }
}
