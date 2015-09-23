using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextMatch.Helpers;


namespace TextMatch.Tests
{
    [TestClass]
    public class CaseConverter_test
    {
        [TestMethod]
        public void CaseConverter_AssertToLower()
        {
            System.Diagnostics.Debugger.Launch();

            string lower = "test";
            string upper = "TEST";

            CaseConverter cc = new CaseConverter(upper);

            string fromUpper = cc.ToLower;

            Assert.AreEqual(lower, fromUpper);
        }
    }
}
