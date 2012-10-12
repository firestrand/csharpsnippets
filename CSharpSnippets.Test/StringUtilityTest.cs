using CSharpSnippets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpSnippets.Test
{
    [TestClass]
    public class StringUtilityTest
    {
        [TestMethod]
        public void UrlCombineTest()
        {
            Assert.AreEqual(StringUtility.UrlCombine("test1", "test2"), "test1/test2");
            Assert.AreEqual(StringUtility.UrlCombine("test1/", "test2"), "test1/test2");
            Assert.AreEqual(StringUtility.UrlCombine("test1", "/test2"), "test1/test2");
            Assert.AreEqual(StringUtility.UrlCombine("test1/", "/test2"), "test1/test2");
            Assert.AreEqual(StringUtility.UrlCombine("/test1/", "/test2/"), "/test1/test2/");
            Assert.AreEqual(StringUtility.UrlCombine("", "/test2/"), "/test2/");
            Assert.AreEqual(StringUtility.UrlCombine("/test1/", ""), "/test1/");
        }
    }
}
