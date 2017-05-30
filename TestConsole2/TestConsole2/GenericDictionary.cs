using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole2
{
    public class GenericDictionary<TKey, TValue> where TKey: Person 
                                                where TValue : Jobs
    {

        public void Add(TKey key, TKey value)
        {
            
        }
    }
}
