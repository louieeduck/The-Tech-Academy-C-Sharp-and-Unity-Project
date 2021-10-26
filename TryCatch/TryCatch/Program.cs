using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What number would you like to divide each number in the list by");
                List<int> IntList = new List<int>() { 5, 12, 15, 2, 1, 0 };
                int UserNum = Convert.ToInt32(Console.ReadLine());

                foreach (var item in IntList)
                {
                    var result = item / UserNum;
                    Console.WriteLine(result);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            Console.ReadLine();
        }
    }
}
