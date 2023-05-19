using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.IHelpers;
using BankApp.IHelpers.ICustomPowers;
using BankApp.Models;

namespace BankApp.Interfaces
{
    public interface ICustomerPower
    {
        public static void CustomerPower()
        {
            byte input;
            do
            {
                Console.WriteLine($"{InfoEnm.Sizin_səlahiyyətləriniz}: ");
                Console.WriteLine("0. Exit \n1. Kredit götürün" +
                    "\n2. Kredit ödənişi edin \n3. Hesaba pul əlavə edin " +
                    "\n4. Hesabdan pul çıxarın \n5. Kredit borcunuz haqda məlumata baxın \n6. Hesabınız haqda məlumata baxın");
                Console.Write($"{InfoEnm.Seçim_edin}: ");
                input = byte.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                            if (Context.BanK.Customers.Find(n => n.Id == ICheckLogin.ID).IsCreditDept)
                            {
                                Console.WriteLine($"Sizin zatən kredit borcunuz var." +
                                    $"\n  Info :" +
                           $"\n{Enm.Hazırkı_ümumi_kredit_borcunuz}: {İRegistr.customer.BankAccount.CreditDept} {Enm.AZN}" +
                           $"\n{Enm.Kreditin_müddəti}: {İRegistr.customer.BankAccount.CreditPeriod}");
                            }
                            else
                            {
                                ITakeCredit.TakeCredit();
                            }
                        break;

                    case 2:
                        if (Context.BanK.Customers.Find(n => n.Id == ICheckLogin.ID).IsCreditDept)
                        {
                            IPayOffCredit.PayOffCredit();
                        }
                        else
                        {
                            Console.WriteLine($"{Enm.Sizin_kredit_borcunuz_yoxdur}...");
                        }
                        break;

                    case 3:
                        IDeposit.Deposit();
                        break;

                    case 4:
                        IWithdrawal.Withdrawal();
                        break;

                    case 5:
                        IGetCreditInfo.GetCreditInfo(Context.BanK.Customers.Find(n => n.Id == ICheckLogin.ID));
                        break;

                    case 6:
                        IGetCustomerİnfo.Getİnfo();
                        break;
                    default:
                        Console.WriteLine($"{WrongEnm.Belə_bir_seçim_yoxdur}...");
                        break;
                }
            } while (input != 0);
        }
    }

}


