using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.abstractClass
{
    internal class AbstractTest
    {
        [Test]
       public void Test() 
        {
            Student s1 = new Student("Pirvu", "Oana", "25", "Student");
            s1.Invata();
            s1.Munceste();
            s1.DetaliiPersoana();

            Angajat a1 = new Angajat("Smoleanu", "Nina", "22", "Angajat");
            a1.Munceste();
            a1.Invata();
            a1.DetaliiPersoana();

            StudentAngajat sa1 = new StudentAngajat("Alexandra", "Popescu", "30", "Student si angajat");
            sa1.Invata();
            sa1.Munceste();
            sa1.DetaliiPersoana();

        }











    }
}
