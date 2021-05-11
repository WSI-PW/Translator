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
        public string Solve(T database, string text)
        {
            if (text is null) return "";

            string[] words = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0) return "";

            (string translation, double numTranslations)[,] translations
                = new (string translation, double numTranslations)[words.Length + 1, words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                translations[1, i] = (database.Translate(words[i]), 1);
            }

            for (int n = 2; n <= words.Length; n++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    translations[n, i] = (null, double.PositiveInfinity);
                }
            }

            for (int n = 2; n <= words.Length; n++)
            {
                for (int i = 0; i + n <= words.Length; i++)
                {
                    string[] subwords = new string[n];
                    Array.Copy(words, i, subwords, 0, n);
                    string subtext = string.Join(" ", subwords);

                    string trans = database.Translate(subtext);

                    if (trans is null)
                    {
                        for (int j = i + 1; j + 1 < i + n; j++)
                        {
                            int l_i = i;
                            int l_n = j - i;
                            int r_i = j;
                            int r_n = n - l_n;

                            double num = translations[l_n, l_i].numTranslations
                                + translations[r_n, r_i].numTranslations;

                            if (num < translations[n, i].numTranslations)
                            {
                                trans = translations[l_n, l_i].translation
                                + translations[r_n, r_i].translation;

                                translations[n, i] = (trans, num);
                            }
                        }
                    }
                    else
                    {
                        translations[n, i] = (trans, 1);
                    }

                }
            }

            return translations[words.Length, 0].translation;

        }
    }
}
