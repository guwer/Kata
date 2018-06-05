using System;
using System.Linq;
using System.Text;
using Kata.Level7;
using NUnit.Framework;

namespace Kata.Tests.Level7Tests
{
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual("sihT si na !elpmaxe", SolutionsLevel7.ReverseWords("This is an example!"));
        }

        [Test]
        public void QuickBrownFox()
        {
            Assert.AreEqual("ehT kciuq nworb xof spmuj revo eht yzal .god", SolutionsLevel7.ReverseWords("The quick brown fox jumps over the lazy dog."));
        }

        [Test]
        public void OneWord()
        {
            Assert.AreEqual("elppa", SolutionsLevel7.ReverseWords("apple"));
        }

        [Test]
        public void DoubleSpaces()
        {
            Assert.AreEqual("elbuod  decaps  sdrow", SolutionsLevel7.ReverseWords("double  spaced  words"));
        }

        private static Random rnd = new Random();

        private static string solution(string str) => String.Join(" ", Enumerable.Reverse(String.Concat(Enumerable.Reverse(str.ToCharArray())).Split(' ')));

        [Test, Description("Random Tests (100 assertions)")]
        public void RandomTests()
        {
            const int Tests = 100;

            for (int i = 0; i < Tests; ++i)
            {
                StringBuilder sb = new StringBuilder(50);
                for (int j = 0; j < 50; ++j)
                {
                    sb.Append((rnd.Next(0, 10) == 0) ? ' ' : (char)rnd.Next(97, 123));
                }
                string test = sb.ToString().Trim();

                string expected = solution(test);
                string actual = SolutionsLevel7.ReverseWords(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}