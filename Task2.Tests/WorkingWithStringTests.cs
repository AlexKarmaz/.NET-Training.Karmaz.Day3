using System;
using NUnit.Framework;
using System;

namespace Task2.Tests
{
    [TestFixture]
    public class WorkingWithStringTests
    {
        [TestCase("xyaabbbccccdefww","xxxxyyyyabklmopq", ExpectedResult = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        [Test]
        public string Longest_PositiveTest(string str1, string str2)
        {
            return WorkingWithString.Longest(str1,str2);
        }

        [TestCase(null,null)]
        [TestCase("xyaabbbccccdefww", null)]
        [TestCase(null, "xyaabbbccccdefww")]
        [Test]
        public void Longest_IfArgumentsAreNull_ThrowsArgumentNullException(string str1, string str2)
        {
            Assert.Throws<ArgumentNullException>(() => WorkingWithString.Longest(str1, str2));
        }
    }
}
