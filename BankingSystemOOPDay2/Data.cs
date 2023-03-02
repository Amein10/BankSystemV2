using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemOOPDay2
{
    internal class Data
    {
        public static List<Customer> Customers= new();
        public static List<Employee> Employees = new();
        public static List<Account> Accounts = new();

        public static void AddFakeData()
        {
            //    Customers.Add(new Customer("Benny", "benny@gmail.com"));
            //    Employees.Add(new Employee() (Name = "Benny", Id = 1001, password = "1234"));
            //var customers = new List<Customer>();

            Customers.Add(new Customer("Benny Benson", "benben@email.com", "password"));
            Customers.Add(new Customer("Steve Steve", "steve@email.com", "password"));
            Customers.Add(new Customer("Bob Bobby", "bob@email.com", "password"));
        }

    }
}
