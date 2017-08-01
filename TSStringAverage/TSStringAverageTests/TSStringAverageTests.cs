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

        [TestMethod]
        public void CodewarsKataStandarTestCase()
        {
            TestStringAverageWithExpectedAndActual("four", "zero nine five two");
            TestStringAverageWithExpectedAndActual("three", "four six two three");
            TestStringAverageWithExpectedAndActual("three", "one two three four five");
            TestStringAverageWithExpectedAndActual("four", "five four");
            TestStringAverageWithExpectedAndActual("zero", "zero zero zero zero zero");
            TestStringAverageWithExpectedAndActual("two", "one one eight one");
            TestStringAverageWithExpectedAndActual("n/a", "");
        }


        private static void TestStringAverageWithExpectedAndActual(string expected, string actual)
        {
            TSStringAverage sa = new TSStringAverage();
            Assert.AreEqual(expected, sa.StringAverage(actual));
        }
    }
}
