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
        [TestMethod]
        public void TestaaTuloa()
        {
            Calculations tulo = new Calculations();
            int a = 123;
            int b = 234;

            int tulos = tulo.Tulo(a, b);

            int odotettu = a * b;
            Assert.AreEqual(odotettu, tulos);
        }
        [TestMethod]
        public void TestaaErotusta()
        {
            Calculations erotus = new Calculations();
            int a = 123;
            int b = 234;

            int tulos = erotus.Erotus(a, b);

            int odotettu = a - b;
            Assert.AreEqual(odotettu, tulos);
        }
        [TestMethod]
        public void TestaaJakolaskua()
        {
            Calculations lasku = new Calculations();
            int a = 123;
            int b = 234;

            int tulos = lasku.Jakolasku(a, b);

            int odotettu = a / b;
            Assert.AreEqual(odotettu, tulos);
        }
    }
}
