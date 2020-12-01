using XmlReaderWriter.Domain.Repositories;
using XmlReaderWriter.Infrastructure.Fake;

namespace XmlReaderWriter.Infrastructure
{
    public static class Factories
    {
        public static ISampleRepository CreateSampleReaderWriter()
        {
            return new SampleReaderWriterFake();

        }

        public static INameRepository CreateNameReaderWriter()
        {
            return new NameReaderWriterFake();
        }

        public static IUpdateDataRepository CreateUpdateReaderWrite()
        {
            return new UpdateDataReaderWriterFake();
        }
    }
}
