using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bonvoyage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            using BonContext context = new BonContext();

            //Add Employees and Customers

            Customer c = new Customer(){FirstName = "Anna", LastName = "Smith"};
            Employee m = new() {FirstName = "ManagerF", LastName = "ManagerL"};
            Employee e = new() { FirstName = "EmployeeF", LastName = "EmployeeL", Manager = m};
            //context.Customers.Add(c);
            context.Employees.Add(m);
            context.Employees.Add(e);
            context.SaveChanges();
            context.Employees.Remove(m);
            context.SaveChanges();

            //Add Destinations
            Destination paris = new Destination()
            {
                Name = "Paris",
                Description = "The City of Light",
                HasCultural = true
            };

            //Add Hotels and Resorts

            Amenity spa = new Amenity() {Name = "Spa", Description = "Spa and relaxation services."};
            Resort r = new Resort()
            {
                Name = "Awesome Spa & Resort",
                Stars = 5,
                type = ResortType.Allinclusive,
                Amenities = new() {spa},
                Destination = paris,
                Address = new Address(105, "Avenue des Champs-Élysées", "Paris", "France")
            };

            Hotel h = new Hotel()
            {
                Name = "The Balmoral",
                Stars = 5,
                Destination = paris,
                Address = new Address(1, "Princes Street", "Edinburgh", "Scotland")
            };

             context.Resorts.Add(r); //Equivalent to the below
             context.Hotels.Add(r);
             context.Hotels.Add(h);

            var hotels = context.Hotels.ToList(); //Will load both hotel and derived types (hotel and resort)
            var resorts = context.Resorts.ToList(); //Will load only the derived type (resort)
            var resortsWithAmenities = context.Resorts
                .Include(r => r.Amenities).ToList(); //Will load resorts with their amenities

            context.SaveChanges();

            //Add Packages and Purchaes

            Package parisPackage = new Package()
            {
                Days = 5,
                Hotel = r,
                Name = "Travel in Paris Package",
                Persons = 2
            };

            Purchase parisPurchase = new Purchase()
            {
                Customer = c,
                Date = DateTime.UtcNow,
                Package = parisPackage,
                Payment = new Payment(150, 5000123412341234, 145, "AMEX", context ),
                Employee = e
            };

            context.Add(parisPurchase);
            context.SaveChanges();

            //Queries
            var EmpQuery = context.Employees
                .Where(e => e.FirstName == "EmployeeF" && e.LastName == "EmployeeL")
                .Include(e => e.Sales)
                .ThenInclude(s => s.Payment)
                .ThenInclude(p => p.Card)
                .FirstOrDefault();

            Console.WriteLine(EmpQuery.Sales[0].Payment.Card.Number);

        }
    }
}
