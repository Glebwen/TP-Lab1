using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_program.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void IncorrectInputTest()
        {
            string line = "incorrect";

            Assert.AreEqual(Logic.CountLine(line), "некорректный ввод");
        }

        [TestMethod()]
        public void NotCompletelyCorrectInputTest()
        {
            string line = "-5+5-5";

            Assert.AreEqual(Logic.CountLine(line), "некорректный ввод");
        }

        [TestMethod()]
        public void CorrectInputTest()
        {
            string line = "5+5-5+6";

            Assert.AreEqual(Logic.CountLine(line), "11");
        }
    }
}