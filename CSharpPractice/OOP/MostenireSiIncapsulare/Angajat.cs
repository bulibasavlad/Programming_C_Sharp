using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.Mostenire
{
    internal class Angajat : Persoana
    {
        public Angajat(string nume, string prenume, int varsta, bool isAngajat) : base(nume, prenume, varsta, isAngajat)

        {
        }

        public int Varsta { get; private set; }

        public void PrintVarstaAngajat()
        {
            Console.WriteLine("Varsta angajatului este {0}", Varsta);


        }


    }
}
