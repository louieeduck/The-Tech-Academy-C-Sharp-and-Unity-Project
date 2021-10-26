using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee();
            

            string firstName = "Sample ";
            string lastName = "Student";
            int Id = 1;

            string firstName2 = "Different ";
            string lastName2 = "Student";
            int Id2 = 1;

            employee.sayName(firstName, lastName);
            employee.Quit(employee);

            employee.sayName(firstName2, lastName2);



            Console.ReadLine();
        }
    }
}
