using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryToDecimal_Application.Tests
{
    [TestClass()]
    public class ConvertionTests
    {
        [TestMethod()]
        public void ConvertBinaryToDecimalTest()
        {
            Convertion convertion = new Convertion();

            int binarySequence = 00000111;
            decimal decimalOutput = 10;

            Assert.AreEqual(decimalOutput, 10);
            
        }
    }
}