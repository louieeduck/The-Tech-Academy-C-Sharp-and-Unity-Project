using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest1
{
    public class Employee
    {
        public String lastName { get; set; }
        public String firstName { get; set; }
        public double ID { get; set; }
        public object nub1 { get; set; }
        public object nub2 { get; set; }
        public object nub3 { get; set; }
        public object nub4 { get; set; }
        public object nub5 { get; set; }
        public object nub6 { get; set; }
        public object nub7 { get; set; }
        public object nub8 { get; set; }
        public object nub9 { get; set; }
        public object nub10 { get; set; }

        public Employee()
        {
        }

        public Employee(String firstName, String lastName, double ID)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.ID = ID;
        }

    }
}
