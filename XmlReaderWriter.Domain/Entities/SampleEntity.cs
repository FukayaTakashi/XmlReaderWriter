using System.Runtime.Serialization;
using XmlReaderWriter.Domain.StaticValues;

namespace XmlReaderWriter.Domain.Entities
{
#if SAMPLE_LIST_IS_XML
    [DataContract]
#endif
    public sealed class SampleEntity
    {
        public SampleEntity()
        {
        }

        public SampleEntity(string key1, string key2, ValueType valueType, string value = "")
        {
            Key1 = key1;
            Key2 = key2;
            ValueType = valueType;
            Name = Names.GetName(key1, key2);
            Value = value;
        }

#if SAMPLE_LIST_IS_XML
        [DataMember]
#endif
        public string Key1 { get; set; }
#if SAMPLE_LIST_IS_XML
        [DataMember]
#endif
        public string Key2 { get; set; }
#if SAMPLE_LIST_IS_XML
        [DataMember]
#endif
        public ValueType ValueType { get; set; }
#if SAMPLE_LIST_IS_XML
        [IgnoreDataMember]
#endif
        public string Name { get; set; }
#if SAMPLE_LIST_IS_XML
        [DataMember]
#endif
        public string Value { get; set; }
    }

    public enum ValueType
    {
        Keep = 0,
        Data1,
        Data2
    }
}
