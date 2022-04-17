using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            

            do
            {
                Console.WriteLine("Enter username please");

                username = Console.ReadLine();


            } while (username.Length<6);

            do
            {
                Console.WriteLine("Enter password please");

                password = Console.ReadLine();

            } while (!User.CheckPassword(password));

            Console.WriteLine("Enter Sectio Please");

            string section = Console.ReadLine();

            

            Console.WriteLine("IsSuperadmin : y/n");

            bool isSuperadmin = false;

            string Superadmin = Console.ReadLine();

            if (Superadmin.ToLower().Trim()=="y")
            {
                isSuperadmin = true;
            }

            
           

            Admin admin = new Admin(username,password,section,isSuperadmin);

            Console.WriteLine(admin.Showinfo());










        }
    }
}
