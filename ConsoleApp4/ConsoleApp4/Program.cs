using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount savingsAc = new SavingsAccount(012, 1000);
            int savingsReturn = savingsAc.CalculateInterest(2);
            Console.WriteLine($"Savings return : {savingsReturn}");

            BankAccount currentAc = new CurrentAccount(123, 1000);
            int currentReturn = currentAc.CalculateInterest(2);
            Console.WriteLine($"Current return : {currentReturn}");

        }
    }
}
