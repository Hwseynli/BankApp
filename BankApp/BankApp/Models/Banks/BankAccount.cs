using System;
using BankApp.Dall;

namespace BankApp.Models.Banks
{
	public class BankAccount
	{
        public string CartNumber { get; set; }
        public decimal Amount { get; set; }
        public bool IsCreditDept { get; set; }
        public double CreditDept { get; set; }
        public double MonthlyPayment { get; set; }
        public byte CreditPeriod { get; set; }
        public BankAccount(decimal amount, bool iscreditDept,
            double creditdept = 0, byte creditperiod = 0, double monthlypayment=0)
        {
            Random random = new Random();
            Amount = amount;
            IsCreditDept = iscreditDept;
            CreditDept = creditdept;
            CreditPeriod = creditperiod;
            if (IsCreditDept)
            {
                MonthlyPayment = monthlypayment;
            }
            else
            {
                MonthlyPayment = 0;
            }
            CartNumber = $"{random.Next(100000, 10000000)}"; ;
        }
    }
}

