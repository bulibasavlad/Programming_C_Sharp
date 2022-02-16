using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.Interfaces
{
    internal class Angajat : Persoana, Iangajat
    {
        public Angajat (String Nume, string Prenume, string Varsta, string Meserie) : base(Nume, Prenume, Varsta, Meserie)
        {

        }

        public void DetaliiAngajat()
        {
            Console.WriteLine("Lucreaza QA atomation");
        }

        public void Munceste()
        {
            Console.WriteLine("Scrie teste pt QA atomation");
        }


    }
}
