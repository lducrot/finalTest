using System;
using System.Linq;

namespace FinalTest.Tests
{
    public class Calculatrice 
    {
        private IOperation[] _operation;

        public Calculatrice(IOperation[] operation)
        {
            _operation = operation;
        }

        public Int32 Calculer(string chaine)
        {   
            return (from operation in _operation where operation.PeutCalculer(chaine) select operation.Calculer(chaine)).FirstOrDefault();
        }
    }
}