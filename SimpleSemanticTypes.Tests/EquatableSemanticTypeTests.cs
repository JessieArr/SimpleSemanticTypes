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

        [Test]
        public void Equals_Null_Succeeds()
        {
            EquatableSemanticType<TestClass> _SUT1 = null;
            EquatableSemanticType<string> _SUT2 = null;
            EquatableSemanticType<int> _SUT3 = null;

            Assert.That(_SUT1 == null);
            Assert.That(null == _SUT1);
            Assert.That(_SUT2 == null);
            Assert.That(null == _SUT2);
            Assert.That(_SUT3 == null);
            Assert.That(null == _SUT3);
        }

        [Test]
        public void NotEquals_Null_Succeeds()
        {
            EquatableSemanticType<TestClass> _SUT1 = null;
            EquatableSemanticType<string> _SUT2 = null;
            EquatableSemanticType<int> _SUT3 = null;

            Assert.False(_SUT1 != null);
            Assert.False(null != _SUT1);
            Assert.False(_SUT2 != null);
            Assert.False(null != _SUT2);
            Assert.False(_SUT3 != null);
            Assert.False(null != _SUT3);

        }

        [Test]
        public void StaticClass_IsNull_IsTrueForNullReferences()
        {
            EquatableSemanticType<TestClass> _SUT1 = null;
            EquatableSemanticType<string> _SUT2 = null;
            EquatableSemanticType<int> _SUT3 = null;

            Assert.That(SemanticType.IsNull(_SUT1));
            Assert.That(SemanticType.IsNull(_SUT2));
            Assert.That(SemanticType.IsNull(_SUT3));
        }
    }
}
