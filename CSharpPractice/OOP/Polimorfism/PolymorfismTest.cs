using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.Polimorfism
{
    internal class PolymorfismTest
    {
        public PolymorfismTest()
        {
        }

        [Test]

        public void testPolymorphism(PartTimeStudent student1)
        {
            PartTimeStudent partTimeStudent = new PartTimeStudent("Alexandra", "Popescu", "Bucuresti");
            partTimeStudent.PrintNume();

        }






    }
}
