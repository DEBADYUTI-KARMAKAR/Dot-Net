using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_One
{
    /*
     5. Define a class called “Employee” with the 
    following fields: EmployeeId, Employee Name, Address, City, Department, 
    Salary define an array of objects to hold 10 records of Employee. 
    Accept the details of 10 employees from the user using a loop. 
    Display the Employee Name and Salary of all the employees


     */
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Employee[] employee = new Employee[2];
              
          
            for(int i = 0; i < employee.Length; i++)
            {
                employee[i] = new Employee();
                Console.WriteLine();
                Console.WriteLine("\nEnter"+ (i+1) +" Employee Details");
                Console.WriteLine("Id");
                int employeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name");
                string name = Console.ReadLine();
                Console.WriteLine("Address");
                string address = Console.ReadLine();
                Console.WriteLine("City");
                string city = Console.ReadLine();
                Console.WriteLine("Department");
                string department = Console.ReadLine();
                Console.WriteLine("Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                employee[i].SetInfo(employeeId , 
                    name,
                    address,
                    city,
                    department,
                    salary);
               

            }
            for(int i = 0; i < employee.Length; i++)
            {
               
                employee[i].PrintInfo();
            }
           // employee[1].SetInfo(7, "Sourav", "WB", "Chandernagar", "Marketing", 32000);

           // employee[1].PrintInfo();


        }
    }

    class Employee
    {
        private int employeeId;
        private string name;
        private string address;
        private string city;
        private string department;
        private int salary;

        public void SetInfo(int employeeId,string name,string address,string city,string department,int salary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.address = address;
            this.city = city;
            this.department = department;
            this.salary = salary;


        }
        public void PrintInfo()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id:" + employeeId);
            Console.WriteLine("Name:"+ name);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("City:" + city);
            Console.WriteLine("Department:"+ department);
            Console.WriteLine("Salary:"+salary);

        }


    }
}
