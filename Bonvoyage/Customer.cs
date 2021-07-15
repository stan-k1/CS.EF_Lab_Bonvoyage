using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Phone { get; set; }
        public Address Address { get; set; }

        public DateTimeOffset BirthDate { get; set; } = new();
        public List<Purchase> Purchases { get; set; } = new();

    }
}
