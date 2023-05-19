using System;
using BankApp.Dall;
using BankApp.Enums;

namespace BankApp.IHelpers
{
	public interface IAddMoney
	{
        public static void AddMoney(decimal amount)
        {
            if (amount > 0)
            {
                Context.BanK.TotalMoney += amount;
                Console.WriteLine($"{Enm.Depozit_edildi}...\n{Enm.Kartdakı_ümumi_məbləq}: {Context.BanK.TotalMoney}");
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}!!!");
            }

        }
    }
}

