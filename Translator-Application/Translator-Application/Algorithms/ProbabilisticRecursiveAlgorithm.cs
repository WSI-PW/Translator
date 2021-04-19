using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator_Database.Database;

namespace Translator_Application.Algorithms
{
    class ProbabilisticRecursiveAlgorithm<T> : IAlgorithm<T>
        where T : IDatabase
    {
        public string Solve(T database, string text)
        {
            throw new NotImplementedException();
        }
    }
}
