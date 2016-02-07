using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSemanticTypes
{
    public class ArithmeticSemanticType<T> : BaseSemanticType<T>
    {
        public ArithmeticSemanticType(T typeToWrap) : base(typeToWrap)
        {
        }

        #region + Operator Overloads

        internal static string NullAdditionArgumentErrorMessage = "Operand to operator '+' was null.";

        public static T operator +(ArithmeticSemanticType<T> typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value + (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetAdditionTypeErrorMessage(typeA.Value.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator +(ArithmeticSemanticType<T> typeA, T typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value + (dynamic)typeB;
            }
            catch (Exception ex)
            {
                var errorMessage = GetAdditionTypeErrorMessage(typeA.Value.GetType(), typeB.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator +(T typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA + (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetAdditionTypeErrorMessage(typeA.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        private static string GetAdditionTypeErrorMessage(Type typeA, Type typeB)
        {
            return "Operator '+' not implemented for operands of type " + typeA.Name + " and " + typeB.Name + ".";
        }

        #endregion

        #region  - Operator Overloads

        internal static string NullSubtractionArgumentErrorMessage = "Operand to operator '-' was null.";

        public static T operator -(ArithmeticSemanticType<T> typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value - (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetSubtractionTypeErrorMessage(typeA.Value.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator -(ArithmeticSemanticType<T> typeA, T typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value - (dynamic)typeB;
            }
            catch (Exception ex)
            {
                var errorMessage = GetSubtractionTypeErrorMessage(typeA.Value.GetType(), typeB.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator -(T typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA - (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetSubtractionTypeErrorMessage(typeA.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        private static string GetSubtractionTypeErrorMessage(Type typeA, Type typeB)
        {
            return "Operator '-' not implemented for operands of type " + typeA.Name + " and " + typeB.Name + ".";
        }

        #endregion

        #region  * Operator Overloads

        internal static string NullMultiplicationArgumentErrorMessage = "Operand to operator '*' was null.";

        public static T operator *(ArithmeticSemanticType<T> typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value * (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetMultiplicationTypeErrorMessage(typeA.Value.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator *(ArithmeticSemanticType<T> typeA, T typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value * (dynamic)typeB;
            }
            catch (Exception ex)
            {
                var errorMessage = GetMultiplicationTypeErrorMessage(typeA.Value.GetType(), typeB.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator *(T typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA * (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetMultiplicationTypeErrorMessage(typeA.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        private static string GetMultiplicationTypeErrorMessage(Type typeA, Type typeB)
        {
            return "Operator '*' not implemented for operands of type " + typeA.Name + " and " + typeB.Name + ".";
        }

        #endregion

        #region / Operator Overloads

        internal static string NullDivisionArgumentErrorMessage = "Operand to operator '/' was null.";

        public static T operator /(ArithmeticSemanticType<T> typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value / (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetDivisionTypeErrorMessage(typeA.Value.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator /(ArithmeticSemanticType<T> typeA, T typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA.Value / (dynamic)typeB;
            }
            catch (Exception ex)
            {
                var errorMessage = GetDivisionTypeErrorMessage(typeA.Value.GetType(), typeB.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        public static T operator /(T typeA, ArithmeticSemanticType<T> typeB)
        {
            if (object.ReferenceEquals(typeA, null) || object.ReferenceEquals(typeB, null))
            {
                throw new NullReferenceException(NullAdditionArgumentErrorMessage);
            }

            try
            {
                return (dynamic)typeA / (dynamic)typeB.Value;
            }
            catch (Exception ex)
            {
                var errorMessage = GetDivisionTypeErrorMessage(typeA.GetType(), typeB.Value.GetType());
                throw new SimpleSemanticTypeException(errorMessage, ex);
            }
        }

        private static string GetDivisionTypeErrorMessage(Type typeA, Type typeB)
        {
            return "Operator '/' not implemented for operands of type " + typeA.Name + " and " + typeB.Name + ".";
        }

        #endregion
    }
}
