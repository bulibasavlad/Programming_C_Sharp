using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.AccessControl.Public
{
    internal class Persona
    {
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public int Varsta { get; private set; }
        public bool IsAngajat { get; private set; }

        public Persona(string nume, string prenume, int varsta, bool isAngajat)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            IsAngajat = isAngajat;
        }


        // public = este vizibil peste tot (adica in orice clasa + in orice pachet)
        public void PrintNume ()
        {
            Console.WriteLine ("Numele este {0}", Nume);
        }






    }
}
