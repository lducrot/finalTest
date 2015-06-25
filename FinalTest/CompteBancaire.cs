using System;
using System.Collections.Generic;

namespace FinalTest.Tests
{
    public class CompteBancaire : IEvenementMetier
    {

        private string _numeroDeCompte;
        private int _autorisationDeCredit;

        public CompteBancaire(string numeroDeCompte, int autorisationCredit)
        {
            _numeroDeCompte = numeroDeCompte;
            _autorisationDeCredit = autorisationCredit;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            throw new NotImplementedException();
        }

        public Void CompteCree(string numeroDeCompte, int autorisationDeCredit)
        {
            //TODO 
        }


    }
}