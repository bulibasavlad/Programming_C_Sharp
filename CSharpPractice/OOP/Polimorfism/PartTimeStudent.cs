using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.Polimorfism
{
    internal class PartTimeStudent: Student
    {

        public PartTimeStudent(string Nume, string Prenume, string Adresa): base(Nume, Prenume, Adresa) 
        {
        }

        public override void PrintNume()
        {
            Console.WriteLine("Numele studentului part time este:" + Nume);
        }



    }
}
