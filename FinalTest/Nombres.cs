using System;
using System.Linq;
using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public IEnumerable<int> NombresPairs {
            get { return _keyValuePairs.Where(pair => pair.Value%2==0).Select(pair => pair.Value); } 
        }

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }
    }
}