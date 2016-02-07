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
    }
}
