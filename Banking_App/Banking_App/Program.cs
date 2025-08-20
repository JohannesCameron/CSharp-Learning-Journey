using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1000);
            acc1.Deposit(1000);
            acc1.Withdraw(500);
            Console.WriteLine(acc1.GetBalance());
        }
    }
}
