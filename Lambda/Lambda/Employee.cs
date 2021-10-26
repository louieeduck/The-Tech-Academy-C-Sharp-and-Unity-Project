using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public List<Employee> Employees { get; set; }

    }
}
