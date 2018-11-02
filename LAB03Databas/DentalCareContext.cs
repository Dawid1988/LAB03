using System;
using System.Collections.Generic;
using System.Text;
using LAB03Databas.Domain;
using Microsoft.EntityFrameworkCore;


namespace LAB03Databas
{
    class DentalCareContext : DbContext
    {

        public System.Data.Entity.DbSet<Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<Appointment> Appointments { get; set; }

        protected void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-5V8GU1UJ\\SQLEXPRESS;Initial Catalog=DentalCareDB;Integrated Security=True");
        }
    }
}

