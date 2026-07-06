using FactoryMethodPatternExample;

namespace FactoryMethodPatternExample
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}