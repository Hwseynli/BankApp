using System;
namespace BankApp.IHelpers
{
	public interface ICheckPassword
	{
		 public static bool CheckPassword(string password)
        {
            if (password.Length >= 8)
            {
                int digit = 0;
                int letterLOw = 0;
                int letterUp = 0;
                foreach (var item in password)
                {
                    if (Char.IsLetter(item))
                    {
                        if (Char.IsLower(item))
                        {
                            letterLOw++;
                        }
                        else
                        {
                            letterUp++;
                        }
                    }
                    else if (Char.IsDigit(item))
                    {
                        digit++;
                    }
                }
                if (digit > 0 && letterUp > 0 && letterLOw > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

	}
}

