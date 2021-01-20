using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassMethods
{
    class Program
    {
        class Person
        {
            // access modifiers could be also private (no access outside the class), 
            // protected (access in inherited classes)
            public int ID;
            public string Name;
            public string LastName;

            // constructor
            public Person(string what, int age)
            {
                Console.WriteLine(what + " " + age);
            }

            public Person()
            {
                Console.WriteLine("Let the party begin!");
            }

            // we need to include public identifier
            // so that we can access it from the main method/function
            public void SaveInformation(int ID, string Name, string LastName)
            {
                this.ID = ID;
                this.Name = Name;
                this.LastName = LastName;

                Console.WriteLine($"ID {this.ID} Name " +
                    $"{this.Name} Last Name {this.LastName}");
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Age: ", 30);
            person.SaveInformation(1, "John", "Doe");

            Console.ReadKey();
        }
    }
}
