using Kata.Level6;
using NUnit.Framework;

namespace Kata.Tests.Level6Tests
{
    internal class IpValidatorTests
    {
        [Test]
        public void TestCases()
        {
            Assert.AreEqual(true, SolutionsLevel6.IsValidIP("0.0.0.0"));
            Assert.AreEqual(true, SolutionsLevel6.IsValidIP("12.255.56.1"));
            Assert.AreEqual(true, SolutionsLevel6.IsValidIP("137.255.156.100"));

            Assert.AreEqual(false, SolutionsLevel6.IsValidIP(""));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("abc.def.ghi.jkl"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("123.456.789.0"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.56"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.56.00"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.56.7.8"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.256.78"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("1234.34.56"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("pr12.34.56.78"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.56.78sf"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.56 .1"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("12.34.56.-1"));
            Assert.AreEqual(false, SolutionsLevel6.IsValidIP("123.045.067.089"));
        }
    }
}