using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using XmlReaderWriter.Domain.Entities;
using XmlReaderWriter.Domain.Repositories;

namespace XmlReaderWriter.Infrastructure.Fake
{
    internal sealed class NameReaderWriterFake : INameRepository
    {
        public NameEntity Read(string filePath)
        {
            return new NameEntity(
                new Dictionary<string, string>
                {
                    { "Key1Test1", "Variable1" },
                    { "Key1Test2", "Variable2" },
                    { "Key1Test3", "Variable3" },
                    { "Key1Test4", "Variable4" },
                    { "Key1Test5", "Variable5" }
                },
                new Dictionary<string, string>
                {
                    { "Key2Test1", "Variable6" },
                    { "Key2Test2", "Variable7" },
                    { "Key2Test3", "Variable8" },
                    { "Key2Test4", "Variable9" },
                    { "Key2Test5", "Variable10" }
                });
        }

        public void Write(string filePath, NameEntity nameEntity)
        {
            byte[] jsonUtf8Bytes;
            var serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(nameEntity, serializerOptions);
            File.WriteAllBytes(filePath, jsonUtf8Bytes);
        }
    }
}
