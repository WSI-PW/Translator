using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Database.DatabaseFactory
{
    public class BruteforceDatabaseFactory<T> : DatabaseFactory<T>
        where T : class, IDatabase, new()
    {
        public override T CreateDatabase(string[] filepaths)
        {
            T database = new T();
            foreach (string path in filepaths)
            {
                TextReader reader = new StreamReader(path);
                string content = reader.ReadToEnd();
                string[] words = content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach(string word in words)
                {
                    string[] pair = word.Split(';');
                    database.Insert(pair[1], pair[0], 0.1);
                }
            }

            return database;
        }
    }
}
