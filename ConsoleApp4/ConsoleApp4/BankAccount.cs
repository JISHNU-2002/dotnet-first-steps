using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class BankAccount
    {
        private int acNumber, balance;
        public BankAccount(int acNumber, int balance)
        {
            this.acNumber = acNumber;
            this.balance = balance;
        }

        public abstract int CalculateInterest(int timePeriod);
    }
}
