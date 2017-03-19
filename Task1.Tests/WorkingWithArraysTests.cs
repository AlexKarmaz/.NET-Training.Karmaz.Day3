using System;
using NUnit.Framework;

namespace Task1.Tests
{
    [TestFixture]
    public class WorkingWithArraysTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [Test]
        public int ReturnIndex_PositiveTest(int[] array)
        {
            return WorkingWithArrays.ReturnIndex(array);
        }

        [TestCase(new int[] { 1, 100, 50, 51, 1, 1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 1, -100, 50, 51, 1, 1 }, ExpectedResult = -1)]
        [Test]
        public int ReturnIndex_NegativeTest(int[] array)
        {
            return WorkingWithArrays.ReturnIndex(array);
        }

        [TestCase(null)]
        [Test]
        public void ReturnIndex_IfArgumentIsNull_ThrowsArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => WorkingWithArrays.ReturnIndex(array));
        }

        [TestCase(new int[] {})]
        [Test]
        public void ReturnIndex_IfArrayLengthIsZeroOrMoreThan1000_ThrowsException(int[] array)
        {
            Assert.Throws<Exception>(() => WorkingWithArrays.ReturnIndex(array));
        }
    }
}
