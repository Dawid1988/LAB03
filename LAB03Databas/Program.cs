using System;
using System.Linq;

namespace LAB03Databas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCustomers();

        }

        static void ListCustomers()
        {
            using (var db = new DentalCareContext())
            {
                var customerList = db.Customers.ToList();

                foreach (var customer in customerList)
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName}, {customer.SocialSecurityNumber}");
                }
            }
        }
    }
}
