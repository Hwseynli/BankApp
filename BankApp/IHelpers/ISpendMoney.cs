using System;
using BankApp.Dall;
using BankApp.Enums;

namespace BankApp.IHelpers
{
	public interface ISpendMoney
	{
        public static void SpendMoney(decimal amount)
        {
            if (amount > 0)
            {
                if (amount < Context.BanK.TotalMoney)
                {
                    Context.BanK.TotalMoney -= amount;
                    Console.WriteLine($"Transfer edildi...\n{Enm.Kartdakı_ümumi_məbləq}: {Context.BanK.TotalMoney}");
                }
                else
                {
                    Console.WriteLine("Bankınız iflas edəcək!!!\nDaha diqqətli olun;)");
                }
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}!!!");
            }
        }
    }
}

