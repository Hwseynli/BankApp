using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.Models;

namespace BankApp.IHelpers.ICustomPowers
{
	public interface IGetCustomerİnfo:IGetCreditInfo
	{
		public static void Getİnfo()
		{
			Customer customer= Context.BanK.Customers.Find(n => n.Id == ICheckLogin.ID);
            Console.WriteLine($"{InfoEnm.Xoş_gəlmisiniz}....\n{InfoEnm.Hesabınız_haqqında_məlumatlar}:");
			Console.WriteLine($"{InfoEnm.Email_adresiniz}: {customer.Email}\n{InfoEnm.UserName_iniz}: {customer.UserName}\n{Enm.Kartdakı_ümumi_məbləq}: {customer.Amount}\n{InfoEnm.Kart_nömrəniz}: {customer.BankAccount.CartNumber}");
            GetCreditInfo(customer);
        }
	}
}

