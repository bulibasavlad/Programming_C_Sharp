using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Obiecte.OOP.Mostenire
{
    internal class Persoana
    {
    //Mostenire = conceptul prin care o clasa poate accesa atributele unei alte clase  + si le poate folosii
    //Putem mostenii o singura clasa
    //Incapsulare = conceptul prin care excludem atribute specifice de lumea exterioara
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public int Varsta { get; private set; }
        public bool IsAngajat { get; private set; }

        public Persoana(string nume, string prenume, int varsta, bool isAngajat)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            IsAngajat = isAngajat;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Numele este {0}", Nume);
            Console.WriteLine("Prenumele este {0}", Prenume);
            Console.WriteLine("Varsta este {0}", Varsta);
            Console.WriteLine("Este angajat? {0}", IsAngajat);
        
        }












    }

}
