using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankingSystemOOPDay2
{
    internal class Customer : Person
    {
        public List<Account> Accounts { get; set; } = new();

        public Customer(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public void SeeOverview()
        {
            Console.WriteLine("Overview for customer: " + Name);
        }

    }
}
