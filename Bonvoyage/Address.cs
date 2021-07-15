using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public record Address
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Road { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address(int number, string road, string city, string country)
        {
            Number = number;
            Road = road;
            City = city;
            Country = country;
        }
    }
}
