using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_CustomException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(1000);
            bankAccount.withdraw(2000); 

            Type type = typeof(BankAccount);
            Console.WriteLine($"Name: {type.Name}\nNamespace: {type.Namespace}\nAssembly: {type.Assembly}");

            var propertyInfo = type.GetProperties();
            foreach (var property in propertyInfo) {
                Console.WriteLine($"Propery: {property.Name}");
            }

            var methodsInfo = type.GetMethods();
            foreach (var method in methodsInfo)
            {
                Console.WriteLine($"Method: {method.Name}");
            }
        }
    }
}
