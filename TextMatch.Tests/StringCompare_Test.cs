using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextMatch.Helpers;

namespace TextMatch.Tests
{
    [TestClass]
    public class StringCompare_Test
    {
        [TestMethod]
        public void StringCompare_NoMatches()
        {

            string subtext = "test";
            string text = "TES";

            StringCompare compare = new StringCompare(subtext, text);
            string result = compare.Indexes;

            Assert.IsTrue(String.IsNullOrEmpty(result));

        }

        [TestMethod]
        public void StringCompare_MatchAtTheBeginning()
        {
            System.Diagnostics.Debugger.Launch();

            string subtext = "test";
            string text = "TESt";

            StringCompare compare = new StringCompare(subtext, text);
            string result = compare.Indexes;

            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void StringCompare_MatchesAtTheEnd()
        {
            System.Diagnostics.Debugger.Launch();

            string subtext = "test";
            string text = "aTESt";

            StringCompare compare = new StringCompare(subtext, text);
            string result = compare.Indexes;

            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void StringCompare_MultipleMatches()
        {
            System.Diagnostics.Debugger.Launch();

            string subtext = "test";
            string text = "aTEStTestTest";

            StringCompare compare = new StringCompare(subtext, text);
            string result = compare.Indexes;

            Assert.AreEqual("1,5,9", result);
        }
    }
}
