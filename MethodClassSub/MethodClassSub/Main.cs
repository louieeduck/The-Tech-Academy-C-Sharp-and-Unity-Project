using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSub
{
    public class MathClass
    {
        public void MyMethod(int a)
        {
            var alpha = a;
            var alphachange = a / 2;
            Console.WriteLine(alphachange);
        }

        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        public void MyMethod(int a, int b)
        {
            var alpha = a;
            var alphachange = a / 2;
            Console.WriteLine(alphachange);
            Console.WriteLine(b);
        }
    }

    public static class Sec
    {
        public static string F_name = "Evan";
        public static string L_name = "Fretheim";
    

    public static void Me()
    {
        Console.Write("My name is: \n");
    }
}
}
