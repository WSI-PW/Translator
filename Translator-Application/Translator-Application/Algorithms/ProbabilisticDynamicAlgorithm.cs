using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Application.Algorithms
{
    class ProbabilisticDynamicAlgorithm<T> : IAlgorithm<T>
        where T : IDatabase
    {
        private string GetArrayElementsFromTo(string[] array, int from, int to)
        {
            StringBuilder senteceToTranslate = new StringBuilder();
            for (int index = from; index < to; index++)
            {
                senteceToTranslate.Append(array[index]);
                senteceToTranslate.Append(" ");
            }

            // remove last " "
            if (senteceToTranslate.Length != 0)
            {
                senteceToTranslate.Remove(senteceToTranslate.Length - 1, 1);
            }

            return senteceToTranslate.ToString();
        }
        public string Solve(T database, string text)
        {
            string[] words = text.Split(' ');

            // [x,y]:
            // x - string length
            // y - string start index
            // (a,b):
            // a - translation
            // b - number of translated substrings that consists of
            (string translation, double translationsCount)[,] translations = new (string, double)[words.Length + 1, words.Length + 1];

            for (int i = 0; i < words.Length + 1; i++)
            {
                for (int j = 0; j < words.Length + 1; j++)
                {
                    translations[i, j] = ("###", double.PositiveInfinity);
                }
            }

            for (int i=0; i < words.Length; i++)
            {
                translations[1, i].translation = database.Translate(words[i]);
                if (translations[1, i].translation == null)
                    translations[1, i].translation = "###";
                translations[1, i].translationsCount = 1;
            }

            // looking for strings with length = 2,3,...
            for(int n = 2; n <= words.Length; n++)
            {
                // setting start index for the lookup
                for(int i = 0; i+n <= words.Length; i++)
                {
                    string subSentence = this.GetArrayElementsFromTo(words, i, i + n).ToString();

                    string translatedSubSentence = database.Translate(subSentence);

                    if(translatedSubSentence != null)
                    {
                        translations[n, i] = (translatedSubSentence, 1);
                    }
                    else
                    {
                        for(int j = i+1; j+1 < i+n; j++)
                        {
                            int l_i = i;
                            int l_n = j - 1;
                            int r_i = j;
                            int r_n = n - l_n;

                            double count = translations[l_n, l_i].translationsCount + translations[r_n, r_i].translationsCount;

                            if(count < translations[n,i].translationsCount)
                            {
                                string translation = translations[l_n, l_i].translation + " " + translations[r_n, r_i].translation;
                                translations[n, i] = (translation, count);
                            }
                        }
                    }
                }
            }

            return translations[words.Length, 0].translation;
        }
    }
}
