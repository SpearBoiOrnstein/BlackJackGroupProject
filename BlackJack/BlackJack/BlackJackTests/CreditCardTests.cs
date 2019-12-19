using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Tests
{
    [TestClass()]
    public class CreditCardTests
    {
        [TestMethod()]
        public void MakePaymentTestTrue()
        {
            DateTime date = Convert.ToDateTime("11/30/2030");
            CreditCard credit = new CreditCard("1234567890123456","123", date);

            //Arrange
            const bool CORRECT = true;
            const double payment = 25;

            //Act
            bool actualPay = credit.MakePayment(payment);

            //Assert
            Assert.AreEqual(CORRECT, actualPay);
        }
        [TestMethod()]
        public void MakePaymentTestFalseDate()
        {
            // date = Convert.ToDateTime("11/30/2030");
            CreditCard credit = new CreditCard("1234567890123456", "123", DateTime.Now);

            //Arrange
            const bool CORRECT = false;
            const double payment = 25;

            //Act
            bool actualPay = credit.MakePayment(payment);

            //Assert
            Assert.AreEqual(CORRECT, actualPay);
        }
        [TestMethod()]
        public void MakePaymentTestFalseCardNum()
        {
            DateTime date = Convert.ToDateTime("11/30/2030");
            CreditCard credit = new CreditCard("124567890123456", "123", date);

            //Arrange
            const bool CORRECT = false;
            const double payment = 25;

            //Act
            bool actualPay = credit.MakePayment(payment);

            //Assert
            Assert.AreEqual(CORRECT, actualPay);
        }

    }
}