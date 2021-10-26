using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> stringemp = new Employee<string>();
            Employee<int> intemp = new Employee<int>();

            List<string> StringList = new List<string>() {"Hello", "Goodbye", "Greetings", "hi", "bye" };
            List<int> IntList = new List<int>() {5, 2, 109, 23, 2958, 2837, 1, 5872 };

            
            foreach (string i in StringList)
            {
                Console.WriteLine(i);
            }
            foreach (int j in IntList)
            {
                Console.WriteLine(j);
            }


            Console.ReadLine();
        }
    }
}
