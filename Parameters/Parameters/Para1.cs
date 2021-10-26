using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee<T>
    { 
        public List<T> Thing { get; set; }
        public List<T> ListString { get; set; }
        public List<T> IntList { get; set; }
        public void looplist(string firstName, string lastName)
        {
            for (int i = 0; i > Thing.Count; i++)
            {
                Console.WriteLine(Thing);
            }
        }
    }
}
