using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_System
{
    internal class ShowMenu
    {
        public void menu()
        {
            Bank_System bank = new Bank_System(10);
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1. Open Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check balance");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);//validate a number
                if (!isNumber)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Introduce the account number: ");
                        int accountNumber;
                        isNumber = int.TryParse(Console.ReadLine(), out accountNumber);
                        if (!isNumber)
                        {
                            Console.WriteLine("Invalid account number");
                            break;
                        }
                        Account account = new Account();
                        account.AccountNumber = accountNumber;
                        Console.WriteLine("Introduce the account holder name: ");
                        account.HolderName = Console.ReadLine();
                        bank.OpenAccount(account);
                        break;
                    case 2:
                        Console.WriteLine("Introduce the account number: ");
                        int key1;
                        isNumber = int.TryParse(Console.ReadLine(), out key1);
                        if (!isNumber)
                        {
                            Console.WriteLine("Invalid account number");
                            break;
                        }
                        Console.WriteLine("Introduce the amount to deposit: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        isNumber = double.TryParse(Console.ReadLine(), out deposit);
                        if (!isNumber)
                        {
                            Console.WriteLine("Invalid deposit amount");
                            break;
                        }
                        bank.DepositAccount(deposit, key1);
                        break;
                    case 3:
                        Console.WriteLine("Introduce the account number: ");
                        int key2;
                        isNumber = int.TryParse(Console.ReadLine(), out key2);
                        if (!isNumber)
                        {
                            Console.WriteLine("Invalid account number");
                            break;
                        }
                        Console.WriteLine("Introduce the amount to deposit");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        isNumber = double.TryParse(Console.ReadLine(), out withdraw);
                        if (!isNumber)
                        {
                            Console.WriteLine("Invalid account number");
                            break;
                        }
                        bank.Withdraw(withdraw, key2);
                        break;
                    case 4:
                        Console.WriteLine("Introduce the account number: ");
                        int key3;
                        isNumber = int.TryParse(Console.ReadLine(), out key3);
                        if (!isNumber)
                        {
                            Console.WriteLine("Invalid account number");
                            break;
                        }
                        bank.ShowBalance(key3);
                        break;
                    case 5:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }
    }
}
