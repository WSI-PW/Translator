using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Application.Algorithms
{
    class ProbabilisticRecursiveAlgorithm<T> : IAlgorithm<T>
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
            if(senteceToTranslate.Length != 0)
            {
                senteceToTranslate.Remove(senteceToTranslate.Length - 1, 1);
            }

            return senteceToTranslate.ToString();
        }

        public string Solve(T database, string text)
        {
            if (text.Length == 0)
            {
                return "";
            }

            //split sentence into words
            string[] words = text.Split(' ');

            for (int n = words.Length; n >= 1; n--)
            {
                for (int m = 0; m + n <= words.Length; m++)
                {
                    // podciąg zdania długości n zaczynający się od indeksu i;
                    string subSentence = this.GetArrayElementsFromTo(words, m, m + n);

                    string translatedSubSentence = database.Translate(subSentence);

                    if (translatedSubSentence != null)
                    {
                        string leftSubString = this.GetArrayElementsFromTo(words, 0, m - 1).ToString();
                        string rightSubString = this.GetArrayElementsFromTo(words, m + n, words.Length).ToString();

                        return this.Solve(database, leftSubString) + " "
                            + translatedSubSentence + " "
                                + this.Solve(database, rightSubString);
                    }
                }
            }

            return "###";
        }
    }
}
