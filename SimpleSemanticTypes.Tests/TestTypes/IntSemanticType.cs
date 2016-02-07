namespace SimpleSemanticTypes.Tests.TestTypes
{
    public class IntSemanticType : ArithmeticSemanticType<int>
    {
        public IntSemanticType(int typeToWrap) : base(typeToWrap)
        {
        }
    }
}
