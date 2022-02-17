using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.Interfaces
{
    internal class Student : Persoana, Istudent
    {
        public Student (String Nume, string Prenume, string Varsta, string Meserie) : base (Nume, Prenume, Varsta, Meserie)
        {

        }

        public void DetaliiStudent()
        {
            Console.WriteLine("Se angajeaza QA atomation");
        }

        public void Invata()
        {
            Console.WriteLine("invata C#");
           
        }






    }
}
