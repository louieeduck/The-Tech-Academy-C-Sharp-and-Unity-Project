using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employ = new Employee();
            Employee id = new Employee();
            Employee id2 = new Employee();

            if (id.Id1 == id2.Id2)
                Console.WriteLine("They are equal");

            else
                Console.WriteLine("They are not equal");



            Console.ReadLine();
        }
    }
}
