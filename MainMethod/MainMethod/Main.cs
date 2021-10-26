using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Main
    {
        public int Addition()
        {
            Console.WriteLine("What number do you want the math operations on.");
            int UserX = Convert.ToInt32(Console.ReadLine());
            return UserX + 5;
        }

        public double Decimal()
        {
            Console.WriteLine("What number do you want the math operations on.");
            double UserX = Convert.ToDouble(Console.ReadLine());
            return UserX + 5.2789634567823;
        }

        public int StrInt()
        {
            Console.WriteLine("Converting string to integer");
            string UserX = Console.ReadLine();
            int x = Convert.ToInt32(UserX);
            return x;

        }

    }
}
