using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace Practika_6_Tests
{
    [TestClass]
    public class Practika_6_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
