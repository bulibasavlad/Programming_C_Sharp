using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.abstractClass
{
    internal class Student : AbstractPersoana
    {
        public string Nume { get; private set; }
        public string Prenume { get; private set; }
        public string Varsta { get; private set; }
        public string Meserie { get; private set; }

        public Student(string Nume, string Prenume, string Varsta, string Meserie)
        {

            this.Nume = Nume;
            this.Prenume = Prenume;
            this.Varsta = Varsta;
            this.Meserie = Meserie;

        }

        public override void Invata()
        {
            Console.WriteLine("Studentul invata pentru examene");      }

        public override void Munceste()
        {
            Console.WriteLine("Munceste in internship");
        }
    }
}
