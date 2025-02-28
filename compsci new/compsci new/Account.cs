using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compsci_new
{
    internal class Account
    {
        private int balance;
        private int overDraftLimit;
        private customer theowner;

        public Account(int Balance, customer owner)
        {
            balance = Balance;
            theowner = owner;
            if (theowner.premium == true)
            {
                overDraftLimit = 1500;
            }
            else
            {
                overDraftLimit = 0;
            }
        }

        public Account(int startBalance)
        {
            balance = startBalance;
        }

        public void makeDeposit(int amount)
        {
            balance += amount;
        }

        public int getBalance()
        {
            return balance;
        }

        public string getname()
        {
            return theowner.name;
        }

        public void makeWithdrawal(int amount)
        {
            if (balance + overDraftLimit >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new ArgumentException("Insufficient funds.");
            }
        }

    }
}
