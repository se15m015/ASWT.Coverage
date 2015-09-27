using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASWT.CoverageLib;

namespace ASWT.CoverageUintTest
{
    [TestClass]
    public class CoverageUnitTest
    {
        [TestMethod]
        public void TC1_1()
        {
            var sut = Coverage.Run(10, 5);
            Assert.AreEqual(30, sut);
        }

        [TestMethod]
        public void TC1_2()
        {
            var sut = Coverage.Run(120, 5);
            Assert.AreEqual(100, sut);
        }

        [TestMethod]
        public void TC1_3()
        {
            var sut = Coverage.Run(10, 50);
            Assert.AreEqual(60, sut);
        }

        [TestMethod]
        public void TC1_4()
        {
            var sut = Coverage.Run(10, 99);
            Assert.AreEqual(100, sut);
        }

        [TestMethod]
        public void TC1_5()
        {
            var sut = Coverage.Run(10, 89);
            Assert.AreEqual(99, sut);
        }
    }
}
