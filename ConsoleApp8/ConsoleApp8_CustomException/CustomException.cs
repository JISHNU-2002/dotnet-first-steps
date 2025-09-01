using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_CustomException
{
    internal class InsufficientFundException : Exception
    {
        private readonly int balance;
        private readonly int requestedAmount;

        public InsufficientFundException(int balance, int requestedAmount) :
            base($"Insufficient Fund {balance} : Requested Amount {requestedAmount}", null)
        {
            this.balance = balance;
            this.requestedAmount = requestedAmount;
        }
    }

    public class BankAccount
    {
        private readonly int initialAmount;

        public BankAccount(int initialAmount)
        {
            this.initialAmount = initialAmount;
        }

        public void withdraw(int amount)
        {
            try
            {
                if(amount > initialAmount)
                {
                    throw new InsufficientFundException(initialAmount, amount);
                }
                else
                {
                    Console.WriteLine($"Balance after withdraw: {initialAmount - amount}");
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}
