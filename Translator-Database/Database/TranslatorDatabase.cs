using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Translator_Database.DatabaseFactory
{
    public class TranslatorDatabase : IDatabase
    {
        Dictionary<string, Dictionary<string, double>> database;
        public TranslatorDatabase()
        {
            database = new Dictionary<string, Dictionary<string, double>>();
        }

        public void SetData(Dictionary<string, Dictionary<string, double>> data)
        {
            database = data;
        }

        public void Insert(string text, string translation, double weight)
        {
            Dictionary<string, double> translations;
            if (database.ContainsKey(text.ToLower()))
            {
                translations = database[text.ToLower()];
            }
            else
            {
                translations = new Dictionary<string, double>();
                database.Add(text.ToLower(), translations);
            }

            if(translations.ContainsKey(translation.ToLower()))
            {
                translations[translation.ToLower()] += weight;
            }
            else
            {
                translations.Add(translation.ToLower(), weight);
            }
        }

        public void Save(string path)
        {
            path = Path.Combine(path, "database");
            string filepath;
            if (File.Exists(path))
            {
                int i = 0;
                while (File.Exists(path + i)) i++;
                filepath = path + i;
            }
            else
            {
                filepath = path;
            }

            List<(string, string, double)> records = new List<(string, string, double)>();

            foreach (var translations in database)
            {
                foreach(var translation in translations.Value)
                {
                    records.Add((translations.Key, translation.Key, translation.Value));
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<(string, string, double)>));
            TextWriter writer = new StreamWriter(filepath);
            serializer.Serialize(writer, records);
        }

        public string Translate(string text)
        {
            if (!database.ContainsKey(text.ToLower())) return null;

            var translations = database[text.ToLower()];

            // Select translation with highest weight.
            var translation = translations.OrderByDescending(kv => kv.Value).FirstOrDefault();
            return translation.Key;
        }
    }
}
