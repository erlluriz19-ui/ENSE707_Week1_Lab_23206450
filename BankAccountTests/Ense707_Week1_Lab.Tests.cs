using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENSE707_Week1_Lab_23206450;

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
    }
}