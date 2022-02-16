using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.Interfaces
{
    internal class Persoana
    {
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public string Varsta { get; private set; }
        public string Meserie { get; private set; }


        public Persoana(string Nume, string Prenume, string Varsta, string Meserie)
        {
           
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Varsta = Varsta;
            this.Meserie = Meserie;

        }
    }
}
