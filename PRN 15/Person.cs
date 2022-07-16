using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12
{
    public class Person
    {
        //properties
        //Aaquib 001
        //Aman 009
        //

        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        public Person() //default/parameterless constructor
        {
            this.FirstName = "Pratima";
            this.LastName = "Badhekar";

        }
        public Person(string fname,string lname) //parameterized constructer
        {

            this.FirstName = fname;
            this.LastName = lname;
        }
        
        ~Person() //GC /Destructor
        {

        }
    }
}
