using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03Databas.Domain
{
    class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        public Customer()
        {

        }

        public Customer(int id, string firstname, string lastName, string socialSecurityNumber)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
