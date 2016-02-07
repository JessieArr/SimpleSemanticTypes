using System;
using NUnit.Framework;
using SimpleSemanticTypes.Tests.TestTypes;

namespace SimpleSemanticTypes.Tests
{
    [TestFixture]
    public class SemanticTypeTests
    {
        private string _TestString = "TestString";
        private string _OtherTestString = "OtherTestString";
        private int _TestInt = 5;
        private int _OtherTestInt = 12;
        private TestClass _TestClass = new TestClass();
        private TestClass _OtherTestClass = new TestClass();

        [Test]
        public void Constructor_SucceedsForString()
        {
            var _SUT = new SemanticType<string>(_TestString);
        }

        [Test]
        public void Constructor_SucceedsForInt()
        {
            var _SUT = new SemanticType<int>(_TestInt);
        }

        [Test]
        public void Constructor_SucceedsForClass()
        {
            var _SUT = new SemanticType<TestClass>(new TestClass());
        }

        [Test]
        public void Constructor_ThrowsForNull()
        {
            Exception caughtException = null;
            try
            {
                var _SUT = new SemanticType<string>(null);
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }

            Assert.NotNull(caughtException);
            Assert.That(caughtException.Message == SemanticType<string>.DefaultValidationMessage);
        }

        [Test]
        public void EqualityComparison_SameValue_WorksForString()
        {
            var _SUT1 = new SemanticType<string>(_TestString);
            var _SUT2 = new SemanticType<string>(_TestString);
            Assert.That(_SUT1 == _SUT2);
            Assert.False(_SUT1 != _SUT2);
        }

        [Test]
        public void EqualityComparison_DifferentValue_WorksForString()
        {
            var _SUT1 = new SemanticType<string>(_TestString);
            var _SUT2 = new SemanticType<string>(_OtherTestString);
            Assert.False(_SUT1 == _SUT2);
        }

        [Test]
        public void EqualityComparison_SameValue_WorksForInt()
        {
            var _SUT1 = new SemanticType<int>(_TestInt);
            var _SUT2 = new SemanticType<int>(_TestInt);
            Assert.That(_SUT1 == _SUT2);
            Assert.False(_SUT1 != _SUT2);
        }

        [Test]
        public void EqualityComparison_DifferentValue_WorksForInt()
        {
            var _SUT1 = new SemanticType<int>(_TestInt);
            var _SUT2 = new SemanticType<int>(_OtherTestInt);
            Assert.False(_SUT1 == _SUT2);
        }

        [Test]
        public void EqualityComparison_SameValue_WorksForClass()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            var _SUT2 = new SemanticType<TestClass>(_TestClass);
            Assert.That(_SUT1 == _SUT2);
            Assert.False(_SUT1 != _SUT2);
        }

        [Test]
        public void EqualityComparison_DifferentValue_WorksForClass()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            var _SUT2 = new SemanticType<TestClass>(_OtherTestClass);
            Assert.False(_SUT1 == _SUT2);
        }

        [Test]
        public void EqualityComparison_RightNull_WorksForClass()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            Assert.False(_SUT1 == (SemanticType<TestClass>)null);
            Assert.That(_SUT1 != (SemanticType<TestClass>)null);
        }

        [Test]
        public void EqualityComparison_LeftNull_WorksForClass()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            Assert.False((SemanticType<TestClass>)null == _SUT1);
            Assert.That((SemanticType<TestClass>)null != _SUT1);
        }

        [Test]
        public void GetHashCode_WorksForClass()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            var _SUT2 = new SemanticType<TestClass>(_TestClass);
            var _SUT3 = new SemanticType<TestClass>(_OtherTestClass);

            var hashcode1 = _SUT1.GetHashCode();
            var hashcode2 = _SUT2.GetHashCode();
            var hashcode3 = _SUT3.GetHashCode();

            Assert.That(hashcode1 == hashcode2);
            Assert.That(hashcode1 != hashcode3);
        }

        [Test]
        public void Equals_WorksForClass()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            var _SUT2 = new SemanticType<TestClass>(_TestClass);
            var _SUT3 = new SemanticType<TestClass>(_OtherTestClass);

            Assert.That(_SUT1.Equals(_SUT2));
            Assert.False(_SUT1.Equals(_SUT3));
        }

        [Test]
        public void Equals_False_ForNull()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);

            // IEquatable<SemanticType<T>>.Equals
            Assert.False(_SUT1.Equals((SemanticType<TestClass>)null));
        }

        [Test]
        public void ObjectEquals_CorrectlyHandlesNulls()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            var _SUT1Reference = _SUT1;
            var _SUT2 = new SemanticType<TestClass>(_TestClass);
            var _SUT3 = new SemanticType<TestClass>(_OtherTestClass);

            Assert.False(_SUT1.Equals((object)null));
            Assert.True(_SUT1.Equals((object)_SUT1Reference));
            Assert.False(_SUT1.Equals((object)new TestClass()));
            Assert.True(_SUT1.Equals((object)_SUT2));
            Assert.False(_SUT1.Equals((object)_SUT3));
        }

        [Test]
        public void ToString_Works_ForAllWrappedTypes()
        {
            var _SUT1 = new SemanticType<TestClass>(_TestClass);
            var _SUT2 = new SemanticType<string>(_TestString);
            var _SUT3 = new SemanticType<int>(_TestInt);

            Assert.That(_SUT1.ToString() == _TestClass.ToString());
            Assert.That(_SUT2.ToString() == _TestString);
            Assert.That(_SUT3.ToString() == _TestInt.ToString());
        }
    }
}
