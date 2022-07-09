using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class Employee
    {
        public int empId { get; set; }
        public string FirstNme { get; set; }
        public string LastNme { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        //Added by 13
        public double Depertment { get; set; }
    }
}
