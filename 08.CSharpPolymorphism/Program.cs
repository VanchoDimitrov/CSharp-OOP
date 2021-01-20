using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPolymorphism
{
    class Person
    {
        public void Save()
        {
            Console.WriteLine("Person saved");
        }
    }

    class Employee : Person
    {
        public void Save()
        {
            Console.WriteLine("Employee saved");
        }
    }

    class Cashiers : Employee
    {
        public void Save()
        {
            Console.WriteLine("Cashier operations saved");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            Cashiers cashiers = new Cashiers();

            person.Save();
            employee.Save();
            cashiers.Save();

            Console.ReadKey();
        }
    }
}
