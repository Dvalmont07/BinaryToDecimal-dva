using System;
using System.Collections.Generic;

namespace BinaryToDecimal_Application
{
    public class Convertion
    {
        private int _previousNumber = 0;
        private const int _multiplier = 2;
        private readonly List<char> _allowedNumbers = new List<char> { '0', '1' };
        public decimal ConvertBinaryToDecimal(string binarySequence)
        {
            try
            {
                char[] arr = binarySequence.ToCharArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (!_allowedNumbers.Contains(arr[i]))
                    {
                        throw new InvalidOperationException("Error. The string must contain only the numbers 0 or 1");
                    }
                    _previousNumber = _previousNumber * _multiplier + Convert.ToInt32(arr[i].ToString());
                }

                return _previousNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
