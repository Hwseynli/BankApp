using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.Models;

namespace BankApp.IHelpers.ICustomPowers
{
    public interface IWithdrawal
    {
        public static void Withdrawal()
        {
        depo:
            Console.Write($"{Context.BanK.Name} {Enm.Bankına_aid_Kart_nömrənizi_daxil_edin}: ");
            string cartnum = Console.ReadLine();
            if (Context.BanK.Customers.Exists(n => n.BankAccount.CartNumber == cartnum))
            {
                Customer customer = Context.BanK.Customers.Find(n => n.BankAccount.CartNumber == cartnum);
                depos:
                Console.Write($"{Enm.Kartdakı_ümumi_məbləq}: {customer.Amount} {Enm.AZN} \n{Enm.Məxaric_etmək_istədiyiniz_məbləği_qeyd_edin}: ");
                decimal amount = decimal.Parse(Console.ReadLine());
                if (amount > 0 && amount <= customer.Amount)
                {
                    customer.BankAccount.Amount -= amount;
                    Console.WriteLine($"{Enm.Məxaric_edildi}...\n{Enm.Kartdakı_ümumi_məbləq}: {customer.Amount} {Enm.AZN} ");
                }
                else
                {
                    Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}!!!");
                    goto depos;
                }
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Belə_bir_kart_mövcud_deyil}!!!");
            }
        }
    }
}


