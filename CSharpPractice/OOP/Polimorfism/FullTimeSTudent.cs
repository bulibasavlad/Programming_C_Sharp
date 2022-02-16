using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.Polimorfism
{
    internal class FullTimeStudent : Student
    {

        public FullTimeStudent(string Nume, string Prenume, string Adresa) : base(Nume, Prenume, Adresa)
        {
        }

        public override void PrintNume()
        {
            Console.WriteLine("Numele studentului full time este:" + Nume);
        }



        //polimorfism static = overloading

        public void PrintNote (int Nota1, int Nota2)
        {
            Console.WriteLine("Nota1: ", + Nota1);
            Console.WriteLine("Nota2: ", + Nota2);

        }


        public void PrintNote(int Nota1, int Nota2, int Nota3)
        {
            Console.WriteLine("Nota1: ", + Nota1);
            Console.WriteLine("Nota2: ", + Nota2);
            Console.WriteLine("Nota3: ", + Nota3);
        }

        public int PrintNote(double Nota1 )
        {
            Console.WriteLine("Nota1: ", + Nota1);

            return 1;
        
        }



    }
}