using System;
using BankApp.Models;
using BankApp.Models.Banks;

namespace BankApp.Dall
{
	public static class Context
	{
        public static Admin admin = new Admin("Admin", "Admin", "ad1000@gmail.com","Ad100078");
        public static Bank BanK = new Bank("ABB", 1000000, 2000, admin);
    }
}

