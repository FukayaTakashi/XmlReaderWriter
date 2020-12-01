using System;
using System.Collections;
using System.Collections.Generic;
using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.StaticValues
{
    public static class Samples
    {
        private static List<SampleEntity> _entities = new List<SampleEntity>();

        public static void Initialize(SampleEntity[] entities)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                _entities.Clear();
                _entities.AddRange(entities);
            }
        }

        public static void SetNamedData(List<Tuple<string, string>> items)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                SampleEntity hitEntity;
                foreach (Tuple<string, string> item in items)
                {
                    hitEntity = _entities.Find(x => x.Key1 == item.Item1);
                    hitEntity.Value = item.Item2;
                }
            }
        }
    }
}
