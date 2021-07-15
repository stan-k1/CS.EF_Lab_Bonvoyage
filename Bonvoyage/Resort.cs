using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Resort : Hotel
    {
        public ResortType type { get; set; } = new();
        public List<Amenity> Amenities { get; set; } = new();
    }
}
