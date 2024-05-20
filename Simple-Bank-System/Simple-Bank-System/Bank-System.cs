using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_System
{
    internal class Bank_System
    {
        Account[] accounts { get; set; }
        int count = 0;

        public Bank_System(int i)
        {
            accounts = new Account[i];
        }

        public void OpenAccount(Account inf)
        {
            for (int i= 0; i< accounts.Length; i++)
            {
                if (accounts[i] == null) 
                {
                    accounts[i] = inf;
                    Console.WriteLine("Account created successfully");
                    Console.WriteLine($"Account number:  {accounts[i].AccountNumber}");
                    Console.WriteLine($"Account holder name: {accounts[i].HolderName}");
                    Console.WriteLine($"Balance: {accounts[i].balance}");
                    count++;
                    break;

                }
            }
        }

        public void DepositAccount(double deposit, int key)
        {
            for (int i = 0; i< count; i++ )
            {
                if (accounts[i].AccountNumber == key)
                {
                    accounts[i].balance += deposit;
                    Console.WriteLine("Deposit successful");
                    Console.WriteLine($"Your new balance is: {accounts[i].balance}");
                    break;
                }
            }
            Console.WriteLine("Account not found");
        }

        public void Withdraw(double deposit, int key)
        {
            for (int i = 0; i< count; i++)
            {
                if (accounts[i].AccountNumber == key && deposit < accounts[i].balance)
                {
                    accounts[i].balance -= deposit;
                    Console.WriteLine("Withdrawal successful");
                    Console.WriteLine($"Your new balance is: {accounts[i].balance}");
                    break;
                }
            }
        }

        public void ShowBalance(int key)
        {
            for(int i = 0; i<count; i++)
            {
                if(accounts[i].AccountNumber == key)
                {
                    Console.WriteLine($"Your information\n Number Account: {accounts[i].AccountNumber}\n Holder's  Name: {accounts[i].HolderName} \n Balance: {accounts[i].balance}$");
                    break;
                }
            }
        }
    }
}
