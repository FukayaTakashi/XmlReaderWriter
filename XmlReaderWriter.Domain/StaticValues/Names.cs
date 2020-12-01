using System.Collections;
using System.Collections.Generic;
using XmlReaderWriter.Domain.Entities;

namespace XmlReaderWriter.Domain.StaticValues
{
    public static class Names
    {
        private static Dictionary<string, string> _key1Names = new Dictionary<string, string>();
        private static Dictionary<string, string> _key2Names = new Dictionary<string, string>();

        public static void Initialize(NameEntity nameEntitiy)
        {
            lock (((ICollection)_key1Names).SyncRoot)
            {
                _key1Names = nameEntitiy.Key1Names;
            }
            lock (((ICollection)_key2Names).SyncRoot)
            {
                _key2Names = nameEntitiy.Key2Names;
            }
        }

        public static string GetName(string key1, string key2)
        {
            string hitName;

            lock (((ICollection)_key1Names).SyncRoot)
            {
                hitName = _key1Names.ContainsKey(key1) ? _key1Names[key1] : "";
            }
            if (hitName == "")
            {
                lock (((ICollection)_key2Names).SyncRoot)
                {
                    hitName = _key2Names.ContainsKey(key2) ? _key2Names[key2] : "";
                }
            }
            return hitName;
        }
    }
}
