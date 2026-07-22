using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENSE707_Week1_Lab_23206450;

namespace BankAccountTests
{
    [TestClass]
    public sealed class BankAccountTests
    {
        // Constructor: current implementation accepts negative opening balances
        [TestMethod]
        public void Constructor_SetsBalance_WhenNegative()
        {
            var acct = new BankAccount("A", -0.01m);
            Assert.AreEqual(-0.01m, acct.Balance);
        }

        // Deposit: current implementation accepts zero and negative deposits
        [TestMethod]
        public void Deposit_Negative_DecreasesBalance()
        {
            var acct = new BankAccount("A", 0m);
            acct.Deposit(-10m);
            Assert.AreEqual(-10m, acct.Balance);
        }

        [TestMethod]
        public void Deposit_Zero_NoChange()
        {
            var acct = new BankAccount("A", 5.00m);
            acct.Deposit(0m);
            Assert.AreEqual(5.00m, acct.Balance);
        }

        [TestMethod]
        public void Deposit_MinimumPositive_IncreasesBalance()
        {
            var acct = new BankAccount("A", 0m);
            acct.Deposit(0.01m);
            Assert.AreEqual(0.01m, acct.Balance);
        }

        // Withdraw: current implementation subtracts the amount (negative withdraw increases balance)
        [TestMethod]
        public void Withdraw_Negative_IncreasesBalance()
        {
            var acct = new BankAccount("A", 1.00m);
            acct.Withdraw(-0.50m); // subtracting a negative adds
            Assert.AreEqual(1.50m, acct.Balance);
        }

        [TestMethod]
        public void Withdraw_Zero_NoChange()
        {
            var acct = new BankAccount("A", 10.00m);
            acct.Withdraw(0m);
            Assert.AreEqual(10.00m, acct.Balance);
        }

        [TestMethod]
        public void Withdraw_ExactBalance_ResultsZero()
        {
            var acct = new BankAccount("A", 100.00m);
            acct.Withdraw(100.00m);
            Assert.AreEqual(0.00m, acct.Balance);
        }

        [TestMethod]
        public void Withdraw_JustOverBalance_AllowsNegativeBalance()
        {
            var acct = new BankAccount("A", 100.00m);
            acct.Withdraw(100.01m);
            Assert.AreEqual(-0.01m, acct.Balance);
        }

        // Transaction fee: current implementation returns amount * 0.02
        [TestMethod]
        public void CalculateTransactionFee_Zero_ReturnsZero()
        {
            var acct = new BankAccount("A", 0m);
            var fee = acct.CalculateTransactionFee(0m);
            Assert.AreEqual(0.00m, fee);
        }

        [TestMethod]
        public void CalculateTransactionFee_Negative_ReturnsNegativeFee()
        {
            var acct = new BankAccount("A", 0m);
            var fee = acct.CalculateTransactionFee(-10.00m);
            Assert.AreEqual(-0.20m, fee);
        }

        [TestMethod]
        public void CalculateTransactionFee_Positive_CalculatesCorrectly()
        {
            var acct = new BankAccount("A", 0m);
            var fee = acct.CalculateTransactionFee(100.00m);
            Assert.AreEqual(2.00m, fee);
        }
    }
}
