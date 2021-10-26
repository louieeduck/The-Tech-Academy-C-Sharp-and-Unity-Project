using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            Number number = new Number();

            Console.WriteLine("What number do you want the math operations on.");
            int UserX = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(number.Addition(UserX));
            Console.WriteLine(number.Div(UserX));
            Console.WriteLine(number.Mult(UserX));

            Console.ReadLine();
        }

    }
}
