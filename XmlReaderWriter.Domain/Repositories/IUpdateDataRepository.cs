using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.Repositories
{
    public interface IUpdateDataRepository
    {
        public UpdateDataEntity[] Read(string filePath);
        public void Write(string filePath, UpdateDataEntity[] updateDataEntities);
    }
}
