using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.Repositories
{
    public interface INameRepository
    {
        public NameEntity Read(string filePath);
        public void Write(string filePath, NameEntity nameEntity);
    }
}
