using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemos.UnitTest
{
    using NUnit.Framework;
    using TestApp;

    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void CreatingBankAccountShouldSetInititalAccount()
        {
            var bankAccount = new BankAccount(2000);

            Assert.AreEqual(2000, bankAccount.Amount);

        }
    }
}
