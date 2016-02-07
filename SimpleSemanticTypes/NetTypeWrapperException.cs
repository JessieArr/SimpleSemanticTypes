using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSemanticTypes
{
    public class NetTypeWrapperException : Exception
    {
        public NetTypeWrapperException(string message) : base(message)
        {

        }

        public NetTypeWrapperException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
