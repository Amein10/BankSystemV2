using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemOOPDay2
{
    // Lav en login
    // Se en oversigt over kontier og beløb
    // Have en overførselsmenu
    // Employeen kan have en oversigt over kunder
    internal class Menu
    {

        public Menu()
        {
        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Bank System");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Create a login");
                Console.WriteLine("2. Overview of accounts and balance");
                Console.WriteLine("3. Transfer");
                Console.WriteLine("4. Employee Overview of Customers");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------------");
                Console.Write("Enter your choice: ");


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
  //                      CreateLogin();
                        break;
                    case "2":
 //                       OverviewAccountsAndBalance();
                        break;
                    case "3":
 //                       Transfer();
                        break;
                    case "4":
 //                       EmployeeOverviewOfCustomers();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }

}