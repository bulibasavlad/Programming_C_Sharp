using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Obiecte.OOP.Mostenire
{
    internal class Student : Persoana
    {
        public Student (string nume, string prenume, int varsta, bool isAngajat): base(nume, prenume, varsta, isAngajat)

        { 
        }

        public void PrintNumeStudent()
        {
            Console.WriteLine("Numele Studentului {0}", Nume);

        }

        public void VerificaStudentAngajat()
        {
            Console.WriteLine("Stundentul este angajat {0}", IsAngajat);
        }





    }
}
