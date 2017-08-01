using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSStringAverage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TSStringAverage.Tests
{
    [TestClass()]
    public class TSStringAverageTests
    {
        [TestMethod()]
        public void EmptyString_Should_ReturnNA()
        {
            TestStringAverageWithExpectedAndActual("n/a", "");
        }

        [TestMethod]
        public void StringContainsGreaterThan9_Should_ReturnNA()
        {
            TestStringAverageWithExpectedAndActual("n/a", "ten");
        }

        [TestMethod]
        public void StringWithOneNumString_Should_ReturnItself()
        {
            TestStringAverageWithExpectedAndActual("one", "one");
            TestStringAverageWithExpectedAndActual("two", "two");
            TestStringAverageWithExpectedAndActual("four", "four");
            TestStringAverageWithExpectedAndActual("seven", "seven");
            TestStringAverageWithExpectedAndActual("nine", "nine");
        }


        private static void TestStringAverageWithExpectedAndActual(string expected, string actual)
        {
            TSStringAverage sa = new TSStringAverage();
            Assert.AreEqual(expected, sa.StringAverage(actual));
        }
    }
}
