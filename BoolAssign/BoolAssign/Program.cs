using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolAssign
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int whatage = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            bool haveDUI = Convert.ToBoolean(DUI);
            Console.WriteLine("How many speeding tickets do you have");
            string speeding = Console.ReadLine();
            int speednum = Convert.ToInt32(speeding);

            Console.WriteLine("Qualified?");
            bool Application = (whatage > 15 && (haveDUI == false) && (speednum <= 3));
            Console.WriteLine(Application);
            Console.ReadLine();

            Console.ReadLine();

        }
    }
}
