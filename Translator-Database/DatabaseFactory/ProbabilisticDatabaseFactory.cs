using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Database.DatabaseFactory
{
    public class ProbabilisticDatabaseFactory<T> : DatabaseFactory<T>
        where T : class, IDatabase, new()
    {
        public override T CreateDatabase(string[] filepaths)
        {
            T database = new T();
            foreach (string path in filepaths)
            {
                TextReader reader = new StreamReader(path);
                string content = reader.ReadToEnd();
                string[] sentenses = content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < sentenses.Length - 1; i += 2)
                {
                    List<(string, string, double)> records = ProbabilisticSplit(sentenses[i]);
                    foreach (var record in records)
                    {
                        database.Insert(record.Item1, record.Item2, record.Item3);
                    }
                }
            }

            return database;
        }

        private List<(string, string, double)> ProbabilisticSplit(string v)
        {
            string[] pair = v.Split(';');
            string[] tran = pair[0].Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            string[] text = pair[1].Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            int n = text.Length;
            int m = tran.Length;

            var records = new List<(string, string, double)>();

            for (int i = 0; i < text.Length; i++)
                for (int j = i; j < text.Length; j++)
                {
                    double expected_length = m * (j - i + 1) / (n + 0.0);

                    string[] translated_words = new string[j - i + 1];
                    Array.Copy(text, i, translated_words, 0, j - i + 1);
                    string translated_text = string.Join(" ", translated_words);

                    int x = Math.Min(i, m - n + i);
                    x = Math.Max(x, 0);
                    int y = Math.Max(j, m - n + j);
                    y = Math.Min(y, m - 1);

                    int xy = y - x + 1;

                    string[] possible_translations = new string[xy];
                    Array.Copy(tran, x, possible_translations, 0, xy);

                    for (int k = 0; k < possible_translations.Length; k++)
                        for (int l = k; l < possible_translations.Length; l++)
                        {
                            string[] translation_words = new string[l - k + 1];
                            Array.Copy(possible_translations, k, translation_words, 0, l - k + 1);
                            string translation = string.Join(" ", translation_words);

                            int length = l - k + 1;
                            double d = CalculateWeight(expected_length, length);

                            records.Add((translated_text, translation, d));
                        }
                }

            return records;
        }

        private double CalculateWeight(double expected_length, int length)
        {
            double l = expected_length;
            double k = length;

            return Math.Exp(-(l - k) * (l - k) / l);
        }
    }
}
