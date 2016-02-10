using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSemanticTypes
{
    public class ComparableSemanticType<T> : EquatableSemanticType<T>, IComparable<ComparableSemanticType<T>>
        where T : IComparable<T>
    {
        public ComparableSemanticType(T typeToWrap) : base(typeToWrap)
        {
        }

        #region IComparable<SemanticType<T> implementation

        public int CompareTo(ComparableSemanticType<T> other)
        {
            return Value.CompareTo(other.Value);
        }

        #endregion
    }
}
