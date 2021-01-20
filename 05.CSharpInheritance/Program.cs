using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInheritance
{
    class Person
    {
        public int ID;
        public string Name;
        public string LastName;
    }

    class Employee : Person
    {
        public string TypeEmployee;

        public void PrintEmployees(int id, string name, string lastName,
         string typeEmployee)
        {
            this.ID = id;
            this.Name = name;
            this.LastName = lastName;
            this.TypeEmployee = typeEmployee;

            Console.WriteLine($"ID {ID} Name {Name} Last Name " +
                $"{LastName} Type of Employee {TypeEmployee}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.PrintEmployees(1, "John", "Doe", "CEO");

            Console.ReadKey();
        }
    }
}
