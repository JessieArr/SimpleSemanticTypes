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
    public class EquatableSemanticTypeTests
    {
        private int _TestInt = 5;
        private int _OtherTestInt = 12;
        private string _TestString = "TestString";
        private string _OtherTestString = "OtherTestString";

        [Test]
        public void Equals_WorksForInts()
        {
            var _SUT = new EquatableSemanticType<int>(_TestInt);
            Assert.That(_SUT.Equals(_TestInt));
            Assert.False(_SUT.Equals(_OtherTestInt));
        }

        [Test]
        public void Equals_WorksForStrings()
        {
            var _SUT = new EquatableSemanticType<string>(_TestString);
            Assert.That(_SUT.Equals(_TestString));
            Assert.False(_SUT.Equals(_OtherTestString));
        }
    }
}
