using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
    [TestMethod]
    public void BasicRooterTest()
    {
        Rooter rooter = new Rooter();
        double expectedResult = 2.0;
        double input = expectedResult * expectedResult;
        double actualResult = rooter.SquareRoot(input);

        Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
    }
}

