using System.IO;
using System.Text;
using System.Xml.Serialization;
using XmlReaderWriter.Domain.Entities;
using XmlReaderWriter.Domain.Repositories;

namespace XmlReaderWriter.Infrastructure.Fake
{
    internal sealed class UpdateDataReaderWriterFake : IUpdateDataRepository
    {
        public UpdateDataEntity[] Read(string filePath)
        {
            return new UpdateDataEntity[]
            {
                new UpdateDataEntity("Variable1", "11111"),
                new UpdateDataEntity("Variable2", "22222"),
                new UpdateDataEntity("Variable3", "33333"),
                new UpdateDataEntity("Variable4", "44444"),
                new UpdateDataEntity("Variable5", "55555"),
                new UpdateDataEntity("Variable6", "66666"),
                new UpdateDataEntity("Variable7", "77777"),
                new UpdateDataEntity("Variable8", "88888"),
                new UpdateDataEntity("Variable9", "99999"),
                new UpdateDataEntity("Variable10", "10101")
            };
        }

        public void Write(string filePath, UpdateDataEntity[] updateDataEntities)
        {
            var xmlSerializer = new XmlSerializer(typeof(UpdateDataEntity[]));
            using var xmlString = new StreamWriter(filePath, false, Encoding.UTF8);
            xmlSerializer.Serialize(xmlString, updateDataEntities);
        }
    }
}
