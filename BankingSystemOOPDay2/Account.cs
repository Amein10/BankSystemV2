using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemOOPDay2
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account() { }

        public Account(int accountNumber, string nameOfOwner)
        {
            this.AccountNumber = accountNumber;
            this.Name = nameOfOwner;
            Balance = 0;
        }

        public void DepositMoney(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new Exception("Insufficient balance.");
            }
        }

        public void TransferMoney(Account account, decimal amount)
        {
        }

        public void SeeOverview()
        {
            Console.WriteLine("Name: " + Name + ", Accountnumber: " + AccountNumber + ", Balance: " + Balance);
            //Console.WriteLine($"Accountnumber {AccountNumber}: Name: {Name}, Balance = {Balance:C}");

            //Console.WriteLine("Overview for account:");
            //Console.WriteLine("Balance: " + Balance);
        }
    }
}
