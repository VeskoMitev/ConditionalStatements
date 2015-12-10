using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem_13_CompoundInterest;
namespace ConditionalStatements
{
    [TestClass]
    public class TestCompoundInterest
    {
        [TestMethod]
        public void DecimalPow()
        {
            decimal expected = 4.000000000000004000000000000001m;
            decimal result = CompoundInterest.PowDecimal(2.000000000000001m, 2);
            Assert.AreEqual(expected,result );
        }
        [TestMethod]
        public void DecimalLowSmallValuePow()
        {
            decimal expected =0.000000000000000000000000001m;
            decimal result = CompoundInterest.PowDecimal(0.1m, 27);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DecimalStandartPow()
        {
            decimal expected = 16m;
            decimal result = CompoundInterest.PowDecimal(2m, 4);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DecimalBigNumberPow()
        {
            decimal expected =78999999999999999999999999990m;
            decimal result = CompoundInterest.PowDecimal(16765124.110817191331542838334m, 4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BankLoan1()
        {
            decimal expected = 2976.74m;
            decimal result = CompoundInterest.CalcBankLoan(2600m, 2, 0.07m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BankLoan2()
        {
            decimal expected = 36896.2159627461m;
            decimal result = CompoundInterest.CalcBankLoan(30000m, 7, 0.03m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BankLoan3()
        {
            decimal expected = 0.110462212541120451001m;
            decimal result = CompoundInterest.CalcBankLoan(0.1m, 10, 0.01m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FriendLoan1()
        {
            decimal expected = 3640m;
            decimal result = CompoundInterest.CalcFriendLoan(2600m, 0.4m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FriendLoan2()
        {
            decimal expected = 2782m;
            decimal result = CompoundInterest.CalcFriendLoan(2600m, 0.07m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void FriendLoan3()
        {
            decimal expected = 5174m;
            decimal result = CompoundInterest.CalcFriendLoan(2600m, 0.99m);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void akeResult1()
        {
            decimal price = 2600;
            uint years = 2;
            decimal bankRate = 0.07m;
            decimal friendRate = 0.4m;
            string expected = "2976.74 Bank";
            string result = CompoundInterest.MakeResult
            (CompoundInterest.CalcBankLoan(price, years, bankRate),
                CompoundInterest.CalcFriendLoan(price, friendRate));
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void akeResult2()
        {
            decimal price = 800;
            uint years = 10;
            decimal bankRate = 0.01m;
            decimal friendRate = 0.1m;
            string expected = "880.00 Friend";
            string result = CompoundInterest.MakeResult
            (CompoundInterest.CalcBankLoan(price, years, bankRate),
                CompoundInterest.CalcFriendLoan(price, friendRate));
            Assert.AreEqual(expected, result);
        }
        

    }
}
