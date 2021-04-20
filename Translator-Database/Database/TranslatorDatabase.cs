using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_Database.Database
{
    public class TranslatorDatabase : IDatabase
    {
        Dictionary<string, Dictionary<string, double>> database = new Dictionary<string, Dictionary<string, double>>();
        public void Insert(string text, string translation, double weight)
        {
            var translations = database[text];
            if(translations.ContainsKey(translation))
            {
                translations.Add(translation, weight);
            }
        }

        public void Save(string path)
        {
            throw new NotImplementedException();
        }

        public string Translate(string text)
        {
            throw new NotImplementedException();
        }
    }
}
