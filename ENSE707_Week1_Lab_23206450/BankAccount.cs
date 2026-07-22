using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSE707_Week1_Lab_23206450
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        //initializes the fields of the bank account
        public BankAccount(string accountHolder, decimal openingBalance)
        {
            if (string.IsNullOrEmpty(accountHolder))
            {
                throw new ArgumentException("Account Holder name needed");
            }

            if (openingBalance < 0)
            {
                throw new ArgumentException("Opening balance cannot be negaitve");
            }
            AccountHolder = accountHolder;
            Balance = openingBalance;
        }

        //calculates the sum current balance and the Deposit amount for the new balance
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            Balance += amount;
        }

        //Subtracts the withdrawal amount from balance for the new balance when user withdraw
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive");
            }

            if (amount > Balance)
            {
                throw new ArgumentException(nameof(amount), "Withdrawal amount cannot exceed the account balance");
            }
                Balance -= amount;
                return true;
        }
        //calculates the transaction fee by multiplying the amount by 2%
        public decimal CalculateTransactionFee(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("Transaction amount must be positive");
            }
            return amount * 0.02m;
        }
    }
}
