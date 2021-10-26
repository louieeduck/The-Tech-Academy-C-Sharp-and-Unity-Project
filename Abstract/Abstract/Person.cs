using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Person            
    {
        public string firstName;
        public string lastName;

        public abstract void sayName(string firstName, string lastName);

    }
    class Employee<thing> : Person, IQuittable
    {
        public int Id1;
        public int Id2;
        public thing Data { get; set; }
        public List<thing> Thing { get; set; }
        public override void sayName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName);
        }

        public bool Quit(Employee employee )
        {
            Console.WriteLine("I Quit");
            if (Id1 == Id2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
