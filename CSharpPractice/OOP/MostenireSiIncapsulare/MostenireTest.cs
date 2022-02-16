using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.Mostenire
{
    internal class MostenireTest
    {
        [Test]

        public void Mostenire()
        {
            Angajat angajat = new Angajat("Popescu", "Ion", 25, true);
            angajat.PrintVarstaAngajat();


            Student student = new Student("Albu", "Ana", 35, false);
            student.PrintNumeStudent();
            student.VerificaStudentAngajat();


        }




    }
}
