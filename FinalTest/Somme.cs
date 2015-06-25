using System;

namespace FinalTest.Tests
{
    public class Somme
    {

        public Somme() { }

        public Boolean PeutCalculer(string chaine)
        {
            Boolean ok = false;
            if (chaine.Substring(1, 1) == "+")
            {
                ok = true;
            }
            else ok = false;
            return ok;
        }

        public Int32 Calculer(String chaine)
        {
            int resultat = 0;
            int a = 0;
            int b = 0;
            Int32.TryParse(chaine.Substring(0, 1), out a);
            Int32.TryParse(chaine.Substring(2, 1), out b);

            resultat = a + b;
            return resultat;
        }

    }
}