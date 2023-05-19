using BankApp.Dall;
using BankApp.Enums;
using BankApp.IHelpers;
using BankApp.IHelpers.ICustomPowers;
using BankApp.Interfaces;
using BankApp.Models;
using Microsoft.Win32;

namespace BankApp;
class Program
{
    static void Main(string[] args)
    {
        string input = "0";
        do
        {
            Console.WriteLine($"{Context.BanK.Name} {Enm.Bankının_menusuna_xoş_gəlmisiniz}...\nMenu");
            Console.Write("0.Exit\n1.Login\n2.Registr" +
                $"\n{InfoEnm.Seçim_edin}: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    break;
                case "1":
                    ILogin.Login();
                    break;
                case "2":
                    İRegistr.Registr();
                    break;
                default:
                    Console.WriteLine($"{WrongEnm.Belə_bir_seçim_yoxdur}...");
                    break;
            }
        } while (input != "0");

        foreach (var item in Context.BanK.Users)
        {
            Console.WriteLine(item.UserName);
        }
    }
}

