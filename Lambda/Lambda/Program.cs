using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employ = new Employee();



            employ.Employees.Add("Evan");
            Console.WriteLine(employ.Employees);







            //List<string> newList = new List<string>();
            //var myList = new List<ValueTuple<string, string, int>>();
            //myList.Add(new ValueTuple<string, string, int>("Evan"," Fretheim",     1));
            //myList.Add(new ValueTuple<string, string, int>( "Lexi"," Triebold",    23));
            //myList.Add(new ValueTuple<string, string, int>( "Joe"," John",         123));
            //myList.Add(new ValueTuple<string, string, int>( "Max"," Kupitz",       165));
            //myList.Add(new ValueTuple<string, string, int>( "Lori"," Peterson",    12));
            //myList.Add(new ValueTuple<string, string, int>( "Kallie"," Patterson", 5));
            //myList.Add(new ValueTuple<string, string, int>( "Jen"," Larson",       10));
            //myList.Add(new ValueTuple<string, string, int>( "Joe"," Joel",         3));
            //myList.Add(new ValueTuple<string, string, int>( "Edward"," Richards",  4));
            //myList.Add(new ValueTuple<string, string, int>( "Ethan"," Timmothy",   5));



            //foreach (var i in myList)
            //    {
            //    if (FirstName == "Joe")
            //        newList.Add("Joe");
            //}

            //List<string> LambdaList = myList.Select(x => x.FirstName == "Joe");




            Console.ReadLine();
        }
    }
}
     