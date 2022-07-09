using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource
{

    // Concrete Class: instance can be created from a Class
    // Abstract Class: instance can not be created from a Class but allows to set polymorphism
    public class Employee
    {
        protected int Id { get; set; }
        protected string FullName { get; set; }
        protected DateTime JoinDate { get; set; }
        protected string Department { get; set; }
        protected int WorkingDays { get; set; }
        protected string Location { get; set; }
        protected double DA { get; set; }
        public Employee()
        {
            Id = 45;
            FullName = "Ravi Tambade";
            JoinDate = new DateTime(1997, 12, 23, 09, 10, 12);
            Department = "Reasearch & Development";
            WorkingDays = 25;
            Location = "Pune";
        }

        //You can do constructor chaining
        // public Employee(int id, string fullName, DateTime joinDate, 
        //string department,int workingDay, string location):this()
        public Employee(int id, string fullName, DateTime joinDate,
                        string department, int workingDay, string location)
        {
            Id = id;
            FullName = fullName;
            JoinDate = joinDate;
            Department = department;
            WorkingDays = workingDay;
            Location = location;
        }

        public override string ToString()
        {
            string result = string.Format("{0}  {1}  {2}   {3}  {4}  {5}",
                                        this.Id, this.FullName, this.JoinDate, this.WorkingDays, this.Department, this.Location);
            return result;
        }


        public static void main()
        {
            Employee emp = new Employee();
            Console.WriteLine(emp);
        }
    }
}