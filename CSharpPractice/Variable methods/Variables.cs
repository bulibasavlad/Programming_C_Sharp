using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Variable_methods
{
    internal class Variables
    {
        // prima clasa
        //clasa = o colectie/multime de variabile si metode
        //variabila = atributul unei clase
      

        public string Name;
        public int Age;
        public double Height;

        //facem o metoda de test
        [Test]
        public void Variabilatest()
        {
            PrintVariables();
            PrintLocalVariables();
            Console.WriteLine("salariul meu este: " + GetIncome());
        }
        // metoda = actiune pe care o poate face o clasa

        public void PrintVariables()
        {
            Name = "vlad";
            Age = 23;
            Height = 1.91;

            Console.WriteLine("Numele este: " + Name);
            Console.WriteLine("Varsta este:" + Age);
            Console.WriteLine("Inaltimea este:{0}", Height);
        }

        public void PrintLocalVariables()
        {
            string Gender = "male";          
            
            Console.WriteLine("Sexul este: " + Gender);
        }
        
        public int GetIncome()
        {
            var Income = 5000;
            return Income;
        }

        

    }
}
