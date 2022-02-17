using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.Interfaces
{
    internal class Itest
    {
        [Test]
         public void InterfaceTest()

         {
            Student s1 = new Student("Pirvu", "Oana", "25", "Student");
            s1.Invata();
            s1.DetaliiStudent();

            Angajat a1 = new Angajat("Smoleanu", "Nina", "22", "Angajat");
            a1.Munceste();
            a1.DetaliiAngajat();

            StudentAngajat sa1 = new StudentAngajat("Alexandra", "Popescu", "30", "Student si angajat");
            sa1.Invata();
            sa1.Munceste();
            sa1.DetaliiAngajat();
            sa1.DetaliiStudent();
         }




    }
}
