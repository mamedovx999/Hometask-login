using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Hometask_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account("Admin", "AdminEA18yr@");
            //Console.WriteLine("Login daxil edin");
            //string enteredUsername=Console.ReadLine();
            //Console.WriteLine("Sifre daxil edin");
            //string enteredPassword=Console.ReadLine();

            //account.Login(enteredUsername, enteredPassword);
            //Console.ReadLine();
            Console.WriteLine("Back end register form");
            Apply apply = new Apply();
            Console.WriteLine("Please enter name");
            string Name = Console.ReadLine();
            Console.WriteLine("Please Enter surname");
            string Surname = Console.ReadLine();
            Console.WriteLine("Please enter Phone number or email adress");
            string Email = Console.ReadLine();
            Console.WriteLine("Please create new password");
            string Password = Console.ReadLine();
            Console.WriteLine("Please enter Britdhay date dd/MM/yyyy ");
            string Brithday = Console.ReadLine();
            Console.WriteLine("Please Chose Gender");
            string Gender = Console.ReadLine();
            Console.WriteLine("Registration Completed");



        }
    }  
}
