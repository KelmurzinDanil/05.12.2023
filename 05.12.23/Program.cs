using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._12._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр. 13.1-2");
            BankAccount bankAccount = new BankAccount(0, BankAccount.AccountType.Savings);
            bankAccount.Holder = "Боб";
            bankAccount.Deposit(300);
            bankAccount.Withdraw(299);

            Console.WriteLine($"Пополнение - {bankAccount[0].TransaktionAmount}, {bankAccount[0].TransaktionDate}");
            Console.WriteLine($"Снятие - {bankAccount[1].TransaktionAmount}, {bankAccount[1].TransaktionDate}");

            Console.WriteLine("ДЗ 13.1-2");
            TenBuildingsHere build = new TenBuildingsHere();

            build.AddBuild(new Building(3, 5, 5, 6));
            build.AddBuild(new Building(2, 7, 5, 7));
            build.AddBuild(new Building(9, 5, 5, 6));
            build.AddBuild(new Building(3, 5, 5, 6));
            build.AddBuild(new Building(8, 9, 5, 2));
            build.AddBuild(new Building(3, 5, 7, 6));
            build.AddBuild(new Building(32, 51, 55, 66));
            build.AddBuild(new Building(9, 5, 5, 6));
            build.AddBuild(new Building(31, 5, 52, 6));
            build.AddBuild(new Building(11, 12, 52, 6));

            for (int i = 0; i < build.TenBuilds.Length; i++)
            {
                Console.WriteLine($"Высота - {build[i].High}, Этажи - {build[i].Level}, Кол-во квартир - {build[i].NumberOfApartament}, Подъезды - {build[i].Entrance}");
            }
            Console.ReadKey();


        }
    }
}
