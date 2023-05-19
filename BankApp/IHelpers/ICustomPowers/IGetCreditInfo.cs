using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.Models;

namespace BankApp.IHelpers.ICustomPowers
{
    public interface IGetCreditInfo
    {
        public static bool GetCreditInfo(Customer costomer)
        {
            Customer customer = costomer;
            customer = costomer;
            if (customer.IsCreditDept)
            {
                Console.WriteLine($"{Enm.Hazırkı_ümumi_kredit_borcunuz}: {customer.BankAccount.CreditDept} AZN\n{Enm.Kreditin_müddəti}: {customer.BankAccount.CreditPeriod} ay\n{Enm.Aylıq_ödəniş_məbləği}:{customer.BankAccount.MonthlyPayment} AZN");
                return true;
            }
            else
            {
                Console.WriteLine(Enm.Sizin_kredit_borcunuz_yoxdur);
                return false;
            }
        }
    }
}

