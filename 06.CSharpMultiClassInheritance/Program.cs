using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMultiClassInheritance
{
    class Person
    {
        public int ID;
        public string Name;

        public Person()
        {
            this.ID = 1;
            this.Name = "John";
        }
    }

    class Employee : Person
    {
        public void PrintPerson()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }

    class Cashiers : Employee
    {
        public Cashiers()
        {
            Name = "Changed to Doe!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cashiers cashiers = new Cashiers();
            cashiers.PrintPerson();

            Console.ReadKey();
        }
    }
}
