using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENSE707_Week1_Lab_23206450;
using System;

namespace BankAccountTests
{
    [TestClass]
    public sealed class BankAccountTests
    {
        [TestMethod]
        public void Deposit_PositiveAmount_IncreasesBalance()
        {
            BankAccount account = new BankAccount("Test User", 100);

            account.Deposit(50);

            Assert.AreEqual(150, account.Balance);
        }
        [TestMethod]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            BankAccount account = new BankAccount("Test User", 100);

            bool result = account.Withdraw(30);

            Assert.AreEqual(70, account.Balance);
        }
        [TestMethod]
        public void Constructor_NegativeOpeningBalance_ThrowsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            new BankAccount("Test User", -10));
        }

        [TestMethod]
        public void Deposit_NegativeAmount_ThrowsException()
        {
            BankAccount account = new BankAccount("Test User", 100);

            Assert.ThrowsException<ArgumentException>(() =>
            account.Deposit(-20));
        }

        [TestMethod]
        public void Withdraw_NegativeAmount_ThrowsException()
        {
            BankAccount account = new BankAccount("Test User", 100);

            Assert.ThrowsException<ArgumentException>(() =>
            account.Withdraw(-20));
        }

        public void CalculateTransactionFee_ValidAmount_ReturnsTwoPercentFee()
        {
            BankAccount account = new BankAccount("Test User", 100);

            decimal fee = account.CalculateTransactionFee(200);
        }
    }
}