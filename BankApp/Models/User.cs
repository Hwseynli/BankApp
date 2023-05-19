using System;
using BankApp.Enums;
using BankApp.IHelpers;
using BankApp.Interfaces;

namespace BankApp.Models
{
	public class User
	{
        static int _id = 1;
        public int Id { get; set; } = 0;
        public string Name { get; set; } = " ";
        public string SurName { get; set; } = " ";
        public string UserName { get; init; } = " ";
        public string Email { get; init; } = " ";
        public string PassWord { get; } = " ";
        public bool IsAdmin { get; set; }
        public User(string name, string surname, string email, string password, bool isadmin = false)
        {
            IsAdmin = isadmin;
            if (IsAdmin)
            {
                Id = 1;
            }
            else
            {
                _id++;
                Id = _id;
            }
            if (IEmailRegex.IsEmail(email))
            {
                Email = email;
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_email_daxil_edin}!");
            }
            if (IIsCapitalize.IsCapitalize(name))
            {
                Name = ICapitalize.Capitalize(name);
                UserName = $"{ICapitalize.Capitalize(name).ToLower()}_{Id}";
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_ad_daxil_edin}!");
            }
            if (IIsCapitalize.IsCapitalize(surname))
            {
                SurName = ICapitalize.Capitalize(surname);
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_soyad_daxil_edin}!");
            }
            if (ICheckPassword.CheckPassword(password))
            {
                PassWord = password;
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_şifrə_daxil_edin}!");
            }
            
        }
    }
}

