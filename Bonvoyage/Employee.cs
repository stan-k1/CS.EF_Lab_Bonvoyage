using System;
using System.Collections.Generic;

namespace Bonvoyage
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public Employee Manager { get; set; }
        public int? ManagerId { get; set; }
        public List<Purchase> Sales { get; set; }
    }
}
