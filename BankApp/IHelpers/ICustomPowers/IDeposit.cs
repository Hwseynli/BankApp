using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.Models;

namespace BankApp.IHelpers.ICustomPowers
{
	public interface IDeposit
	{
		public static void Deposit()
		{
			depo:
            Console.Write($"{Context.BanK.Name} {Enm.Bankına_aid_Kart_nömrənizi_daxil_edin}: ");
			string cartnum = Console.ReadLine();
			Customer customer = Context.BanK.Customers.Find(n => n.BankAccount.CartNumber == cartnum);

            if (Context.BanK.Customers.Exists(n => n.BankAccount.CartNumber == cartnum))
			{
				Console.Write($"{Enm.Əlavə_etmək_istədiyiniz_məbləği_qeyd_edin}: ");
				decimal amount = decimal.Parse(Console.ReadLine());
				if (amount>0)
				{
					customer.Amount += amount;
					Console.WriteLine($"{Enm.Depozit_edildi}...\n{Enm.Kartdakı_ümumi_məbləq}: {customer.Amount}");
				}
				else
				{
					Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}... ");
					goto depo;
				}
			}
			else
			{
				Console.WriteLine($"{WrongEnm.Belə_bir_kart_mövcud_deyil}!!!\n {WrongEnm.Yenidən_cəhd_edin}... ");
				goto depo;
            }
		}
	}
}

