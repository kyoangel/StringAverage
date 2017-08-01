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
            TSStringAverage sa = new TSStringAverage();
            Assert.AreEqual("n/a", sa.StringAverage(""));
        }
    }
}
