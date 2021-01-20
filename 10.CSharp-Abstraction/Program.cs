using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Abstraction
{
    abstract class Person
    {
        string Name;
        string LastName;

        public void Assign(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }

        public void PrintResult()
        {
            Console.WriteLine("Name and Last Name: {0} {1}",
                this.Name, this.LastName);
        }
    }

    class Employee : Person { }

    class Program
    {
        static void Main(string[] args)
        {
            // we can't initialise abstract class.
            // Hence, I created a new class Employee which inherits from the 
            //abstract class.
            Employee employee = new Employee();
            employee.Assign("John", "Doe");
            employee.PrintResult();

            Console.ReadKey();
        }
    }
}
