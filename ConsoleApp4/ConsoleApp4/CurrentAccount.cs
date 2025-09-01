using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CurrentAccount : BankAccount
    {
        private int acNumber, balance;
        public CurrentAccount(int acNumber, int balance) : base(acNumber, balance)
        {
            this.acNumber = acNumber;
            this.balance = balance;
        }

        public override int CalculateInterest(int timePeriod)
        {
            return (balance * timePeriod * 5)/100;
        }
    }
}
