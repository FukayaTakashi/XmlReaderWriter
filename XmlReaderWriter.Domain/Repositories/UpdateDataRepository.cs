using System.IO;
using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.Repositories
{
    public sealed class UpdateDataRepository
    {
        private IUpdateDataRepository _updateDataRepository;

        public UpdateDataRepository(IUpdateDataRepository updateDataRepository)
        {
            _updateDataRepository = updateDataRepository;
        }

        public UpdateDataEntity[] Read(string filePath)
        {
            return _updateDataRepository.Read(filePath);
        }
        public void Write(string filePath, UpdateDataEntity[] updateDataEntities)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            _updateDataRepository.Write(filePath, updateDataEntities);
        }
    }
}
