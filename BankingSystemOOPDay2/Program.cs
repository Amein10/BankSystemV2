using System;
namespace BankingSystemOOPDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Data.AddFakeData();
            var customer1 = new Customer("Benny", "benny@email.com", "password");
            var account1 = new Account();
           // customer1.TransferMoney(account1, 100.00m);
            account1.SeeOverview();

            var employee1 = new Employee("Bob", "password");
            employee1.Customers = new List<Customer>();
            employee1.CreateCustomer("Sarah", "sarah@email.com", "password");
            employee1.SeeCustomers();
            employee1.CreateAccount(customer1);
        }

    }

}