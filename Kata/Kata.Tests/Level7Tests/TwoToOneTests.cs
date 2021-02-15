using Kata.Level7;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Tests.Level7Tests
{
    [TestFixture]
    public static class TwoToOneTests
    {

        [Test]
        [TestCase("aretheyhere", "yestheyarehere", "aehrsty")]
        [TestCase("loopingisfunbutdangerous", "lessdangerousthancoding", "abcdefghilnoprstu")]
        [TestCase("inmanylanguages", "theresapairoffunctions", "acefghilmnoprstuy")]
        public static void Longest_ReturnsSortedDisctinctLettersFromBothStrings(string s1, string s2, string result)
        {
            Assert.AreEqual(result, SolutionsLevel7.Longest(s1, s2));
        }
    }
}
