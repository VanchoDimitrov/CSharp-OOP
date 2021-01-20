using System;

namespace CSharpMultiInheritance
{
    class Person : IPerson
    {
        public int ID;
        public string Name;

        public Person()
        {
            this.ID = 1;
            this.Name = "John";
        }
    }

    class Employee : Person, IEmployee
    {
        public void PrintPerson()
        {
            Console.WriteLine(ID + " " + Name);
        }
    }

    class Cashiers : Employee, ICashiers
    {
        public Cashiers()
        {
            Name = "Changed to Doe!";
        }
    }

    // interfaces to the classes
    public interface IPerson { }

    public interface IEmployee
    {
        void PrintPerson();
    }

    public interface ICashiers : IEmployee
    {

    }

    class People : Employee, IPerson, ICashiers
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            ICashiers cashiers = new Cashiers();
            cashiers.PrintPerson();

            People people = new People();
            people.PrintPerson();

            Console.ReadKey();
        }
    }
}
