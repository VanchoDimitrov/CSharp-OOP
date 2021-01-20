using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CSharp_Handling_Exceptions
{
    class Users
    {
        public string UserName;
        public string Password;

        public Users()
        {
            UserName = "John";
            Password = "Doe";
        }
    }

    class Program
    {
        public void MainMenuForm()
        {
            Console.WriteLine("Welcome to the application");
        }

        static void Main(string[] args)
        {
            Users users = new Users();
            Program program = new Program();

            try
            {
                if (users.UserName == "1John" && users.Password == "Doe")
                {
                    program.MainMenuForm();
                }
                else
                {
                    // Intentional exception
                    throw new Exception("Error");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
