using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    class Employee
    {
        string name,address;
        int age;
        public void GetData()
        {
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the address");
            address = Console.ReadLine();
        }

        public void DispData()
        {
            Console.WriteLine("Name is" + name);
            Console.WriteLine("Age is" + age);
            Console.WriteLine("Address is" + address);
        }
        
    
    }

    class Driver : Employee
    {
        int salary;
        string designation;

        public void GetEmployeeData()
        {
            Console.WriteLine("Enter salary");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Designation");
            designation = Console.ReadLine();
        }
        public void DisplayEmployeeData()
        {
            Console.WriteLine("Salary is" + salary);
            Console.WriteLine("Designation is" + designation);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Driver d1 = new Driver();
            d1.GetData();
            d1.GetEmployeeData();
            d1.DispData();
            d1.DisplayEmployeeData();
            Console.ReadKey();
        }
    }
}
