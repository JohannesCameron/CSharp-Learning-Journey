using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public interface IAccount
    {
        void Deposit(decimal amount);
        void Withdraw (decimal amount);
        decimal GetBalance();
    }

    class Account : IAccount
    { 
        public int accountNumber { get; set; }
        public decimal balance { get; protected set; }

        public Account(decimal Balance)
        {
            balance = Balance;
        }

        public void Deposit(decimal Balance)
        {
            balance += Balance;
        }

        public void Withdraw(decimal Balance)
        {
            balance -= Balance;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }

    class SavingsAccount : Account 
    {
        public decimal InterestRate = 0.02m;

        public SavingsAccount(decimal initialBalance) : base(initialBalance) { }

        public void AddInterest()
        {
            balance += balance * InterestRate;
        }
    }


}
