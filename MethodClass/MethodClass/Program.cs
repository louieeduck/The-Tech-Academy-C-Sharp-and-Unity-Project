using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Main mine = new Main();

            Console.WriteLine("choose for a");
            string alpha = Console.ReadLine();
            int a = Convert.ToInt32(alpha);
            Console.WriteLine("choose for b");
            string beta = Console.ReadLine();
            int b = Convert.ToInt32(beta);
            mine.MyMethod(a, b);

            Console.ReadLine();
        }
    }
}
