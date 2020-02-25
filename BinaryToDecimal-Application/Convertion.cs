using System;
using System.Collections.Generic;

namespace BinaryToDecimal_Application
{
    public class Convertion
    {
        private decimal _decimalNumber = 0;
        private const int _multiplier = 2;
        private readonly List<char> _allowedNumbers = new List<char> { '0', '1' };
        public decimal ConvertBinaryToDecimalSimplefied(string binarySequence)
        {
            try
            {
                ValidateString(binarySequence);
                _decimalNumber = (Convert.ToInt32(binarySequence, 2));

                return _decimalNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public decimal ConvertBinaryToDecimal(string binarySequence)
        {
            try
            {
                //  _decimalNumber = (Convert.ToInt32(binarySequence, 2));
                char[] arr = binarySequence.ToCharArray();

                ValidateString(binarySequence);

                for (int i = 0; i < arr.Length; i++)
                {
                    if (!_allowedNumbers.Contains(arr[i]))
                    {
                        throw new InvalidOperationException("Error: The string must contain only the numbers 0 or 1");
                    }
                    _decimalNumber = _decimalNumber * _multiplier + Convert.ToInt32(arr[i].ToString());
                }

                return _decimalNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void ValidateString(string binarySequence)
        {
            if (binarySequence.Length > 8)
                throw new ArgumentOutOfRangeException("Error: the length must not exceed eight digits");
            if (string.IsNullOrEmpty(binarySequence))
                throw new NullReferenceException("Error: Null argument, please type a string");

        }
    }
}
