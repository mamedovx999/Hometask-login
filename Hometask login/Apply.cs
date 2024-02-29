using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_login
{
    internal class Apply
    {
        public string Name;
        public string Surname;
        public string Phonenumber;
        public string Email;
        public string password;
        public DateTime Brithday;
        public string Gender;
        public Apply()
        {

        }
        public Apply(string name, string surname, string phonenumber, string email, string password, DateTime brithday, string gender)
        {
            Name = name;
            Surname = surname;
            Phonenumber = phonenumber;
            Email = email;
            password = password;
            Brithday = brithday;
            Gender = gender;
        }
        public void Information()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname:{Surname}");
            Console.WriteLine($"PhoneNyumber or email:{Email}");
            Console.WriteLine($"Password:{password}");
            Console.WriteLine($"DateBRithday:{Brithday.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Gender:{Gender}");

        }
        




    }
}       