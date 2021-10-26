using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Person person = new Person();
            Employee employee = new Employee();

            employee.FirstName = "Sample ";
            employee.LastName = "Student";

            

            employee.SayName();
            Console.WriteLine(employee.Id);
            Console.ReadLine();
        }
    }
}
