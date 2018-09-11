using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.Level6;
using NUnit.Framework;

namespace Kata.Tests.Level6Tests
{
    [TestFixture]
    public class TowerBuilderTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", SolutionsLevel6.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", SolutionsLevel6.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", SolutionsLevel6.TowerBuilder(3)));
        }
    }
}