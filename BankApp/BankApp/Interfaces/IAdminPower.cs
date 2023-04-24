using System;
using BankApp.Dall;
using BankApp.Enums;
using BankApp.IHelpers;

namespace BankApp.Interfaces
{
	public interface IAdminPower
	{
        public interface IAdminPower : IAddMoney, ISpendMoney
        {
            public static DateTime period;
            public static void AdminPower()
            {
                string input = "0";
                do
                {
                    Console.WriteLine($"{InfoEnm.Sizin_səlahiyyətləriniz}: ");
                    Console.WriteLine("0. Exit\n1.Bankdaki total miqdara baxin.\n" +
                                    "2. Pull əlavə edin.\n3. Pul transferi edin.\n4. Müştərini bloklayin.");
                    Console.Write($"{InfoEnm.Seçim_edin}: ");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "0":
                            break;
                        case "1":
                            Console.Write($"Bankda olan ümumi məbləq: {Context.BanK.TotalMoney} {Enm.AZN}");
                            break;
                        case "2":
                            Console.Write($"{Enm.Əlavə_etmək_istədiyiniz_məbləği_qeyd_edin}: ");
                            decimal addAmount = decimal.Parse(Console.ReadLine());
                            AddMoney(addAmount);
                            break;
                        case "3":
                            Console.Write($"{Enm.Məxaric_etmək_istədiyiniz_məbləği_qeyd_edin}: ");
                            decimal spendAmount = decimal.Parse(Console.ReadLine());
                            SpendMoney(spendAmount);
                            break;
                        case "4":
                            Console.Write("Bloklamaq istediyiniz müştərinin username ni daxil edin: ");
                            string username = Console.ReadLine();
                            if (Context.BanK.Users.Exists(n => n.UserName == username))
                            {
                                Console.Write("Blokda qalma muddetini gun ile qeyd qeyd edin: ");
                                period = DateTime.Now.AddDays(int.Parse(Console.ReadLine()));
                                Console.WriteLine("Bloklandi...");
                            }
                            else
                            {
                                Console.WriteLine("Belə bir müştəri mövcud deyil.");
                            }
                            break;
                        default:
                            Console.WriteLine($"{WrongEnm.Belə_bir_seçim_yoxdur}");
                            break;
                    }
                } while (input != "0");
            }
        }
    }
}

