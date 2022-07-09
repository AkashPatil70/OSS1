gusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library;
using HumanResource;

namespace TestApp
{
    internal class Program
    {
        static bool practice()
        {
            bool status = false;
            return status;
            
        }
        static void Main(string[] args)
        {
            //Person person = new Person();
            Person thePerson = new Person("Manisha", "Kamat", "981734684", "manisha.kamat@gmail.com", 24);

            Person thePerson2 = new Person();
            thePerson2.FirstName = "Sachin";
            thePerson2.LastName = "";
            thePerson2.Email = "sachin.tendulkar@gmail.com";
            thePerson2.Age = 50;
            thePerson2.ContactNumber = "988457845";


            //Property Initializer Syntax
            Person thePerson3 = new Person
            {
                FirstName = "Raj",
                LastName = "Malhotra",
                Age = 30,
                Email = "raj.malhotra@gmail.com",
                ContactNumber = "988345754"
            };


            //Property Initializer Syntax
            Person thePerson4 = new Person
            {
                FirstName = "Avanti",
                LastName = "Kamble",
                Age = 24,
                Email = "avanti.kamble@gmail.com",
                ContactNumber = "988345754"
            };


            Point startPoint = new Point(56, 76);
            Point endPoint = new Point(100, 34);

            DateTime joinDate1 = new DateTime(2007, 4, 23, 9, 23, 34);
            Employee emp = new SalesEmployee(23, "Sameer Patil", joinDate1, "Marketing", 23, "Mumbai", 2000, 500000, 560000, 250000);
            DateTime joinDate2 = new DateTime(2014, 4, 12, 9, 16, 54);
            Employee developer = new SoftwareDeveloper(45, "Sarika Jadhav", joinDate2, "Marketing", 23, "Delhi", "Animation for Hollywood", 30000, 0.8);

            double devSalary = developer.ComputePay();
            double salesSalary = emp.ComputePay();

            Console.WriteLine("Demo Inheritance......");
            Console.WriteLine(emp);
            Console.WriteLine(developer);

            Console.WriteLine("Developer Salary = {0}", devSalary);
            Console.WriteLine("Sales Employees Salary = {0}", salesSalary);

            Console.ReadLine();
            
            //Added by 08 
            console.writeline("hello world");

        }
    }
}
