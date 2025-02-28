using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Customer
    {
        private string name;
        private bool premium;

        public Customer(string inName, bool inPremium)
        {
            name = inName;
            premium = inPremium;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsPremium()
        {
            return premium;
        }
    }

    public class Account
    {
        private double balance;
        private double overDraftLimit;
        private Customer owner;

        public Account(Customer inOwner, double startBalance)
        {
            balance = startBalance;
            owner = inOwner;

            if (owner.IsPremium()) overDraftLimit = 1500;
            else overDraftLimit = 0;
        }

        public void MakeDeposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void MakeWithdrawal(double amount)
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

    public class SavingsAccount : Account
    {
        private int interestRate;
        public SavingsAccount(Customer inOwner, double startBalance, double interestRate) : base(inOwner, startBalance)
        {

        }
    }
}
