namespace SimpleSemanticTypes.Tests.TestTypes
{
    public class StringSemanticType : BaseSemanticType<string>
    {
        public StringSemanticType(string typeToWrap) : base(typeToWrap)
        {
        }
    }
}
