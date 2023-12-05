using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tum_14
{
    internal class BankAccount_2       
    {
        public enum AccountType
        {
            Current,
            Savings
        }

        private int accountNumber;
        private decimal balance;
        private AccountType type;
        private Queue<BankTransaktion> storeTransaktions = new Queue<BankTransaktion>();
        private string holder;

        public int AccountNumber { get { return accountNumber; } }
        public decimal Balance { get { return balance; } }
        public AccountType Type { get { return type; } }
        public Queue<BankTransaktion> StoreTransaktions { get { return storeTransaktions; } }
        public string Holder
        {
            get { return holder; }
            set { holder = value; }
        }
        public BankTransaktion this[int index] // Индексатор
        {
            get
            {
                if (index > 0 && index < storeTransaktions.Count)
                {
                    return storeTransaktions.ToArray().ToList()[index]; ;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                };
            }
        }
        public BankAccount_2(decimal balance, AccountType type)
        {
            GenerationNomberAccount();
            this.balance = balance;
            this.type = type;
        }
        public BankAccount_2(decimal balance)
        {
            GenerationNomberAccount();
            this.balance = balance;
        }
        public BankAccount_2(AccountType type)
        {
            GenerationNomberAccount();
            this.type = type;
        }
        public Queue<BankTransaktion> StoreTransaktion
        {
            get
            {
                return storeTransaktions;
            }
        }
        
        public void DumpToScreen() // К 14.1
        {
            Console.WriteLine($"Тип - {type}, номер - {accountNumber}, баланс - {balance}, владелец {holder}");
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            storeTransaktions.Enqueue(new BankTransaktion(amount));
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                storeTransaktions.Enqueue(new BankTransaktion(amount));
            }
            else
            {
                Console.WriteLine($"Вы не можете столько снять, у вас на счету {balance}");
            }
        }

        public void Transfer(decimal amount, BankAccount_2 destantionAccount)
        {
            if (balance >= amount)
            {
                Withdraw(amount);
                destantionAccount.Deposit(amount);
                storeTransaktions.Enqueue(new BankTransaktion(amount));
            }
            else
            {
                Console.WriteLine($"Вы не можете столько перевести, у вас на счету {balance}");
            }
        }
        public void Dispose()
        {
            Queue<BankTransaktion> transaktion = StoreTransaktion;
            string filePath = "ТумаковБанк.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                for (int i = 0; i < transaktion.Count; i++)
                {
                    BankTransaktion transactionBank = transaktion.Dequeue();
                    writer.WriteLine($"Пополнение/Снятие/Перевод {transactionBank.TransaktionDate}, {transactionBank.TransaktionAmount} рублей");
                }
            }
            GC.SuppressFinalize(this);
        }
        public void GenerationNomberAccount()
        {
            accountNumber++;
        }

        public void GetAccountInfo()
        {
            Console.WriteLine($"Тип - {type}, номер - {accountNumber}, баланс - {balance}");
        }
    }
}
