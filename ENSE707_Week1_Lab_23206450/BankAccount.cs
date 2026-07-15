using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSE707_Week1_Lab_23206450
{
    internal class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        //initializes the fields of the bank account
        public BankAccount(string accountHolder, decimal openingBalance)
        {
            AccountHolder = accountHolder;
            Balance = openingBalance;
        }

        //calculates the sum current balance and the Deposit amount for the new balance
        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }

        //Subtracts the withdrawal amount from balance for the new balance when user withdraw
        public bool Withdraw(decimal amount)
        {
            Balance = Balance - amount;
            return true;
        }
        //calculates the transaction fee by multiplying the amount by 2%
        public decimal CalculateTransactionFee(decimal amount)
        {
            return amount * 0.02m;
        }
    }
}
