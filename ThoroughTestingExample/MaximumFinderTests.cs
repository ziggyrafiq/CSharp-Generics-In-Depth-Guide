//The File Name is MaximumFinderTests.cs
using MeaningfulConstraintExample;
using NUnit.Framework;

namespace ThoroughTestingExample;


    [TestFixture]
    public class MaximumFinderTests
    {
        [Test]
        public void FindMaximum_Integers_Success()
        {
            MaximumFinder finder = new MaximumFinder();
            List<int> intList = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            int result = finder.FindMaximum(intList);
            Assert.Equals(9, result);
        }

        [Test]
        public void FindMaximum_Strings_Success()
        {
            MaximumFinder finder = new MaximumFinder();
            List<string> stringList = new List<string> { "apple", "banana", "orange" };
            string result = finder.FindMaximum(stringList);
            Assert.Equals("orange", result);
        }

        [Test]
        public void FindMaximum_EmptyCollection_ThrowsException()
        {
            MaximumFinder finder = new MaximumFinder();
            List<int> emptyList = new List<int>();
            Assert.Throws<InvalidOperationException>(() => finder.FindMaximum(emptyList));
        }

        [Test]
        public void FindMaximum_NullCollection_ThrowsException()
        {
            MaximumFinder finder = new MaximumFinder();
            Assert.Throws<ArgumentNullException>(() => finder.FindMaximum<int>(null));
        }
    }

