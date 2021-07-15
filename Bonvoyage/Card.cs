using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Card
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Number { get; set; }

        [MinLength(3), MaxLength(3)]
        public long CCV { get; set; }

        [Required]
        public string Issuer { get; set; }
    }
}
