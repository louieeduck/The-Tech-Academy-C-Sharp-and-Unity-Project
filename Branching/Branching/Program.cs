using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            string package = Console.ReadLine();
            int packweight = Convert.ToInt32(package);
            if (packweight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of the package?");
            }
            string width = Console.ReadLine();
            int packwidth = Convert.ToInt32(width);
            Console.WriteLine("What is the height of the package?");
            string height = Console.ReadLine();
            int packheight = Convert.ToInt32(width);
            Console.WriteLine("What is the length of the package?");
            string length = Console.ReadLine();
            int packlength = Convert.ToInt32(width);
            int totalsize = (packlength + packheight + packwidth);
            int size = (packlength * packheight * packwidth);
            int sizeweight = (size * packweight);
            int quote = (sizeweight / 100);
            if (totalsize > 50)
            { 
            Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            else
            {
                Console.WriteLine("Your estimated total for shipping this package is:");
                Console.WriteLine("$" + quote + ".00");
            }
           



            Console.ReadLine();
        }
    }
}
