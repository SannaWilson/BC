using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQL_BCharj.Logic;

namespace UnitTestProjectCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestaaSummanLaskenta()
        {
            Calculations calc = new Calculations();
            int a = 123;
            int b = 234;

            int sum = calc.Sum(a, b);

            int odotettu = a + b;
            Assert.AreEqual(odotettu, sum);
        }
    }
}
