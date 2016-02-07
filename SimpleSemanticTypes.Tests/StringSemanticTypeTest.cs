using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Api;
using SimpleSemanticTypes.Tests.TestTypes;

namespace SimpleSemanticTypes.Tests
{
    [TestFixture]
    public class StringSemanticTypeTest
    {
        public string _TestString = "TestString";

        [Test]
        public void Constructor_Succeeds()
        {
            var _SUT = new StringSemanticType(_TestString);
        }

        [Test]
        public void EqualityOperators_WorkCorrectly()
        {
            var _SUT = new StringSemanticType(_TestString);
            StringSemanticType _NullStringSemanticType = null;
            string _NullString = null;

            Assert.That(_SUT == _TestString);
            Assert.False(_SUT != _TestString);
            Assert.False(_SUT == _NullStringSemanticType);
            Assert.True(_SUT != _NullStringSemanticType);
            Assert.True(_NullStringSemanticType == _NullString);
            Assert.False(_NullStringSemanticType != _NullString);
            Assert.False(_SUT == _NullString);
            Assert.That(_SUT != _NullString);

            Assert.False(_NullString == _SUT);
            Assert.That(_NullString != _SUT);
            Assert.False(_NullStringSemanticType == _SUT);
            Assert.That(_NullStringSemanticType != _SUT);
            Assert.That(_TestString == _SUT);
            Assert.False(_TestString != _SUT);
            Assert.False(_TestString == _NullStringSemanticType);
            Assert.That(_TestString != _NullStringSemanticType);
        }

        [Test]
        public void Concatenation_Succeeds()
        {
            var _SUT = new StringSemanticType(_TestString);
            Assert.That(_SUT + _TestString == _TestString + _TestString);
        }
    }
}
