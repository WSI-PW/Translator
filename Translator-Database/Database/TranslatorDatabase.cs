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
            if (database.ContainsKey(text))
            {
                translations = database[text];
            }
            else
            {
                translations = new Dictionary<string, double>();
                database.Add(text, translations);
            }

            if(translations.ContainsKey(translation))
            {
                translations[translation] += weight;
            }
            else
            {
                translations.Add(translation, weight);
            }
        }

        public void Save(string path)
        {
            string filepath;
            if (File.Exists(path))
            {
                int i = 0;
                while (File.Exists(path + i)) i++;
                filepath = Path.Combine(path, "database" + i);
            }
            else
            {
                filepath = Path.Combine(path, "database");
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
            if (!database.ContainsKey(text)) return null;

            var translations = database[text];
            var translation = translations.Max();
            return translation.Key;
        }
    }
}
