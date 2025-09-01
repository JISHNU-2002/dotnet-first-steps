using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BankAccount
    {
        public long acNumber;
        public float initialAmount, amount, balance;       
        public BankAccount(long acNumber, float initialAmount)
        {
            this.acNumber = acNumber;
            balance = initialAmount;
        }

        public void Depoist()
        {
            Console.Write("Enter the deposit amount: ");
            amount = Convert.ToSingle(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"{amount}.Rs Deposited\n");
            GetBalance();
        }

        public void Withdraw()
        {
            Console.Write("Enter the withdraw amount: ");
            amount = Convert.ToSingle(Console.ReadLine());
            if (balance < amount)
            {
                Console.WriteLine($"Insufficient balance\n");
                return;
            } 
            balance -= amount;
            Console.WriteLine($"{amount}.Rs Withdrawed\n");
            GetBalance();
        }

        public void GetBalance()
        {
            Console.WriteLine($"Bank balance: {balance}\n");
        }
    }
}
