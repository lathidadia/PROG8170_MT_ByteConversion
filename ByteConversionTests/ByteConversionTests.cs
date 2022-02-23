using Kashish_Lathidadia_Mid_Term;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteConversionTests
{
    public class ByteConversionTests
    {
        [Test]
        public void ConvertMegabytesToGigabytesTest1()
        {
            //ARRANGE
            var MB = 5;
            //ACT
            double result = ByteConversion.MegabytesToBytes(MB);
            //ASSERT
            Assert.AreEqual(5242880, result);
        }

        [Test]
        public void ConvertMegabytesToGigabytesTest2()
        {
            //ARRANGE
            var MB = 2585;
            //ACT
            double result = ByteConversion.MegabytesToBytes(MB);
            //ASSERT
            Assert.AreEqual(2710568960, result);
        }

        [Test]
        public void ConvertGigabytesToMegabytesTest1()
        {
            //ARRANGE
            var GB = 15;
            //ACT
            double result = ByteConversion.GigabytesToMegabytes(GB);
            //ASSERT
            Assert.AreEqual(15360, result);
        }

        [Test]
        public void ConvertGigabytesToMegabytesTest2()
        {
            //ARRANGE
            var GB = 50;
            //ACT
            double result = ByteConversion.GigabytesToMegabytes(GB);
            //ASSERT
            Assert.AreEqual(51200, result);
        }

        [Test]
        public void ConvertTerabytesToGigabyresTest1()
        {
            //ARRANGE
            var TB = 7;
            //ACT
            double result = ByteConversion.TerabytesToGigabytes(TB);
            //ASSERT
            Assert.AreEqual(7168, result);
        }
    }
}
