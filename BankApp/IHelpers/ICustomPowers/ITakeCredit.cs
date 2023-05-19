using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.Interfaces;
using BankApp.Models;

namespace BankApp.IHelpers.ICustomPowers
{
    public interface ITakeCredit
    {
        public static void TakeCredit()
        {
        Takecredit:
            Customer customer = Context.BanK.Customers.Find(n => n.Id == ICheckLogin.ID);
            double amountdue = 0;
            double monthlypayment = 0;
            byte month = 0;
            Console.Write($"{Enm.Kreditin_müddəti} : ");
            month = byte.Parse(Console.ReadLine());
            Console.Write($"{Enm.Məxaric_etmək_istədiyiniz_məbləği_qeyd_edin}:");
            double amount = double.Parse(Console.ReadLine());
            if (amount > 0 && month > 0)
            {
                if (month <= 12)
                {
                    amountdue = amount + (amount * 0.1);
                    monthlypayment = amountdue / month;
                }
                else
                {
                    amountdue = amount + (amount * 0.12);
                    monthlypayment = amountdue / month;
                }
                Console.WriteLine($"{Enm.Ödeyeceyiniz_ümumi_mebleq}: {amountdue} AZN\n{Enm.Aylıq_ödəniş_məbləği} : {monthlypayment} {Enm.AZN}");
                Console.WriteLine("Krediti götürmək istiyirsinizmi ? \n1.Bəli \n2.Xeyr");
                string choise = Console.ReadLine();
                if (choise == "1")
                {
                    Console.WriteLine("Emeliyyat ugurlu oldu !");
                    Console.WriteLine($"{Enm.Hazırkı_ümumi_kredit_borcunuz}:  {amountdue} {Enm.AZN}\n" +
                        $"{Enm.Aylıq_ödəniş_məbləği}: {monthlypayment} {Enm.AZN} " +
                        $"\n{Enm.Kreditin_müddəti}: {month} ay");
                    customer.IsCreditDept = true;
                    customer.BankAccount.CreditPeriod = month;
                    customer.BankAccount.CreditDept = amountdue;
                    customer.BankAccount.MonthlyPayment = monthlypayment;
                }
                else
                {
                    Console.WriteLine($"Emeliyyat uğursuz oldu !\n{WrongEnm.Yenidən_cəhd_edin}");
                    goto Takecredit;
                }
            }
            else
            {
                Console.WriteLine($"{WrongEnm.Düzgün_dəyər_daxil_edin}!");
                goto Takecredit;
            }
        }
    }
}


