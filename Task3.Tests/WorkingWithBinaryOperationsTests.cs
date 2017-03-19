using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Tests.MSUnit.DDT
{
    [TestClass]
    public class WorkingWithBinaryOperationsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\NumbersForPositiveTest.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("DDT.Demo.Tests\\NumbersForPositiveTest.xml")]
        public void Insert_Numbers_PositiveTest()
        {
            int first = Convert.ToInt32(TestContext.DataRow["number1"]);
            int second = Convert.ToInt32(TestContext.DataRow["number2"]); ;
            int leftPosition = Convert.ToInt32(TestContext.DataRow["index1"]);
            int rightPosition = Convert.ToInt32(TestContext.DataRow["index2"]);
           
            int expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);

            int actual = WorkingWithBinaryOperations.Insert(first,second,leftPosition,rightPosition);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\NumbersForTestThrowsArgumentException.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("DDT.Demo.Tests\\NumbersForTestThrowsArgumentException.xml")]
        [ExpectedException(typeof(ArgumentException))]
        public void Insert_LeftIndexMoreRightIndex_ThrowsArgumentException()
        {
            int first = Convert.ToInt32(TestContext.DataRow["number1"]);
            int second = Convert.ToInt32(TestContext.DataRow["number2"]); ;
            int leftPosition = Convert.ToInt32(TestContext.DataRow["index1"]);
            int rightPosition = Convert.ToInt32(TestContext.DataRow["index2"]);
                   
            int actual = WorkingWithBinaryOperations.Insert(first, second, leftPosition, rightPosition);
        }

        [TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\NumbersForTestThrowsArgumentOutOfRangeException.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("DDT.Demo.Tests\\NumbersForTestThrowsArgumentOutOfRangeException.xml")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Insert_IndexesLessThan0AndMoreThan31_ThrowsArgumentOutOfRangeException()
        {
            int first = Convert.ToInt32(TestContext.DataRow["number1"]);
            int second = Convert.ToInt32(TestContext.DataRow["number2"]); ;
            int leftPosition = Convert.ToInt32(TestContext.DataRow["index1"]);
            int rightPosition = Convert.ToInt32(TestContext.DataRow["index2"]);

            int actual = WorkingWithBinaryOperations.Insert(first, second, leftPosition, rightPosition);
        }
        
    }
}
