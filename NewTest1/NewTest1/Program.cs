using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            Employee nub1 = new Employee("Evan", "Fretheim", 000001);
            Employee nub2 = new Employee("Lexi", "Triebold", 000002);
            Employee nub3 = new Employee("Griffin", "John", 000003);
            Employee nub4 = new Employee("Joe", "Swanson", 000004);
            Employee nub5 = new Employee("Steve", "Johnson", 000005);
            Employee nub6 = new Employee("Joe", "Peterson", 000006);
            Employee nub7 = new Employee("Pam", "Pallson", 000007);
            Employee nub8 = new Employee("Phil", "Docotr", 000008);
            Employee nub9 = new Employee("Janet", "Jackson", 000009);
            Employee nub10 = new Employee("Peter", "Peterson", 000010);

            List<Employee> EmployeeList = new List<Employee>() {nub1, nub2, nub3, nub4, nub5, nub6, nub7, nub7, nub8, nub9, nub10 };
            List<Employee> NewList = new List<Employee>() {  };

            foreach (Employee i in EmployeeList) 
            {
                if (i.firstName == "Joe")
                {
                    Console.WriteLine(i.firstName + " " + i.lastName);
                    Console.ReadLine();
                    NewList.Add(i);
                }
            }



            List<Employee> LamList = EmployeeList.Where(x => x.firstName == "Joe").ToList();
            foreach (var emp in LamList)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName + " " + emp.ID);
            }

            List<Employee> IdList = EmployeeList.Where(x => x.ID > 5).ToList();
            foreach (var emp in IdList)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName + " " + emp.ID);
            }



            //int count = EmployeeList.Count(x => x.firstName == "Joe");
            //Console.WriteLine(count);



            Console.ReadLine();
        }
    }
}
