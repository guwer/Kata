using Kata.Level7;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests
{
    [TestFixture]
    public class DescendingOrderTests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, SolutionsLevel7.DescendingOrder(0));
        }
    }
}
