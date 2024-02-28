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
        public string Newpassword;
        public DateTime Brithday;
        public string Gender;
        public Apply()
        {
            
        }
        public Apply(string name, string surname, string phonenumber, string email, string newpassword, DateTime brithday, string gender)
        {
            Name = name;
            Surname = surname;
            Phonenumber = phonenumber;
            Email = email;
            Newpassword = newpassword;
            Brithday = brithday;
            Gender = gender;
        }
    }
}