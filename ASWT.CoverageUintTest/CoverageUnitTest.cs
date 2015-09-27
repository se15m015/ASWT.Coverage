using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASWT.CoverageLib;

namespace ASWT.CoverageUintTest
{
    [TestClass]
    public class CoverageUnitTest
    {
        [TestMethod]
        public void TC1_1_a_is_10_and_b_is_5_shall_be_30_Blue()
        {
            var sut = Coverage.Run(10, 5);
            Assert.AreEqual(30, sut);
        }

        [TestMethod]
        public void TC2_1_a_is_120_and_b_is_5_shall_be_100_Green()
        {
            var sut = Coverage.Run(120, 5);
            Assert.AreEqual(100, sut);
        }

        [TestMethod]
        public void TC3_1_a_is_10_and_b_is_50_shall_be_60_Red()
        {
            var sut = Coverage.Run(10, 50);
            Assert.AreEqual(60, sut);
        }

        [TestMethod]
        public void TC4_1_a_is_10_and_b_is_99_shall_be_100_Yellow()
        {
            var sut = Coverage.Run(10, 99);
            Assert.AreEqual(100, sut);
        }

        [TestMethod]
        public void TC5_1_a_is_10_and_b_is_5_shall_be_30_Blue()
        {
            var sut = Coverage.Run(10, 19);
            Assert.AreEqual(100, sut);
        }
    }
}
