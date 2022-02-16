using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.Interfaces
{
    internal class StudentAngajat : Persoana, Iangajat, Istudent
    {

        public StudentAngajat (String Nume, string Prenume, string Varsta, string Meserie) : base(Nume, Prenume, Varsta, Meserie)
        {

        }
        public void DetaliiAngajat()
        {
            Console.WriteLine("Lucreaza QA atomation - big paycheck");
        }

        public void DetaliiStudent()
        {
            Console.WriteLine("Lucreaza QA atomation - internship");
        }

        public void Invata()
        {
            Console.WriteLine("Lucreaza QA atomation - C#");
        }

        public void Munceste()
        {
            Console.WriteLine("Lucreaza QA atomation - si QA manual");
        }
    }
}
