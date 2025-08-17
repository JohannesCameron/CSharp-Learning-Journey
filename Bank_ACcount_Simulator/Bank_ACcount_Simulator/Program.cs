using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ACcount_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(12000, "Cameron");

            account1.Deposit(5000);
            Console.WriteLine(account1.Balance);

            account1.Withdraw(2000);
            Console.WriteLine(account1.Balance);
        }
    }
}
