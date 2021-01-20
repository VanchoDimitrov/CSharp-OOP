using System;

namespace BlankCSharp
{
    class Person
    {
        public int ID;
        public string Name;
        public string LastName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ID = 1;
            person.Name = "John";
            person.LastName = "Doe";

            Console.WriteLine($"ID {person.ID} Name " +
                $"{person.Name} Last Name {person.LastName}");

            Console.ReadKey();
        }
    }
}
