using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemOOPDay2
{
    internal class Employee : Person
    {
        public List<Customer> Customers { get; set; }

        public Employee(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void SeeCustomers()
        {
            Console.WriteLine("Customers:");
            foreach (var customer in Customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void CreateCustomer(string name, string email, string password)
        {
            Console.WriteLine("Input the name of the customer:");
           // string name = Console.ReadLine();
            var customer = new Customer(name, email, password);
            Customers.Add(customer);
        }

        public void CreateAccount(Customer customer)
        {
            var account = new Account();
            // Implement logic to link account with customer here
        }
    }

}
