using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace SimpleSemanticTypes.Tests
{
    [TestFixture]
    public class ComparableSemanticTypeTests
    {
        private string _TestString = "A";
        private string _OtherTestString = "B";
        private int _TestInt = 5;
        private int _OtherTestInt = 12;

        [Test]
        public void CompareTo_WorksForInts()
        {
            var _SUT1 = new ComparableSemanticType<int>(_TestInt);
            var _SUT2 = new ComparableSemanticType<int>(_OtherTestInt);

            Assert.That(_SUT1.CompareTo(_SUT2) == -1);
            Assert.That(_SUT1.CompareTo(_SUT1) == 0);
            Assert.That(_SUT2.CompareTo(_SUT1) == 1);
        }

        [Test]
        public void CompareTo_WorksForStrings()
        {
            var _SUT1 = new ComparableSemanticType<string>(_TestString);
            var _SUT2 = new ComparableSemanticType<string>(_OtherTestString);

            Assert.That(_SUT1.CompareTo(_SUT2) == -1);
            Assert.That(_SUT1.CompareTo(_SUT1) == 0);
            Assert.That(_SUT2.CompareTo(_SUT1) == 1);
        }

        [Test]
        public void Sorting_Strings_WorksCorrectly()
        {
            var first = new ComparableSemanticType<string>("A");
            var second = new ComparableSemanticType<string>("B");
            var third = new ComparableSemanticType<string>("C");

            var list = new List<ComparableSemanticType<string>>()
            {
                second, third, first
            };
            list.Sort();

            Assert.That(list.IndexOf(first) == 0);
            Assert.That(list.IndexOf(second) == 1);
            Assert.That(list.IndexOf(third) == 2);
        }

        [Test]
        public void Sorting_Ints_WorksCorrectly()
        {
            var first = new ComparableSemanticType<int>(0);
            var second = new ComparableSemanticType<int>(1);
            var third = new ComparableSemanticType<int>(2);

            var list = new List<ComparableSemanticType<int>>()
            {
                second, third, first
            };
            list.Sort();

            Assert.That(list.IndexOf(first) == 0);
            Assert.That(list.IndexOf(second) == 1);
            Assert.That(list.IndexOf(third) == 2);
        }
    }
}
