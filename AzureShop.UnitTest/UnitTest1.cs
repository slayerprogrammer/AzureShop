using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureShop.UnitTest
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ShouldPass()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_ShoudFail()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_Pass2()
        {
            Assert.Pass();
        }
    }
}
