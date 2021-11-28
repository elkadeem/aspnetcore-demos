using EFDemo.Genertated;
using System;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDbContext dbContext = new CustomDbContext();

            dbContext.Customers.Add(new Customer
            {
                BirthDate = DateTime.Today.AddYears(21),
                Name = "Wael",
            });

            dbContext.Customers.Add(new Customer
            {
                BirthDate = DateTime.Today.AddYears(18),
                Name = "Wael 2",
            }); 

            dbContext.SaveChanges();

            var cusotmers = dbContext.Customers.ToList();
            foreach (var customer in cusotmers)
            {
                Console.WriteLine($"Id: {customer.Id}, name: {customer.Name}");
            }

            var firstCustomers = dbContext.Customers.Where(customer => customer.Name.StartsWith("Wa"));

            foreach (var customer in firstCustomers)
            {
                Console.WriteLine($"Id: {customer.Id}, name: {customer.Name}");
            }
            
            Console.WriteLine("Hello World!");

            GenerateddbContext contex = new GenerateddbContext();

            Console.WriteLine($"Customers: {contex.Customers.Count()}");
                 
        }
    }
}
