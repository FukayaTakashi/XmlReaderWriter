using System.IO;
using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.Repositories
{
    public sealed class NameRepository
    {
        private INameRepository _nameRepository;

        public NameRepository(INameRepository nameRepository)
        {
            _nameRepository = nameRepository;
        }

        public NameEntity Read(string filePath)
        {
            return _nameRepository.Read(filePath);
        }

        public void Write(string filePath, NameEntity nameEntity)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            _nameRepository.Write(filePath, nameEntity);
        }
    }
}
