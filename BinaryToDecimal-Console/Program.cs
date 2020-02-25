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
                Console.WriteLine("Type a binary sequence");
                Convertion convertion = new Convertion();
                string binarySequence = Console.ReadLine();

                Console.WriteLine($" The decimal value of {binarySequence} is {convertion.ConvertBinaryToDecimal(binarySequence)}");
                Console.WriteLine($" The decimal value of using a simplified method is {convertion.ConvertBinaryToDecimalSimplefied(binarySequence)}");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
