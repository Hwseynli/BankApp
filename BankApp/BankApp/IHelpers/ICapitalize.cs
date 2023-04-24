using System;
using System.Text;
using System.Xml.Linq;

namespace BankApp.IHelpers
{
	public interface ICapitalize
	{
		public static string Capitalize(string name)
		{
            name = name.Trim();
            string[] arr = name.Split(" ");
            StringBuilder newstr = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != " ")
                {
                    arr[i] = Char.ToUpper(arr[i][0]) + arr[i].Substring(1).ToLower() + "";
                    newstr.Append(arr[i]);
                }
            }
            if (arr.Length < 2)
            {
                name = newstr.ToString();
                return name;
            }
            else
            {
                return "";
            }
        }
	}
}

