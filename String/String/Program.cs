using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main()
        {
            string name = "Evan ";
            string part2 = "Is 20 years ";
            string part3 = "Since August 9th.";
            string upper = "This sentence is in uppercase";

            string full = (name + part2 + part3);
            Console.WriteLine(full);

            Console.WriteLine(upper.ToUpper());

            StringBuilder sb = new StringBuilder();

            sb.Append("Greetings ");
            sb.Append("my name is Evan Fretheim ");
            sb.Append("and I enjoy coding ");

            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}
