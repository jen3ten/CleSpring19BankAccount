using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class CheckingAccount
    {
        public decimal Balance { get; set; }

        public void Deposit(decimal depositAmount)
        {
            //Balance = Balance + depositAmount;
            Balance += depositAmount;
        }

        public void Withdrawal(decimal withdrawalAmount)
        {
            Balance -= withdrawalAmount;
        }
    }
}
