//using is a keyword for importing namespaces

//C, C++, C#

//C# language:
//      power of C
//      simplicity of Java
//      elegance of VB
//      Smartness of C++

//namespace: logical collection of .NET Types

//          Primitive Types
//                      int, float, double, char, boolean,
//                      enum

//          UserDefined Types
//                       stucture
//                       class
//                       interface
//                       delegate
//                       events


//Inbuilt namespaces have been imported 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programming Language: C# ( C Sharp)

namespace HelloWorldApp
{
    // Access Specifiers:
    // public, private, protected, internal

    internal class Program
    {
        // static:  Shared function
        // entry point function for .net application
        static void Main(string[] args)
        {
            int count = 56;
            count = count + 1;
            Console.WriteLine(count);
            Console.WriteLine("Hello .NET , Welcome to .NET World...");
           
            Point point = new Point();
            point.X = 34;
            point.Y = 67;
            Console.WriteLine(point);


            var fullName = "Ravi Tambade";
            Console.WriteLine(fullName);

            DateTime birthDate1 = new DateTime(1975, 08, 18);
            Person thePerson1 = new Person("Ravi", "Tambade", birthDate1, "9881735801", "ravi.tambade@transflower.in");
            Console.WriteLine(thePerson1);
            
            DateTime birthDate2 = new DateTime(1999, 06, 21);
            Person thePerson2 = new Person("Ranjana", "Sharma", birthDate2, "9881735765", "ranjana.sharma@transflower.in");
            Console.WriteLine(thePerson2);

            int instanceCount = Person.GetCount();
            Console.WriteLine("Person instance count={0}", instanceCount);
            Console.ReadLine();
        }
    }
}
