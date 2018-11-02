using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace LAB03Databas.Domain
{
    class Appointment
    {
        public int Id { get; set; }
        public Customer Customer{ get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }

    }
}
