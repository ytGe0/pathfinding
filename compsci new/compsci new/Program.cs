using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace compsci_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(100, new customer("Him", true));
            Account yourAccount = new Account(100, new customer("diddy's", false));

            Console.WriteLine(myAccount.getname() + " balance: " + myAccount.getBalance());
            Console.WriteLine(yourAccount.getname() + " balance: " + myAccount.getBalance());
            Console.ReadKey();

            myAccount.makeWithdrawal(100);
            Console.WriteLine(myAccount.getname() + " balance: " + myAccount.getBalance());
            Console.ReadKey();

            yourAccount.makeWithdrawal(100);
            Console.WriteLine(yourAccount.getname() + " balance: " + myAccount.getBalance());
            Console.ReadKey();

            myAccount.makeWithdrawal(100);
            Console.WriteLine(myAccount.getname() + " balance: " + myAccount.getBalance());
            Console.ReadKey();

            yourAccount.makeWithdrawal(100);
            Console.WriteLine(yourAccount.getname() + " balance: " + myAccount.getBalance());
            Console.ReadKey();
        }
    }
}
