using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.DatabaseFactory;

namespace Translator_Database.DatabaseFactory
{
    static class FactoryRunner<T, P>
        where T: class, IDatabaseFactory<P>, new()
        where P: class, IDatabase
    {
        public static void Run(IEnumerable<string> filepaths, string savepath)
        {
            T factory = new T();
            P database = factory.CreateDatabase(filepaths.ToArray());
            database.Save(savepath);
        }
    }
}
