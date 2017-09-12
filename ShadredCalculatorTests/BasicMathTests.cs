using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class BasicMathTests
    {
        [TestMethod()]
        public void PlusTest()
        {
            //Arrange
            BasicMath Math = new BasicMath();
            //Act
            double add = Math.Plus(5, 6);
            //Assert
            Assert.AreEqual(11, add);
        }

        [TestMethod()]
        public void MinusTest()
        {
            //Arrange
            BasicMath Math = new BasicMath();
            //Act
            double minus = Math.Minus(10, 6);
            //Assert
            Assert.AreEqual(4, minus);
        }

        [TestMethod()]
        public void GangeTest()
        {
            //Arrange
            BasicMath Math = new BasicMath();
            //Act
            double multi = Math.Gange(5, 6);
            //Assert
            Assert.AreEqual(30, multi);
        }

        [TestMethod()]
        public void DividerTest()
        {
            //Arrange
            BasicMath Math = new BasicMath();
            //Act
            double divi = Math.Divider(100, 2);
            //Assert
            Assert.AreEqual(50, divi);
        }

        [TestMethod()]
        public void iAndenTest()
        {
            //Arrange
            BasicMath Math = new BasicMath();
            //Act
            double i2 = Math.iAnden(10);
            //Assert
            Assert.AreEqual(100, i2);
        }
    }
}