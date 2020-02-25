using BinaryToDecimal_Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryToDecimal_Application_TestProj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Convertion convertion = new Convertion();

            int binarySequence = 00000111;
            decimal decimalOutput = 10;
        
            Assert.AreEqual(decimalOutput, 10);

        }
    }
}
