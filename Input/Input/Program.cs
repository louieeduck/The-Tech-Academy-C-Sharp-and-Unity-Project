using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Pick a number");
            string ans = Console.ReadLine();
            int userans = Convert.ToInt32(ans);
            Console.WriteLine(DateTime.Now.AddHours(userans));
            Console.ReadLine();
        }
    }
}
