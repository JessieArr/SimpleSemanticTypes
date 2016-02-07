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
    public class ArithmeticSemanticTypeTests
    {
        [Test]
        public void Addition_NonArithmeticWrappedType_Throws()
        {
            var testClass1 = new TestClass();
            var _SUT1 = new ArithmeticSemanticType<TestClass>(testClass1);
            var _SUT2 = new ArithmeticSemanticType<TestClass>(new TestClass());

            Assert.Throws<SimpleSemanticTypeException>(() =>
            {
                var result = _SUT1 + _SUT2;
            });
            Assert.Throws<SimpleSemanticTypeException>(() =>
            {
                var result = _SUT1 + testClass1;
            });
            Assert.Throws<SimpleSemanticTypeException>(() =>
            {
                var result = testClass1 + _SUT1;
            });
        }

        [Test]
        public void Addition_ReferenceTypeNull_HandledCorrectly()
        {
            var _SUT1 = new ArithmeticSemanticType<TestClass>(new TestClass());

            Assert.Throws<NullReferenceException>(() =>
            {
                var result = _SUT1 + (ArithmeticSemanticType<TestClass>)null;
            });
            Assert.Throws<NullReferenceException>(() =>
            {
                var result = (ArithmeticSemanticType<TestClass>)null + _SUT1;
            });

            Assert.Throws<NullReferenceException>(() =>
            {
                var result = _SUT1 + (TestClass)null;
            });
            Assert.Throws<NullReferenceException>(() =>
            {
                var result = (TestClass)null + _SUT1;
            });
        }
    }
}
