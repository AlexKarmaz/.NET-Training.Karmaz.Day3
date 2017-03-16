using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// This class contains methods for working with string
    /// </summary>
    public static class Class2
    {
        /// <summary>
        /// Concatenate two strings excluding duplicate characters and sort the result alphabetically
        /// </summary>
        /// <param name="str1">The first string for concatenation</param>
        /// <param name="str2">The second string for concatenation</param>
        /// <returns>The sorted string that includes the characters of the transferred strings</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Longest(string str1, string str2)
        {
            if(str1 == null || str2 == null)
            {
                throw new ArgumentNullException();
            }
            char[] result;
            result = String.Concat(str1, str2).ToCharArray();
            result =  result.Distinct().ToArray();
            Array.Sort(result);
                      
            return new string(result);
        }
    }
}
