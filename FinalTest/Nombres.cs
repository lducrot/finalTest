using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FinalTest.Tests
{
    public class Nombres
    {
        private readonly IEnumerable<KeyValuePair<string, int>> _keyValuePairs;

        public IEnumerable<int> NombresPairs {
            get { return _keyValuePairs.Where(pair => pair.Value%2==0).Select(pair => pair.Value); } 
        }


        public IEnumerable<string> LettresImpairs
        {
            get { return _keyValuePairs.OrderBy(x => x.Value).Where(x => (x.Value%2) != 0).Select(x => x.Key); }
        }
        public String TexteNombresImpairs {
            get { return LettresImpairs.Aggregate(string.Empty, (x, y) => x + ", " + y).Substring(2); }
        }


        //Ca marche aussi !
        //public String PremierNombreDontLeTexteContientPlusDe5CaractèresEntier
        //{
        //    get { return _keyValuePairs.First(x => x.Key.Length > 5).ToString(); }
        //}
        //public String PremierNombreDontLeTexteContientPlusDe5Caractères
        //{
        //    get { return PremierNombreDontLeTexteContientPlusDe5CaractèresEntier.Substring(0, PremierNombreDontLeTexteContientPlusDe5CaractèresEntier.Length - 4).Substring(1); }
        //}
        public String PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return _keyValuePairs.Where(x => x.Key.Length > 5).Select(x => x.Key).First(); }
        }


        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return _keyValuePairs.OrderBy(x => x.Value).Skip(3).Take(4).Select(x => x.Value); }
        } 
        

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            _keyValuePairs = keyValuePairs;
        }
    }
}