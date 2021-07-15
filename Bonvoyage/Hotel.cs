using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0,5, ErrorMessage = "Starts must always be between 0 and 5")]
        public int Stars { get; set;}
        public int Telephone { get; set; }
        public Address Address { get; set; }
        public Destination Destination { get; set; }
    }
}
