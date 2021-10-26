using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {


        string[] stringArray = { "Hello", "Greetings", "Hi", "Hey" };
        Console.WriteLine("Select an index in the array, from 0-3.");
        int indexsel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringArray[indexsel]);
        Console.ReadLine();

        Console.WriteLine("Select an index from the array");
        int[] numArray = { 5, 2, 124, 634, 1 };
        string num = Console.ReadLine();
        int numb = Convert.ToInt32(num);
        Console.WriteLine(numArray[numb]);
        Console.ReadLine();
        if (numb > 4)
        {
            Console.WriteLine("This index does not exist inside this array.");
        }




        //int[] numArray1 = new int[] { 55, 2, 100, 200, 500012 };

        //int[] numArray2 = { 5, 2, 10, 235423, 2423, 23423, 81934, 23423 };

        //numArray2[5] = 12;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();


        List<string> stringList = new List<string>();
        Console.WriteLine("Select an index in this array, 0-2.");
        stringList.Add("Hello");
        stringList.Add("Greetings");
        stringList.Add("How are you");
        string lis = Console.ReadLine();
        int StrList = Convert.ToInt32(lis);
        Console.WriteLine(stringList[StrList]);
        Console.ReadLine();


        //List<int> intList = new List<int>();

        //intList.Add(5);
        //intList.Add(12);
        //intList.Remove(12);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();
    }
        
}
