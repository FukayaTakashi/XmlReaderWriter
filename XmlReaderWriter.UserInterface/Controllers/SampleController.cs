using XmlReaderWriter.Domain.Entities;
using XmlReaderWriter.Domain.Repositories;
using XmlReaderWriter.Domain.StaticValues;
using XmlReaderWriter.Infrastructure;

namespace XmlReaderWriter.UserInterface.Controllers
{
    public class SampleController
    {
        private NameRepository _nameRepository;
        private SampleRepository _sampleRepository;
        private UpdateDataRepository _updateDataRepository;

        public SampleController() :
            this(
                Factories.CreateNameReaderWriter(),
                Factories.CreateSampleReaderWriter(),
                Factories.CreateUpdateReaderWrite())
        {

        }

        public SampleController(
            INameRepository nameRepository,
            ISampleRepository sampleRepository,
            IUpdateDataRepository updateDataRepository)
        {
            _nameRepository = new NameRepository(nameRepository);
            _sampleRepository = new SampleRepository(sampleRepository);
            _updateDataRepository = new UpdateDataRepository(updateDataRepository);
        }

        public void Run(string namePath, string samplePath, string updateDataPath)
        {
            NameEntity nameEntity = _nameRepository.Read(namePath);
            _nameRepository.Write(namePath, nameEntity);
            Names.Initialize(nameEntity);
            SampleEntity[] sampleEntities = _sampleRepository.Read(samplePath);
            _sampleRepository.Write(samplePath, sampleEntities);
            UpdateDataEntity[] updateDataEntities = _updateDataRepository.Read(updateDataPath);
            _updateDataRepository.Write(updateDataPath, updateDataEntities);

        }
    }
}
