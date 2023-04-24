using System;
using System.Text;

namespace BankApp.IHelpers
{
	public interface IIsCapitalize: ICapitalize
    {
        public static bool IsCapitalize(string name)
        {
            string text = ICapitalize.Capitalize(name);
            if (text.Length>2)
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

