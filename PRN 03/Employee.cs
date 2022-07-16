using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Added by PRN 15
namespace UnitTest
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get;set;)
        //nvjsdb
    }

    public static void display()
    {
        console.writeLine("Hello");
        console.writeLine("Welcome1");
    }

    //Added by PRN13
    public static void Welcome()
    {
        console.writeLine("Welcome");
        console.writeLine("Users");
    }
}
