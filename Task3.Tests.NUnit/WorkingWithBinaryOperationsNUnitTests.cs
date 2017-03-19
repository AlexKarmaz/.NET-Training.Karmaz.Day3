using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Task3.Tests.NUnit
{
    [TestFixture]
    public class WorkingWithBinaryOperationsNUnitTests
    {
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(0, 15, 30, 30, ExpectedResult = 1073741824)]
        [TestCase(0, 15, 0, 30, ExpectedResult = 15)]
        [TestCase(int.MaxValue, int.MaxValue, 3, 5, ExpectedResult = int.MaxValue)]
        [TestCase(15, int.MaxValue, 3, 5, ExpectedResult = 63)]
        [TestCase(15, 15, 1, 3, ExpectedResult = 15)]
        [TestCase(15, 15, 1, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 0, 4, ExpectedResult = 31)]
        [TestCase(15, -15, 1, 4, ExpectedResult = 15)]
        [TestCase(-8, -15, 1, 4, ExpectedResult = -6)]
        [Test]
        public int Insert_PositiveTest(int number1, int number2, int index1, int index2)
        {
            return WorkingWithBinaryOperations.Insert(number1, number2, index1, index2);
        }

        [TestCase(8, 15, -1, 5)]
        [TestCase(8, 15, 5, -1)]
        [TestCase(8, 15, 32, 5)]
        [TestCase(8, 15, 5, 32)]
        [Test]
        public void Insert_ThrowsArgumentOutOfRangeException(int number1, int number2, int index1, int index2)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => WorkingWithBinaryOperations.Insert(number1, number2, index1, index2));
        }

        [TestCase(8, 15, 7, 5)]
        [TestCase(8, 15, 1, 0)]
        [Test]
        public void Insert_ThrowsArgumentException(int number1, int number2, int index1, int index2)
        {
            Assert.Throws<ArgumentException>(() => WorkingWithBinaryOperations.Insert(number1, number2, index1, index2));
        }
    }
}
