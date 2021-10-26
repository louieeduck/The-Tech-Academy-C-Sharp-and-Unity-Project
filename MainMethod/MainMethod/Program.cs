using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();  //instantiate
            Main mine = new Main();

            Console.WriteLine(mine.Addition());
            Console.WriteLine(mine.Decimal());
            Console.WriteLine(mine.StrInt());


            Console.ReadLine();
        }
    }
}
