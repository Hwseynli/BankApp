using System;
using BankApp.Enums;
using BankApp.IHelpers;

namespace BankApp.Interfaces
{
	public interface ILogin: ICheckLogin, IAdminPower, ICustomerPower
    {
        public static void Login()
        {
            string input = "0";
            do
            {
                Console.Write("Login Page...\n" +
                    "0. Exit\n1. Admin\n2. Customer" +
                    $"\n{InfoEnm.Seçim_edin}: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        break;
                    case "1":
                        CheckLogin(true);
                        if (ICheckLogin.retun)
                        {
                            IAdminPower.AdminPower();
                        }
                        break;
                    case "2":
                        CheckLogin(false);
                        if (ICheckLogin.retun)
                        {
                            ICustomerPower.CustomerPower();
                        }
                        break;
                    default:
                        Console.WriteLine($"{WrongEnm.Belə_bir_seçim_yoxdur}!!!");
                        break;
                }
            } while (input != "0");
        }
    }
}

