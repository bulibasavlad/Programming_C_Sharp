using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.abstractClass
{
    public string Nume { get; private set; }
    public string Prenume { get; private set; }
    public string Varsta { get; private set; }
    public string Meserie { get; private set; }

    public Angajat(string Nume, string Prenume, string Varsta, string Meserie)
    {

        this.Nume = Nume;
        this.Prenume = Prenume;
        this.Varsta = Varsta;
        this.Meserie = Meserie;

    }




    internal class Angajat : AbstractPersoana
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public Angajat(string v1, string v2, string v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public override void Invata()
        {
            Console.WriteLine("Studentul invata pentru examene");
        }

        public override void Munceste()
        {
            Console.WriteLine("Munceste in internship");
        }
    }
}
