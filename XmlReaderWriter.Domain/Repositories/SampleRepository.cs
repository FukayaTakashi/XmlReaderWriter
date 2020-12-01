using System.IO;
using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.Repositories
{
    public sealed class SampleRepository
    {
        private ISampleRepository _sampleRepository;

        public SampleRepository(ISampleRepository sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }

        public SampleEntity[] Read(string filePath)
        {
            return _sampleRepository.Read(filePath);
        }

        public void Write(string filePath, SampleEntity[] sampleEntities)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            _sampleRepository.Write(filePath, sampleEntities);
        }
    }
}
