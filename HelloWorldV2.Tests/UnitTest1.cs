using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldV2;

namespace HelloWorldV2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
}
