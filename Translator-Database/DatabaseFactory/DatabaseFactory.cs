using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Translator_Database.DatabaseFactory;

namespace Translator_Database.DatabaseFactory
{
    public abstract class DatabaseFactory<T> : IDatabaseFactory<T>
        where T : class, IDatabase, new()
    {
        abstract public T CreateDatabase(string[] filepaths);

        public T LoadDatabase(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<(string, string, double)>));
            TextReader reader = new StreamReader(path);
            var records = (List<(string, string, double)>)serializer.Deserialize(reader);
            T database = new T();
            foreach(var record in records)
            {
                database.Insert(record.Item1, record.Item2, record.Item3);
            }
            return database;
        }
    }
}
