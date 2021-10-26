using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparision
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your Hourly Rate?");
            string rate = Console.ReadLine();
            int rate1 = Convert.ToInt32(rate);
  
            Console.WriteLine("How many hours did you work this week?");
            string work = Console.ReadLine();
            int work1 = Convert.ToInt32(work);
    
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your Hourly Rate?");
            string rate2 = Console.ReadLine();
            int rate3 = Convert.ToInt32(rate2);

            Console.WriteLine("How many hours did you work this week?");
            string work2 = Console.ReadLine();
            int work3 = Convert.ToInt32(work2);
            Console.WriteLine("The salary of Person 1 is: ");
            int salary = rate1 * work1 * 52;
            Console.WriteLine(salary);
            //Console.WriteLine("Annual salary of Person 2");
            Console.WriteLine("The salary of Person 2 is: ");
            int salary2 = rate3 * work3 * 52;
            Console.WriteLine(salary2);

            bool greaterthan = salary >= salary2;
            Console.WriteLine(greaterthan);
            Console.ReadLine();
            


            Console.ReadLine();
        }
    }
}
