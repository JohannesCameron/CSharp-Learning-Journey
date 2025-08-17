using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_ACcount_Simulator
{
    internal class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                balance = value;
            }
        }

        public string OwnerName { get; set; }

        public BankAccount(decimal bal, string ownerName)
        {
            Balance = bal;
            OwnerName = ownerName;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
