﻿using System;
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
        //LAB 1
        //Aman 009
        //Akshay 008
        //comment 007
        public string FirstName { get; set; }
        public string LastName { get; set; }
<<<<<<< HEAD
        public string newprop { get; set; }
=======
        
>>>>>>> 19aeb1cc5a54859b13e6fb7c1d2778080782cf50

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
