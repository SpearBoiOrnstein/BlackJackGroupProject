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
    public class PlayerTests
    {
        [TestMethod()]
        public void isUserTestFalse()
        {
            Player player = new Player();
            //Arrange
            const bool CORRECT = false;
            //Act
            bool test = player.isUser("yyyyyy", "yyyyyy");
            //bool test = player.isUser("Dealer", "Money");
            //Assert
            Assert.AreEqual(CORRECT, test);
        }
        [TestMethod()]
        public void isUserTestTrue()
        {
            Player player = new Player();
            //Arrange
            const bool CORRECT = true;
            //Act
            CreditCard credit = new CreditCard("123457890123456", "123", DateTime.Now);
            player.AddUser("Dealer", "Money", "Will", "Will", "phone", credit);
            bool test = player.isUser("Dealer", "Money");

            //Assert
            Assert.AreEqual(CORRECT, test);
        }

        [TestMethod()]
        public void doBetTestTrue()
        {
            Player player = new Player();
            player.money = 1000;
            
            //Arrange
            const bool CORRECT = true;

            //Act
            bool test = player.doBet(1000);

            //Assert
            Assert.AreEqual(CORRECT, test);
        }

        [TestMethod()]
        public void doBetTestFalseLessThan0()
        {
            Player player = new Player();
            player.money = 1000;

            //Arrange
            const bool CORRECT = false;

            //Act
            bool test = player.doBet(-1000);

            //Assert
            Assert.AreEqual(CORRECT, test);
        }

        [TestMethod()]
        public void doBetTestFalseGreaterThanMoney()
        {
            Player player = new Player();
            player.money = 1000;

            //Arrange
            const bool CORRECT = false;

            //Act
            bool test = player.doBet(9000);

            //Assert
            Assert.AreEqual(CORRECT, test);
        }
    }
}