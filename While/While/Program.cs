using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my favorite number.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool RightNumber = number == 15;

            do
            {
                switch (number)
                {
                    case 25:
                        Console.WriteLine("You guessed 25. Try again.");
                        Console.WriteLine("Guess my favorite number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 195259:
                        Console.WriteLine("You guessed 195259. Try again.");
                        Console.WriteLine("Guess my favorite number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 15:
                        Console.WriteLine("You did it! You guessed my favorite number");
                        RightNumber = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong, sorry :(");
                        Console.WriteLine("Guess my favorite number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!RightNumber);

            Console.ReadLine();
        }  
    }
}










//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace While
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Guess my favorite number.");
//            int number = Convert.ToInt32(Console.ReadLine());
//            bool RightNumber = number == 15;



//            while (!RightNumber)
//            {
//                switch (number)
//                {
//                    case 25:
//                        Console.WriteLine("You guessed 25. Try again.");
//                        Console.WriteLine("Guess my favorite number");
//                        number = Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 195259:
//                        Console.WriteLine("You guessed 195259. Try again.");
//                        Console.WriteLine("Guess my favorite number.");
//                        number = Convert.ToInt32(Console.ReadLine());
//                        break;
//                    case 15:
//                        Console.WriteLine("You did it! You guessed my favorite number");
//                        RightNumber = true;
//                        break;
//                    default:
//                        Console.WriteLine("You are wrong, sorry :(");
//                        Console.WriteLine("Guess my favorite number.");
//                        number = Convert.ToInt32(Console.ReadLine());
//                        break;
//                }
//            }

//            Console.ReadLine();
//        }
        
//    }
//}
