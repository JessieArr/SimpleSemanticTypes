using System;

namespace SimpleSemanticTypes.Tests.TestTypes
{
    public class TestClass : IComparable<TestClass>
    {
        public int CompareTo(TestClass other)
        {
            throw new NotImplementedException();
        }
    }
}
