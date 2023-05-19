using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.IHelpers;
using BankApp.Models;

namespace BankApp.Interfaces
{
	public interface İRegistr
	{
		public static Customer customer;

        public static void Registr()
		{
			RegistrCheck:
			Console.WriteLine("Registr");
			Console.Write($"{WrongEnm.Düzgün_ad_daxil_edin}: ");
			string name = ICapitalize.Capitalize(Console.ReadLine());
            Console.Write($"{WrongEnm.Düzgün_soyad_daxil_edin}: ");
            string surname = ICapitalize.Capitalize(Console.ReadLine());
            Console.Write($"{WrongEnm.Düzgün_email_daxil_edin}: ");
            string email = Console.ReadLine();
            Console.Write("Yeni şifrə daxil edin: ");
            string password = Console.ReadLine();
			if (ICheckPassword.CheckPassword(password) && IEmailRegex.IsEmail(email))
			{
				if (!Context.BanK.Users.Exists(n => n.Name == name && n.SurName == surname && n.Email == email))
				{
					customer = new Customer(name, surname, email, password);
					Context.BanK.Customers.Add(customer);
                    Context.BanK.Users.Add(customer);
					Console.WriteLine($"Siz qeydiyayyatdan keçdiniz...\n{InfoEnm.UserName_iniz}: {Context.BanK.Users[Context.BanK.Users.Count - 1].UserName}\n{InfoEnm.Email_adresiniz}: {Context.BanK.Users[Context.BanK.Users.Count - 1].Email}  \n{InfoEnm.Kart_nömrəniz}: {customer.BankAccount.CartNumber}\n{WrongEnm.Zəhmət_olmasa_Login_edin}...");
				}
				else
				{
					Console.WriteLine($"Belə bir istifadəçi mövcuddur. \n{WrongEnm.Zəhmət_olmasa_Login_edin}...");
					goto RegistrCheck;
				}
			}
			else
			{
                Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}...");
                goto RegistrCheck;
            }
		}
	}
}

