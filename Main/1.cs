using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnitTestApp
{

    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }


	public class HRManager
	{
		public static string  path =@"D:\try\employees.dat";
		public static List<Employee> GetAll()
		{ 
			List<Employee> employees = new List<Employee>();
			employees = LoadData(path);
			return employees;
		}
		public static bool Insert(Employee emp)
		{
			bool status = false;
			try
			{
			 
				List<Employee> employees = new List<Employee>();
				employees = LoadData(path);
				employees.Add(emp);
				SaveData(path, employees);
				status = true;
			}
			catch (Exception ex)
			{
				string exeMessage = ex.Message;

			}
			return status;
		}
		public static bool Update(Employee empToUpdate)
		{
			bool status = false;
			 
			List<Employee> employees = new List<Employee>();
			employees = LoadData(path);
			var employee = from e in employees
						   where e.ID == empToUpdate.ID
						   select e;
			Employee theEmp = employee as Employee;
			theEmp.FirstName = empToUpdate.FirstName;
			theEmp.LastName = empToUpdate.LastName;
			theEmp.Email = empToUpdate.Email;
			theEmp.ContactNumber = empToUpdate.ContactNumber;
			theEmp.Location = empToUpdate.Location;
			status = SaveData(path, employees); ;
			return status;
		}
		public static bool Delete(int id)
		{
			bool status = false;
			 
			List<Employee> employees = new List<Employee>();
			employees = LoadData(path);
			var employee = from e in employees
						   where e.ID == id
						   select e;
			status = employees.Remove(employee as Employee);
			return status;
		}
		public static Employee GetByID(int id)
		{
			 
			List<Employee> employees = new List<Employee>();
			employees = LoadData(path);
			var employee = from e in employees
						   where e.ID == id
						   select e;
			return employee as Employee;
		}
		public static List<Employee> LoadData(string path)
		{
			List<Employee> employees = new List<Employee>();
			FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			BinaryFormatter bf = new BinaryFormatter();
			employees = bf.Deserialize(fs) as List<Employee>;
			fs.Close();
			return employees;

		}
		public static bool SaveData(string path, List<Employee> employees)
		{
			bool status = false;
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
			BinaryFormatter bf = new BinaryFormatter();
			bf.Serialize(fs, employees);
			fs.Close();
			return status;
		}
	}

	internal class Program
    {
		static void Main(string[] args)
		{
			List<Employee> employees = new List<Employee>();
			employees.Add(new Employee { ID = 23, FirstName = "Shiv", LastName = "Kumar", Department = "IT", Location = "Pune", ContactNumber = "9881734687", Email = "shiv.kumar@gmail.com" });
			employees.Add(new Employee { ID = 13, FirstName = "Siya", LastName = "Varma", Department = "IT", Location = "Pune", ContactNumber = "9881734765", Email = "siya.varama@gmail.com" });
			employees.Add(new Employee { ID = 63, FirstName = "Riya", LastName = "Sharma", Department = "IT", Location = "Pune", ContactNumber = "9881734687", Email = "riya.sharma@gmail.com" });

			string path = @"D:\try\employees.dat";
			bool status = HRManager.SaveData(path, employees);
			Console.WriteLine("Data Saved =" + status);

			List<Employee> employeesFromFile = HRManager.LoadData(path);

			Employee newEmp= new Employee { ID = 63, FirstName = "Pratima", LastName = "Khandeshe", Department = "IT", Location = "Pune", ContactNumber = "9881734667", Email = "pratima@gmail.com" };
			HRManager.Insert(newEmp);

			 employeesFromFile = HRManager.LoadData(path);


			foreach ( Employee emp in employeesFromFile )
            {
				Console.WriteLine( emp.FirstName +  " " + emp.LastName );


            }
			Console.ReadLine();

		}
	}
}
