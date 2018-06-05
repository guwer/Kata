using System;
using Kata.Level7;
using NUnit.Framework;

namespace Kata.Tests.Level7Tests
{
    [TestFixture]
    public class SquareTest
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual(false, SolutionsLevel7.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(true, SolutionsLevel7.IsSquare(0), "0 is a square number (0 * 0)");
            Assert.AreEqual(false, SolutionsLevel7.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, SolutionsLevel7.IsSquare(4), "4 is a square number (2 * 2)");
            Assert.AreEqual(true, SolutionsLevel7.IsSquare(25), "25 is a square number (5 * 5)");
            Assert.AreEqual(false, SolutionsLevel7.IsSquare(26), "26 isn't a square number");
        }

        [Test]
        public static void ShouldWorkForRandomSquareNumbers()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(20) + 1;
                Assert.AreEqual(true, SolutionsLevel7.IsSquare(num * num), $"{num * num} is a square number ({num} * {num})");
            }
        }

        [Test]
        public static void ShouldWorkForRandomNumbers()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(1000000) + 1;
                Assert.AreEqual(IsSquare(num), SolutionsLevel7.IsSquare(num), IsSquare(num) ? num + " is a square!" : num + " isn't a square!");
            }
        }

        private static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}