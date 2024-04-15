using proglaba1;
using System.Globalization;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorTest()
        {

            Assert.AreEqual(new Rational(8, 1).ToString(), "8");
            Assert.AreEqual(new Rational(2, 7).ToString(), "2/7");
            Assert.AreEqual(new Rational(4, 10).ToString(), "2/5");
            Assert.AreEqual(new Rational(-7, 1).ToString(), "-7");
            try
            {
                Rational r = new Rational(4, 0);
            }
            catch{
               
            }
        }
        [Test]
        public void OperationTest()
        {
            Rational r = new Rational(4, 6);
            Rational R = new Rational(1, 9);
            Assert.AreEqual((r + R).ToString(), "7/9");
            Assert.AreEqual((r - R).ToString(), "5/9");
            Assert.AreEqual((R - r).ToString(), "-5/9");
            Assert.AreEqual((r * R).ToString(), "2/27");
            Assert.AreEqual((r / R).ToString(), "6");
            Assert.AreEqual((R / r).ToString(), "1/6");
            Assert.AreEqual((-r).ToString(), new Rational(-r.Numerator, r.Denominator).ToString());
            Assert.AreEqual(r == new Rational(r.Numerator, r.Denominator), true);
            Assert.AreEqual(r == R, false);
            Assert.AreEqual(r > R, true);
            Assert.AreEqual(r >= R, true);
            Assert.AreEqual(r < R, false);
            Assert.AreEqual(r <= R, false);
            Assert.AreEqual(r != R, true);
        }
    }
}