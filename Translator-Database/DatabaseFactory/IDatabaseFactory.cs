using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Database.DatabaseFactory
{
    public interface IDatabaseFactory<T>
        where T: class, IDatabase
    {
        /// <summary>
        /// Function creates database instance with data processed from files given in filepaths
        /// </summary>
        /// <param name="filepaths">Source of data</param>
        /// <returns></returns>
        T CreateDatabase(string[] filepaths);
        /// <summary>
        /// Function loads deserializes database from file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        T LoadDatabase(string path);
    }
}
