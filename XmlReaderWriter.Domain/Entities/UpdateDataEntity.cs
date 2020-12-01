namespace XmlReaderWriter.Domain.Entities
{
    public sealed class UpdateDataEntity
    {
        public UpdateDataEntity()
        {
        }

        public UpdateDataEntity(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; }
        public string Value { get; }
    }
}