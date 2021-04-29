using System;
using System.Collections.Generic;

namespace Translator
{
    interface ITranslateAlgorithms
    {
         string Translate(string[] sentence);
    }

    public class GreedyProbabilisticAlgorithm : ITranslateAlgorithms
    {
        private T[] GetArrayElementsFromTo<T>(T[] array, int from, int to)
        {
            List<T> listArray = new List<T>();
            for(int index = from; index <= to; index++)
            {
                listArray.Add(array[index]);
            }

            return listArray.ToArray();
        }

        public string Translate(string[] sentence)
        {
            if(sentence.Length == 0)
            {
                return new string("");
            }

            for(int n = sentence.Length; n >= 1; n--)
            {
                for(int m = sentence.Length; m + n <= sentence.Length; m++)
                {
                    string[] subSentence = this.GetArrayElementsFromTo(sentence, m, m + n);

                    string translatedSubSentence = ""; // find_translated_sentence_in_database(subSentence);

                    if(translatedSubSentence.Length >= 0)
                    {
                        string[] leftSubString = this.GetArrayElementsFromTo(sentence, 0, m - 1);
                        string[] rightSubString = this.GetArrayElementsFromTo(sentence, m + n, sentence.Length - 1);

                        return this.Translate(leftSubString)
                            + translatedSubSentence
                                + this.Translate(rightSubString);
                    }
                }
            }

            return new string("!!!SENTENCE CANNOT BE TRANSLATED BY TRANSLATOR!!!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = { "Ala", "ma", "kota" };

            ITranslateAlgorithms greedyProbabilisticTranslator = new GreedyProbabilisticAlgorithm();

            Console.WriteLine(greedyProbabilisticTranslator.Translate(sentence));
        }
    }
}
