using System.Reflection.Metadata;

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

            Apply apply = new Apply("Memmedeli","Memmedov","+994554180716","16.memmedeli@mail.ru","salam123",new DateTime(2002,7,16),"Male");
           Console.WriteLine(apply.Gender);

        }
    }  
}
