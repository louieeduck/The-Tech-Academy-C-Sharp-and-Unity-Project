using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number();

            myNumber.Amount = 5;

            Console.WriteLine(myNumber.Amount);
            Console.ReadLine();
        }
    }
}
