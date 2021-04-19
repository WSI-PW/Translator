using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.Database;

namespace Translator_Database.DatabaseFactory
{
    public class ProbabilisticDatabaseFactory<T> : IDatabaseFactory<T>
        where T : class, IDatabase
    {
        public T CreateDatabase(string[] filepaths)
        {
            throw new NotImplementedException();
        }

        public T LoadDatabase(string path)
        {
            throw new NotImplementedException();
        }
    }
}
