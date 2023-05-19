using System;
using System.Text.RegularExpressions;

namespace BankApp.IHelpers
{
	public interface IEmailRegex
	{
		public static bool IsEmail(string email)
		{
			Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
			if (regex.IsMatch(email))
			{
                return true;
            }
			else
			{
				return false;
			}
		}
	}
}

