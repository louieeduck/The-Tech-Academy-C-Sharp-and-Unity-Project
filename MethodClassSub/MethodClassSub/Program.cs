using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSub
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mine = new MathClass();
            Console.WriteLine("choose a");
            string alpha = Console.ReadLine();
            int a = Convert.ToInt32(alpha);
            mine.MyMethod(a);

            int b = 100;

            mine.getValue(out b);

            Console.WriteLine(b);

            Sec.Me();

            Console.WriteLine(Sec.F_name);
            Console.WriteLine(Sec.L_name);

            Console.ReadLine();
        }
    }
}
