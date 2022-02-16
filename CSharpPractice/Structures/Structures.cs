using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Structures
{
    internal class Structures
    {
        //Structurile sunt de 2 tipuri: alternative si repetitive

        [Test]

        public void StructureTest()
        {
            CompareNumber(5, 3);
            CompareNumber(4, 6);
            CompareNumber(5, 5);
            Write100LinesFOR();
            Write100LinesWHILE();
        }



        //verificam daca un numar este mai mare decat celalalt
        public void CompareNumber(int number1, int number2)
        {
            if (number1 > number2)
            {
                Console.WriteLine("Numarul 1 este mai mare decat numarul 2");
            }
            else if (number1 == number2)
            {
                Console.WriteLine("Numarul 2 este egal cu numarul 1");

            }
            else
            {
                Console.WriteLine("Numarul 2 este mai mare decat numarul 1");
            }
        }

        //afisam pe tastatura primele 100 de numere cu FOR
        public void Write100LinesFOR()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Numerul curent este" + i);

            }

        }
        //  //afisam pe tastatura primele 100 de numere cu WHILE
        public void Write100LinesWHILE()
        {

            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine("Numerul curent este" + i);
                i++;
            }
        }
        
    }
}
