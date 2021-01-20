using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEncapsulation
{
    class Person
    {
        public int ID;
        public string Name;
        public string LastName;

        public void setID(int id) => ID = id;

        public int getID() => ID;


        // latest style syntax for properties
        //public int _id
        //{
        //    get { return ID; }
        //    set { ID = value; }
        //}

        public void setName(string name) => Name = name;

        public string getName() => Name;

        public void setLastName(string lastName) => LastName = lastName;

        public string getLastName() => LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.setID(1);
            person.setName("John");
            person.setLastName("Doe");

            Console.WriteLine($"ID {person.getID()} Name " +
                    $"{person.getName()} Last Name {person.getLastName()}");

            Console.ReadKey();
        }
    }
}
