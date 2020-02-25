using BinaryToDecimal_Application;
using System;

namespace BinaryToDecimal_Console
{
    class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            try
            {
                string binarySequence = "101";
                Convertion convertion = new Convertion();
                Console.WriteLine($" The decimal value of {binarySequence} is {convertion.ConvertBinaryToDecimal(binarySequence)}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
