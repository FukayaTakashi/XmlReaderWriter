using System;
using System.IO;
using System.Text.Json;
using XmlReaderWriter.Domain.Entities;
using XmlReaderWriter.Domain.Repositories;

namespace XmlReaderWriter.Infrastructure.Json
{
    internal sealed class NamesReaderWriteJson : INameRepository
    {
        public NameEntity Read(string filePath)
        {
            throw new NotImplementedException();
        }

        public void Write(string filePath, NameEntity nameEntities)
        {
            byte[] jsonUtf8Bytes;
            var serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(nameEntities, serializerOptions);
            File.WriteAllBytes(filePath, jsonUtf8Bytes);
        }
    }
}
