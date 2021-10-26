using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Input your text into the array");
            //string[] stringarray = new string[] { "Young ", "Old ", "Small ", "Big " };
            //string UserString = Console.ReadLine();

            //for (int i = 0; i < stringarray.Length; i++)
            //{
            //    Console.WriteLine(stringarray[i] + UserString);
            //}
            //Console.ReadLine();

            //Console.WriteLine("Input text to search in the list.");
            //List<string> LString = new List<string>() { "Evan", "Lexi", "John", "Billy" };
            //string UserText = Console.ReadLine();
            //Console.WriteLine("The string " + UserText + " Has been found at index: ");
            //for (int i = 0; i < LString.Count; i++)
            //{
            //    if (LString[i].Contains(UserText))
            //    {
            //        Console.WriteLine(LString.FindIndex(a => a.Contains(UserText)));
            //    }
            //    else
            //    {
            //        Console.WriteLine("The string you are looking for is not in this list");
            //    }
            //}
            //Console.ReadLine();


            Console.WriteLine("Input text to search in the list.");
            List<string> NonU = new List<string>() { "Evan", "Lexi", "John", "John" };
            List<int> repeatCheck = new List<int>();
            string Users = Console.ReadLine();
            Console.WriteLine("The string " + Users + " Has been found at index: ");

            //foreach (string i in NonU)
            //{
            //    if (NonU.Contains(Users))
            //    {
            //        Console.WriteLine(NonU.FindIndex(a => a.Contains(Users)));
            //    }
            //}


            for (int i = 0; i < NonU.Count; i++)
            {
                NonU.FindIndex(a => a.Contains(Users));
                var x = NonU.FindIndex(a => a.Contains(Users));
                repeatCheck.Add(x);
                NonU.FindLastIndex(a => a.Contains(Users));
                var y = NonU.FindLastIndex(a => a.Contains(Users));
                repeatCheck.Add(y);

     
            }
            repeatCheck.ForEach(Console.WriteLine);

            //if (NonU.Contains(Users))
            //{
            //    NonU.FindIndex(a => a.Contains(Users));
            //    var x = NonU.FindIndex(a => a.Contains(Users));
            //    NonU.Skip(x);
            //    Console.WriteLine(x);
            //    repeatCheck.Add("x");
            //    NonU.ForEach(Console.WriteLine);
            //}
            //else
            //{
            //    Console.WriteLine("The string you are looking for is not in this list");
            //}

            //for (int i = 0; i < NonU.Count; i++)

            //var i = 0;
            //foreach (var value in NonU)
            //{
            //    if (value == Users)
            //        Console.WriteLine(NonU.FindIndex(a => a.Contains(Users)));


            //    i++;
            //}

            //for (int i = 0; i < NonU.Count; i++)
            //{
            //    if (NonU.Contains(Users))
            //    {
            //        Console.WriteLine(NonU.FindIndex(a => a.Contains(Users)));
            //        //NonU.Remove(Users);
            //        //Console.WriteLine(NonU.FindIndex(a => a.Contains(Users)) + 1);
            //        //NonU.Remove(Users);
            //    }
            //}






            Console.ReadLine();


            //Console.WriteLine("Input text to search in the list.");
            //List<string> Last = new List<string>() { "Ball", "Cat", "Dog", "Cat" };
            //string UserOwn = Console.ReadLine();
            //foreach (string name in Last)
            //{
            //    if (Last.Count != Last.Distinct().Count())
            //    {
            //        Console.WriteLine("In list more than once");
            //    }
            //    else
            //    {
            //        Console.WriteLine("In list only once");
            //    }
            //}





            //for (int i = 0; i < stringarray.Length; i++)
            //{

            //}
            //Console.WriteLine(stringarray[i]);



            Console.ReadLine();
        }
    }
}
