using System;
namespace BankApp.Models
{
    public class Admin : User
    {
        public Admin(string name, string surname, string email, string password) : base(name, surname, email, password, true)
        {

        }
    }
}

