namespace SimpleSemanticTypes.Tests.TestTypes
{
    public class StringSemanticType : EquatableSemanticType<string>
    {
        public StringSemanticType(string typeToWrap) : base(typeToWrap)
        {
        }
    }
}
