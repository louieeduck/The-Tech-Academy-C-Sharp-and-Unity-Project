using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethod
{
    public class Number
    {

        public int Addition(int UserX)
        {
            return UserX + 5;
           
        }

        public int Mult(int UserX)
        {
            Console.WriteLine("What number do you want the math operations on.");
            return UserX * 5;
        }

        public int Div(int UserX)
        {
            Console.WriteLine("What number do you want the math operations on.");
            return UserX / 5;
        }

        private int mult;

        public int GetMult()
        {
            return mult;
        }

        public void SetMult(int value)
        {
            mult = value;
        }

        private int div;

        public int GetDiv()
        {
            return div;
        }

        public void SetDiv(int value)
        {
            div = value;
        }

        public int Add { get; set; }

        
    }
}
