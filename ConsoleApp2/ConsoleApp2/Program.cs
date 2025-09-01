using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ac = new BankAccount(987654321, 1000);
            while (true)
            {
                Console.Write("1.Depoit\n2.Withdraw\n3.Ckeck Balance\n4.Exit\nEnter choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1: ac.Depoist(); break;
                    case 2: ac.Withdraw(); break;
                    case 3: ac.GetBalance(); break;
                    default: Console.WriteLine("Invalid choice! exiting program"); return;
                }
            }
        }
    }
}
