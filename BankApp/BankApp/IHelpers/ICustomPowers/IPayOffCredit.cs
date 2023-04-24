using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.Models;

namespace BankApp.IHelpers.ICustomPowers
{
	public interface IPayOffCredit
	{
        public static void PayOffCredit()
        {
        PayCredit:
            Customer customer=Context.BanK.Customers.Find(n => n.Id == ICheckLogin.ID);
            
            if (IGetCreditInfo.GetCreditInfo(customer))
            {
                Console.Write($"{Enm.Ödəmək_istədiyiniz_məbləği_daxil_edin}: ");
                double amount = double.Parse(Console.ReadLine());
                if (amount > 0 && amount <= customer.BankAccount.CreditDept)
                {
                    customer.BankAccount.CreditPeriod -= Convert.ToByte(amount / customer.BankAccount.MonthlyPayment);
                    customer.BankAccount.CreditDept -= amount;
                    if (customer.BankAccount.CreditDept == 0)
                    {
                        customer.IsCreditDept = false;
                        Console.WriteLine($"Artıq {Enm.Sizin_kredit_borcunuz_yoxdur}...");
                    }
                    else
                    {
                        Console.WriteLine($"{Enm.Kredit_borcunuz_ödəndi}...\n{Enm.Hazırkı_ümumi_kredit_borcunuz}: {customer.BankAccount.CreditDept} {Enm.AZN}\n{Enm.Kreditin_müddəti}: {customer.BankAccount.CreditPeriod} ay");
                    }
                }
                else
                {
                    Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}!!!");
                }
            }
        }
    }
}

