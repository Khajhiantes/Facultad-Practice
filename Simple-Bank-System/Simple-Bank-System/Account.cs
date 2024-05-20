using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_System
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double balance;
        public Account()
        {
            balance = 0;
        }


    }
}
