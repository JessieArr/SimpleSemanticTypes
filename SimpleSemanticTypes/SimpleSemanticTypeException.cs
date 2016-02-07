using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSemanticTypes
{
    public class SimpleSemanticTypeException : Exception
    {
        public SimpleSemanticTypeException(string message) : base(message)
        {

        }

        public SimpleSemanticTypeException(string message, Exception exception) : base(message, exception)
        {

        }
    }
}
