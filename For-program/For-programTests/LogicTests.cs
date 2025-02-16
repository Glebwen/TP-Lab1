using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace For_program.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void InvalidInputTest()
        {
            var a = "AAAAA";
            var b = "BBBBB";
            var c = "CCCCC";

            Assert.AreEqual(Logic.IncreaseMonthCount(a, b, c), "некорректный ввод");
            Assert.AreEqual(Logic.DepositMonthCount(a, b, c), "некорректный ввод");
        }
        [TestMethod()]
        public void OutOfBoundsTest()
        {
            var a = "-100";
            var b = "5";
            var c = "200";

            Assert.AreEqual(Logic.IncreaseMonthCount(a, b, c), "числа за пределами ОДЗ");
            Assert.AreEqual(Logic.DepositMonthCount(a, b, c), "числа за пределами ОДЗ");
        }

        [TestMethod()]
        public void NormalInputTest()
        {
            var a = "100";
            var b = "5";
            var c = "200";

            Assert.AreEqual(Logic.IncreaseMonthCount(a, b, c), "48");
            Assert.AreEqual(Logic.DepositMonthCount(a, b, c), "36");
        }
    }
}