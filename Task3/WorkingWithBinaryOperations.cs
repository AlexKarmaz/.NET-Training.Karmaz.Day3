using System;
using System.Collections;

namespace Task3
{
    /// <summary>
    /// Class contains methods for working with binary and decimal numbers
    /// </summary>
    public class WorkingWithBinaryOperations
    {
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
            if(index1 < 0 || index2 < 0 || index1 > 31 || index2 > 31)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (index1 > index2)
            {
                throw new ArgumentException();
            }

            var arr1 = new BitArray(new int[] { number1 });
            var arr2 = new BitArray(new int[] { number2 });

            int k = 0;
            for (int i = index1; i <= index2; i++, k++)
            {
                arr1[i] = arr1[i] | arr2[k];
            }

            int[] arr3 = new int[1];
            arr1.CopyTo(arr3, 0);
            return arr3[0];
        }
    }
}
