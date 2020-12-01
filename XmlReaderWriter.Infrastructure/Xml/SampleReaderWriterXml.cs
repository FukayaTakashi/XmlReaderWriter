using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using XmlReaderWriter.Domain.Entities;
using XmlReaderWriter.Domain.Repositories;

namespace XmlReaderWriter.Infrastructure.Xml
{
    internal sealed class SampleReaderWriterXml : ISampleRepository
    {
        public SampleEntity[] Read(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Write(string filePath, SampleEntity[] sampleEntities)
        {
            var xmlSerializer = new XmlSerializer(typeof(SampleEntity[]));
            using var xmlString = new StreamWriter(filePath, false, Encoding.UTF8);
            xmlSerializer.Serialize(xmlString, sampleEntities);
        }
    }
}
