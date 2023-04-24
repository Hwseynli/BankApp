using System;
using BankApp.Dall;
using BankApp.Enums;
using static BankApp.Interfaces.IAdminPower;

namespace BankApp.IHelpers
{
	public interface ICheckLogin
	{
        public static int ID;
        static bool retun=false;
        public static void CheckLogin(bool isadmin)
        {
            string input = "0";
            string username = " ";
            string email = " ";
            LoginCheck:
                Console.Write($"{InfoEnm.Seçimləriniz}:\n0. Exit" +
                    "\n1. UserName\n2. Email" +
                    $"\n{InfoEnm.Seçim_edin}: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        break;
                    case "1":
                        Console.Write($"{WrongEnm.Düzgün_username_daxil_edin}: ");
                        username = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write($"{WrongEnm.Düzgün_email_daxil_edin}: ");
                        email = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine($"{WrongEnm.Belə_bir_seçim_yoxdur}!!!\n{WrongEnm.Yenidən_cəhd_edin}...");
                        goto LoginCheck;
                }
            
            Console.Write("Şifrə daxil edin: ");
            string password = Console.ReadLine();
            if (isadmin)
            {
                if ((Context.BanK.Users[0].Email == email || Context.BanK.Users[0].UserName == username) && Context.BanK.Users[0].PassWord == password)
                {
                    Console.WriteLine($"{InfoEnm.Xoş_gəlmisiniz}....");
                    retun= true;
                }
                else
                {
                    Console.WriteLine($"{WrongEnm.Siz_admin_deyilsiniz}!!!\n{WrongEnm.Yenidən_cəhd_edin}");
                    goto LoginCheck;
                }
            }
            else
            {
                if (Context.BanK.Customers.Exists(n => (n.UserName == username || n.Email == email) && n.PassWord == password))
                {
                    if (IAdminPower.period < DateTime.Now)
                    {
                        ID = Context.BanK.Customers.Find(n => (n.UserName == username || n.Email == email) && n.PassWord == password).Id;
                        Console.WriteLine($"{InfoEnm.Xoş_gəlmisiniz}...");
                        retun = true;
                    }
                    else
                    {
                        Console.WriteLine($"Siz block edildiniz. Blockun bitiş tarixi: {IAdminPower.period - DateTime.Now}");
                    }
                }
                else
                {
                    Console.WriteLine($"{WrongEnm.Siz_müştəri_deyilsiniz}!!!\nRegist olun ya da {WrongEnm.Yenidən_cəhd_edin};)");
                }
            }
        }
    }
}

