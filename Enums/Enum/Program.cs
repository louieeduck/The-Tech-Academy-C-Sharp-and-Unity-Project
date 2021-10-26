using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum DaysOfWeek
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday 
        }

        static void Main(string[] args)
        {

            Console.WriteLine("What day of the week is it? With 1 starting on Sunday and Saturday being 7");
            string User = Console.ReadLine();

            try
            {
                DaysOfWeek daysOfWeek = (DaysOfWeek)Convert.ToInt32(User);
                Console.WriteLine(daysOfWeek);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }



            Console.ReadLine();
        }
    }
}
