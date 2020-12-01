using System.Collections.Generic;

namespace XmlReaderWriter.Domain.Entities
{
    public sealed class NameEntity
    {
        public NameEntity(Dictionary<string, string> key1Names, Dictionary<string, string> key2Names)
        {
            Key1Names = key1Names;
            Key2Names = key2Names;
        }

        public Dictionary<string, string> Key1Names { get; }
        public Dictionary<string, string> Key2Names { get; }
    }
}
