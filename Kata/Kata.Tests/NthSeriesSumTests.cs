using System;
using System.Globalization;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class NthSeriesSumTests
    {
        public static string solution(int n)
        {
            if (n == 0) return "0.00";
            double s = 1.0;
            int i = 1;
            double den = 4.0;
            while (i < n)
            {
                s = s + (1 / den);
                i++;
                den += 3.0;
            }
            return string.Format(CultureInfo.InvariantCulture, "{0:0.00}", s);
        }

        public static void RandomTests()
        {
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = r.Next(0, 100);
                Console.WriteLine("Random Nth with n: " + x);
                Assert.AreEqual(NthSeriesSumTests.solution(x), NthSeriesSum.SeriesSum(x));
            }
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("0.00", NthSeriesSum.SeriesSum(0));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("1.77", NthSeriesSum.SeriesSum(9));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("1.94", NthSeriesSum.SeriesSum(15));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("2.26", NthSeriesSum.SeriesSum(39));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual("2.40", NthSeriesSum.SeriesSum(58));
        }

        [Test]
        public void Test6()
        {
            NthSeriesSumTests.RandomTests();
        }
    }
}