using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.Level7;
using NUnit.Framework;

namespace Kata.Tests.Level7Tests
{
    public class AddBinaryTest
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual("11", SolutionsLevel7.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }
    }
}