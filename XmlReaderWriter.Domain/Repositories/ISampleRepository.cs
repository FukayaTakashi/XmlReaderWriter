using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.Repositories
{
    public interface ISampleRepository
    {
        public SampleEntity[] Read(string filePath);
        public void Write(string filePath, SampleEntity[] sampleEntities);
    }
}
