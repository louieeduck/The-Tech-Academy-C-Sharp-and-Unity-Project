using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {

        public int Id1;
        public int Id2;
        public static bool operator ==(Employee Id1, Employee Id2)
        {
            bool status = false;
            if (Id1.Id1 == Id2.Id2)
            {

                status = true;
            }
            return status;
        }
            public static bool operator !=(Employee Id1, Employee Id2)
        {
            bool status = false;

            if (Id1.Id1 != Id2.Id2)
            {

                status = true;
            }
            return status;
        }

    }
}
