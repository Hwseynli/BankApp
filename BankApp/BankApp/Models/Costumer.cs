using System;
using BankApp.Interfaces;
using BankApp.Models.Banks;

namespace BankApp.Models
{
    public class Customer : User
    {
        static int _id;
        public int ID{ get; set; }
        public decimal Amount { get; set; }
        public BankAccount BankAccount;
        public bool IsCreditDept { get; set; }
        public Customer(string name, string surname, string email, string password, decimal amount = 0, bool iscreditDept = false) : base(name, surname,email, password)
        {
            _id++;
            ID = _id;
            if (amount>=0)
            {
                Amount = amount;
            }
            IsCreditDept = iscreditDept;
            BankAccount = new BankAccount(Amount,IsCreditDept);
        }
    }
}

