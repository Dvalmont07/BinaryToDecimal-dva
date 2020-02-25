using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaryToDecimal_Application.Tests
{
    [TestClass()]
    public class ConvertionTests
    {
        Convertion convertion;
        public ConvertionTests()
        {
            convertion = new Convertion();

        }
        [TestMethod()]
        public void ConvertBinaryToDecimalTestSuccess()
        {
            string binaryString = "1010";            
            Assert.AreEqual(convertion.ConvertBinaryToDecimal(binaryString),10);
        }
        [TestMethod()]
        public void ConvertBinaryToDecimalTestFail()
        {
            string binaryString = "10110";
            Assert.AreNotEqual(convertion.ConvertBinaryToDecimal(binaryString), 21);
        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ConvertBinaryToDecimalTestNotBinarryNumberFail()
        {
            string binaryString = "10112";
            decimal output = convertion.ConvertBinaryToDecimal(binaryString);
        }
    }
}