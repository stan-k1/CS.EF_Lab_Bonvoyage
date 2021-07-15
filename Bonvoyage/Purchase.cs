using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonvoyage
{
    public class Purchase
    {
        public int Id { get; set; }
        public Package Package { get; set; }
        public DateTimeOffset Date { get; set; }
        public Customer Customer { get; set; }
        public Payment Payment { get; set; }
        public Employee Employee { get; set; }
    }
}
