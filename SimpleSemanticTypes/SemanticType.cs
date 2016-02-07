using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSemanticTypes
{
    public class SemanticType<T> : IEquatable<SemanticType<T>>
    {
        public readonly T Value;
        public static string DefaultValidationMessage = "Wrapped " + typeof(T) + " value is not valid!";

        public SemanticType(T typeToWrap)
        {
            if (!ValueIsValid(typeToWrap))
            {
                var errorMessage = GetValidationFailureMessage(typeToWrap);
                throw new SimpleSemanticTypeException(errorMessage);
            }
            Value = typeToWrap;
        }

        #region Overridable Members

        protected virtual bool ValueIsValid(T value)
        {
            if (object.ReferenceEquals(value, null))
            {
                return false;
            }
            return true;
        }

        protected virtual string GetValidationFailureMessage(T value)
        {
            return DefaultValidationMessage;
        }

        #endregion

        #region == Operator Overloads

        public static bool operator ==(SemanticType<T> typeA, SemanticType<T> typeB)
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

            return typeA.Equals(typeB);
        }

        public static bool operator ==(SemanticType<T> typeA, T typeB)
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

        public static bool operator ==(T typeA, SemanticType<T> typeB)
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

        #endregion

        #region != Operator Overloads

        public static bool operator !=(SemanticType<T> typeA, SemanticType<T> typeB)
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

            return !typeA.Equals(typeB);
        }

        public static bool operator !=(SemanticType<T> typeA, T typeB)
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

        public static bool operator !=(T typeA, SemanticType<T> typeB)
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

        #endregion

        public bool Equals(SemanticType<T> other)
        {
            if (other == null)
            {
                return false;
            }

            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((SemanticType<T>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
