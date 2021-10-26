using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            Program mine = new Program();
            Main alt = new Main();

            Console.WriteLine("Input number for UserX");

            int UserX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you want to input a second number?");
            string Answer = Console.ReadLine();
            bool AnswerBool = Convert.ToBoolean(Answer);
            if (AnswerBool == true)
            {
                Console.WriteLine("Input number for Optional");
                int opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(alt.Para(UserX, opt));
            }

            else
            {
                Console.WriteLine(alt.Para(UserX));
            }



            Console.ReadLine();

        }
    }
}
