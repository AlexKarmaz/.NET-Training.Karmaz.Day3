using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// This class contains methods for working with arrays
    /// </summary>
    public static class WorkingWithArrays
    {
        #region Public methods
        /// <summary>
        /// Searches the smallest index in the array which the sum of the elements
        /// to the left of it is equal to the sum of the elements on the right.
        /// </summary>
        /// <param name="array">The System.Array in which the index is searchedy</param>
        /// <returns>The integer value of the array index for which the sum of the elements
        /// to the left of it is equal to the sum of the elements on the right</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static int ReturnIndex(int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException("array");
            }
            if (array.Length == 0)
            {
                throw new Exception("array is empty");
            }
            if (array.Length > 1000)
            {
                throw new Exception("invalid array size");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (SearchIndex(i, array)) return i;
            }
            return -1;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Checks for a specific index in an array the condition:the sum of the elements to the left
        /// of it must be equal to the sum of the elements on the right.
        /// </summary>
        /// <param name="array">The System.Array in which the index is searched</param>
        /// <param name="index"> The index in the array for which the condition is checked </param>
        /// <returns>True if the array has an index for which the condition is satisfied.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        private static bool SearchIndex(int index, int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }
            if(index < 0)
            {
                throw new ArgumentException();
            }
            double sum1 = array.ArraySum(0, index);
            double sum2 = array.ArraySum(index + 1, array.Length);

            if (sum1 == sum2) return true;

            return false;
        }

        /// <summary>
        /// Counts the sum of the elements of the array, starting and ending with the elements whose indices are given.
        /// </summary>
        /// <param name="data">The System.Array in which you want to find the sum of the elements</param>
        /// <param name="startIndex">The index of the element from which the sum is considered</param>
        /// <param name="endIndex">The index of the element to which the sum is considered</param>
        /// <returns>The sum of array elements</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        private static double ArraySum( this int[] data, int startIndex, int endIndex)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
            if (startIndex < 0 || endIndex < 0)
            {
                throw new ArgumentException();
            }
            double sum = 0;

             for(int i = startIndex; i < endIndex; i++)
             {
                  sum += data[i];
             }
          
            return sum;
        }
        #endregion
    }
}
