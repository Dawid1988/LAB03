using System;
using System.Collections.Generic;
using System.Text;

namespace LAB03Databas.Domain
{
    class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
