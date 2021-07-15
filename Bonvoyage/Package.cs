using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Persons { get; set; }
        public int Days { get; set; }
        public Hotel Hotel { get; set; }
    }
}
