using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_Database.Database
{
    public interface IDatabase
    {
        /// <summary>
        /// Function translates input. If translation not possible, returns NULL.
        /// </summary>
        /// <param name="text">Text to be translated</param>
        /// <returns></returns>
        string Translate(string text);
        /// <summary>
        /// Function inserts new translations into database or increase weight of existing one.
        /// </summary>
        /// <param name="text">Text to be tranlated</param>
        /// <param name="translation">Translation of text</param>
        /// <param name="weight">Weight of translation</param>
        void Insert(string text, string translation, double weight);
        /// <summary>
        /// The function serializes the database so that there is no need to repeat calculations
        /// </summary>
        /// <param name="path"></param>
        void Save(string path);
    }
}
