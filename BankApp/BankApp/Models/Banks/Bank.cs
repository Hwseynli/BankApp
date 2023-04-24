using System;
using BankApp.Dall;

namespace BankApp.Models.Banks
{
    public class Bank
	{
        public List<Customer> Customers;
        public Admin AdMin;
        public List<User> Users;
        public string Name { get; set; }
        public decimal TotalMoney { get; set; }
        public long CountCustomer { get; set; }
        public int CountWorker { get; set; }
        public Bank(string name, decimal totalMoney, int countWorker, Admin admin) 
        {
            Customers=new List<Customer>();
            Users = new List<User>();
            AdMin = admin;
            Users.Add(AdMin);
            Name = name;
            TotalMoney = totalMoney;
            CountCustomer = Customers.Count();
            CountWorker = countWorker;
        }
    }
}

