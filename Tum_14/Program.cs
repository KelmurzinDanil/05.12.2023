using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр. 14.1");
            BankAccount_2 bankAccount_2 = new BankAccount_2(1000000, BankAccount_2.AccountType.Savings);
            Console.WriteLine("Без символа условной компиляции:");
            bankAccount_2.DumpToScreen();
            Console.WriteLine("С символом условной компиляции:");
            ConditionalAttributeClass.CallAttribute(bankAccount_2);
            
            Console.WriteLine("Упр. 14.2");

            TypeInfo type = typeof(RationalNumbers).GetTypeInfo();
            object[] attributes = type.GetCustomAttributes(false);
            foreach (Attribute attr in attributes)
            {
                if (attr is DeveloperInfoAttribute att)
                {
                    Console.WriteLine($"Имя -{att.Name} , Дата - {att.Datetime}") ;
                }
            }

            Console.WriteLine("ДЗ. 14.1");

            TypeInfo type2 = typeof(Building).GetTypeInfo();
            object[] attributes2 = type2.GetCustomAttributes(false);
            foreach (Attribute attr in attributes2)
            {
                if (attr is DeveloperInfo2Attribute att)
                {
                    Console.WriteLine($"Имя -{att.Name} , Организация - {att.NameOrg}");
                }
            }

            Console.ReadKey();
        }
    }
}
