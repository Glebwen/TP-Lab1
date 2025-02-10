using Microsoft.VisualStudio.TestTools.UnitTesting;
using if_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_program.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void IncorrectInputTest()
        {
            string n = "AAAAAAAAA";

            Assert.AreEqual(Logic.Convert(n), "некорректный ввод");
        }


        [TestMethod()]
        public void OutOfBoundsTest()
        {
            string n = "0";

            Assert.AreEqual(Logic.Convert(n), "число за пределом ОДЗ");
        }

        [TestMethod()]
        public void IntRubTest()
        {
            string n = "5500";

            Assert.AreEqual(Logic.Convert(n), "55 рублей ровно");
        }

        [TestMethod()]
        public void NotIntRubTest()
        {
            string n = "5545";

            Assert.AreEqual(Logic.Convert(n), "55 рублей 45 копеек");
        }
    }
}