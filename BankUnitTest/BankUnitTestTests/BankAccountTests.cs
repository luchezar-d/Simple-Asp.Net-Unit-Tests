using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            BankAccount bank = new BankAccount("John", 0 );

            try
            {
                bank.Debit(2);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Amount is <= 0 or > balance");
                return;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Balance is 0");
                return;
            }
            Assert.Fail("No Exception was thrown");
        }

        [TestMethod]
        public void TestCreditCase()
        {
            BankAccount bank = new BankAccount("John", 2);
            bank.Credit(2);
            Assert.AreEqual(4, bank.Blanace);
        }

        [TestMethod]
        public void TestDebitCase()
        {
            BankAccount bank = new BankAccount("John", 2);
            bank.Debit(2);
            Assert.AreEqual(0, bank.Blanace);
        }

        [TestMethod]
        public void TestCreditDebitCase()
        {
            BankAccount bank = new BankAccount("John", 2);
            bank.Debit(2);
            bank.Credit(2);
            Assert.AreEqual(2, bank.Blanace);
        }
    }
}