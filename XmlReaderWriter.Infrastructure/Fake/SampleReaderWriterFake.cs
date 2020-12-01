using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using XmlReaderWriter.Domain.Entities;
using XmlReaderWriter.Domain.Repositories;

namespace XmlReaderWriter.Infrastructure.Fake
{
    internal sealed class SampleReaderWriterFake : ISampleRepository
    {
        public SampleEntity[] Read(string filePath)
        {
            return new SampleEntity[] {
                new SampleEntity("Key1Test1", "Key2Test1", ValueType.Data1, "aaaa"),
                new SampleEntity("Key1Test2", "Key2Test2", ValueType.Data1, "bbbb"),
                new SampleEntity("Key1Test3", "Key2Test3", ValueType.Data2, "cccc"),
                new SampleEntity("Key1Test4", "Key2Test4", ValueType.Data2, "dddd"),
                new SampleEntity("Key1Test5", "Key2Test5", ValueType.Keep, "eeee")
            };
        }

        public void Write(string filePath, SampleEntity[] sampleEntities)
        {
            SampleEntityXmlSerializer serializeClass = new SampleEntityXmlSerializer
            {
                sampleEntities = sampleEntities
            };


            var xmlSerializer = new XmlSerializer(typeof(SampleEntityXmlSerializer));
            using var xmlString = new StreamWriter(filePath, false, Encoding.UTF8);
            xmlSerializer.Serialize(xmlString, serializeClass);
        }

    }
    [DataContract(Namespace = "", Name = "Sample")]
    public class SampleEntityXmlSerializer
    {
        [DataMember]
        public SampleEntity[] sampleEntities;
    }
}
