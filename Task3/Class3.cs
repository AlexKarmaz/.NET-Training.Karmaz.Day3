using System;


namespace Task3
{
    /// <summary>
    /// Class contains methods for working with binary and decimal numbers
    /// </summary>
    public class Class3
    {
        #region Public methods
        /// <summary>
        /// Insert one number to another
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <param name="index1">First index</param>
        /// <param name="index2">Second index</param>
        /// <returns>New number after insertion</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Insert(int number1, int number2, int index1, int index2)
         {
            if (index1 > index2)
            {
                throw new ArgumentException("Incorrect parameters");
            }

            int[] number1Bin = GetBinary(number1);
            int[] number2Bin = GetBinary(number2);
            int j = 32;
            for (int i = index2; i >= index1; i--)
            {
                number1Bin[Math.Abs(i-32)] = number2Bin[j--];
            }
            return GetDecimal(number1Bin);
         }
        #endregion

        #region Private methods
        /// <summary>
        /// Return binary representation of decimal number
        /// </summary>
        /// <param name="number">Decimel number</param>
        /// <returns>System.Array of integer type</returns>
        private static int[] GetBinary(int number)
        {
            int[] binary = new int[33];
            if (number < 0)
            {
                number = number * (-1);
                binary[0] = 1;
            }
            int i = 32;
            while (number >= 1)
            {
                int m = number % 2;
                number = number / 2;
                binary[i--] = m;
            }

            return binary;
        }

        /// <summary>
        /// Return decimal representation of binary number
        /// </summary>
        /// <param name="binary">System.Array</param>
        /// <returns>Integer decimal number</returns>
        private static int GetDecimal(int[] binary)
        {
            int result = 0;
            for (int i = 32; i > 0; i--)
            {
                result = result + (binary[i])*(int)Math.Pow(2,Math.Abs(i - 32));
            }
            if (binary[0] == 1)
            {
                result = result * (-1);
            }
            return result;
        }
        #endregion

    }
}
