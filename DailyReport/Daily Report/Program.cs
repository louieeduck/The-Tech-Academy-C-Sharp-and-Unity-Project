using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\" \n\"Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pagenum = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            int studyhours = Convert.ToInt32(study);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
