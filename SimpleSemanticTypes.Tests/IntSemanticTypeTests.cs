using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;
using SimpleSemanticTypes.Tests.TestTypes;

namespace SimpleSemanticTypes.Tests
{
    [TestFixture]
    public class IntSemanticTypeTests
    {
        private int _TestInt = 5;
        private int _OtherTestInt = 12;

        [Test]
        public void Constructor_Succeeds()
        {
            var _SUT = new IntSemanticType(_TestInt);
        }

        [Test]
        public void Addition_Succeeds()
        {
            var _SUT1 = new IntSemanticType(_TestInt);
            var _SUT2 = new IntSemanticType(_OtherTestInt);

            Assert.That(_SUT1 + _TestInt == _TestInt + _TestInt);
            Assert.That(_TestInt + _SUT1 == _TestInt + _TestInt);
            Assert.That(_SUT1 + _SUT2 == _TestInt + _OtherTestInt);
        }

        [Test]
        public void Addition_Null_HandledCorrectly()
        {
            var _SUT1 = new IntSemanticType(_TestInt);
            IntSemanticType _nullIntSemanticType = null;

            Assert.Throws<NullReferenceException>(() =>
            {
                var result = _SUT1 + _nullIntSemanticType;
            });
            Assert.Throws<NullReferenceException>(() =>
            {
                var result = _nullIntSemanticType + _SUT1;
            });
        }
    }
}
