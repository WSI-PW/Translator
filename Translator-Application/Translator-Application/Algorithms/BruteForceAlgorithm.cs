using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Application.Algorithms
{
    class BruteForceAlgorithm<T> : IAlgorithm<T>
        where T : IDatabase
    {
        public string Solve(T database, string text)
        {
            string[] originalSentence = text.Split(' ');

            return TranslateSentence(database, originalSentence);
        }

        private string TranslateWord(T database, string originalWord)
        {
            string translatedWord = database.Translate(originalWord);
            if (translatedWord == null)
            {
                // No translation found in database. Not much we can do here.
                return "###";

                // Other option: return empty string or "?".
            }

            return translatedWord;
        }

        private string TranslateSentence(T database, string[] originalSentence)
        {
            if (originalSentence.Length == 0)
                return "";

            // Translate sentence word by word.
            var translatedWordList = new List<string>();
            foreach(string originalWord in originalSentence)
            {
                var translatedWord = TranslateWord(database, originalWord);
                translatedWordList.Add(translatedWord);
            }

            // Produce final translated sentence.
            StringBuilder translatedSentece = new StringBuilder();
            foreach(string translatedWord in translatedWordList)
            {
                translatedSentece.Append(translatedWord);
                translatedSentece.Append(" ");
            }

            return translatedSentece.ToString();
        }
    }
}
