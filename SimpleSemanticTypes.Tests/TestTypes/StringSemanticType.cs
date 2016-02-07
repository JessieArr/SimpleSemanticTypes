namespace SimpleSemanticTypes.Tests.TestTypes
{
    public class StringSemanticType : SemanticType<string>
    {
        public StringSemanticType(string typeToWrap) : base(typeToWrap)
        {
        }
    }
}
