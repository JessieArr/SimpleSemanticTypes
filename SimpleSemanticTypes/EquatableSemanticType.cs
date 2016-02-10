using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSemanticTypes
{
    // We inherit the implementations of Equals and GetHashCode from our base class.
#pragma warning disable 0660, 0661
    public class EquatableSemanticType<T> : SemanticType<T>, IEquatable<T>
    {
#pragma warning restore 0660, 0661

        public EquatableSemanticType(T typeToWrap) : base(typeToWrap)
        {
        }

        public static bool operator ==(EquatableSemanticType<T> typeA, T typeB)
        {
            if (object.ReferenceEquals(typeA, null))
            {
                return object.ReferenceEquals(typeB, null);
            }
            else
            {
                if (object.ReferenceEquals(typeB, null))
                {
                    return false;
                }
            }

            return typeA.Value.Equals(typeB);
        }

        public static bool operator ==(T typeA, EquatableSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null))
            {
                return object.ReferenceEquals(typeB, null);
            }
            else
            {
                if (object.ReferenceEquals(typeB, null))
                {
                    return false;
                }
            }

            return typeA.Equals(typeB.Value);
        }

        public static bool operator !=(EquatableSemanticType<T> typeA, T typeB)
        {
            if (object.ReferenceEquals(typeA, null))
            {
                return !object.ReferenceEquals(typeB, null);
            }
            else
            {
                if (object.ReferenceEquals(typeB, null))
                {
                    return true;
                }
            }

            return !typeA.Value.Equals(typeB);
        }

        public static bool operator !=(T typeA, EquatableSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null))
            {
                return !object.ReferenceEquals(typeB, null);
            }
            else
            {
                if (object.ReferenceEquals(typeB, null))
                {
                    return true;
                }
            }

            return !typeA.Equals(typeB.Value);
        }

        public bool Equals(T other)
        {
            return Value.Equals(other);
        }
    }
}
