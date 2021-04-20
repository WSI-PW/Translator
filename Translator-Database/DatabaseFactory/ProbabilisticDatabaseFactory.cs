using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
    }
}
