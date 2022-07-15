using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Encapsulation
{
    public class BankAccount
    {public BankAccount()
        { 
        }
        private static double balance = 0;
        public static void Deposit( double x)
        {
            balance = x + balance;
            Console.WriteLine($"Your new balance is {balance}");
        }

       
    }
}
