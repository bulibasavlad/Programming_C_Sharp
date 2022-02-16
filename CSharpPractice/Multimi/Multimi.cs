using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Multimi
{
    internal class Multimi
    {
        [Test]

        public void MultimiTest()
        {
            ArrayExemplu();
            ArrayValoareExemplu();
            ListaValoare();
            DictionaryValoare();
            DictionaryColegi();
        }

        //afisare toate elementele unui Array
        public void ArrayExemplu()
        {
            String[] arrayNume = new string[4];
            arrayNume[0] = "Nina";
            arrayNume[1] = "Alex";
            arrayNume[2] = "Bianca";
            arrayNume[3] = "Elena";

            foreach (string nume in arrayNume)
            {
                Console.WriteLine("Numele curent cu array este: " + nume);
            }


        }


        //afisarea unui anumit element din arrray
        public void ArrayValoareExemplu()
        {
            String[] arrayNume = new string[4];
            arrayNume[0] = "Nina";
            arrayNume[1] = "Alex";
            arrayNume[2] = "Bianca";
            arrayNume[3] = "Elena";

            foreach (string nume in arrayNume)
            {
                if (nume.Equals("Alex"))
                {
                    Console.WriteLine("Numele curent cu array este: " + nume);
                }
                
            }


        }


        //lista
        public void ListaValoare()
        {
            List<string> listanume = new List<string>();
            listanume.Add("Nina");
            listanume.Add("Alex");
            listanume.Add("Bianca");
            listanume.Add("Elena");
            listanume.Add("Emil");

            foreach (string nume in listanume)
            {
                if (nume.Equals("Alex"))
                {
                    Console.WriteLine("Numele curent cu array este: " + nume);
                }

            }


        }


        //Dictionary
        //functioneaza cu conceptul de key value


        public void DictionaryValoare()
        {
            Dictionary <string, string> dictionaryNume = new Dictionary<string, string>();
            dictionaryNume.Add("Tester Manual", "Alex");
            dictionaryNume.Add("Tester Automation", "Bianca");
            dictionaryNume.Add("Tester Manual + Automation", "Alex");
  
      


            foreach (var coleg in dictionaryNume)
            {
                Console.WriteLine("Colegul cu meseria {0} are numele {1}", coleg.Key, coleg.Value);
            }
        }


        public void DictionaryColegi()
        {
            Dictionary<string, List<string>> dictionaryNume = new Dictionary<string, List<string>>();

            List<string> ListTestManual = new List<string>();
            ListTestManual.Add("Alex");
            ListTestManual.Add("Alexandru");
            ListTestManual.Add("Alina");

            List<string> ListTestAutomation = new List<string>();
            ListTestAutomation.Add("Bianca");
            ListTestAutomation.Add("Vlad");

            List<string> ListTestDeveloperi = new List<string>();
            ListTestAutomation.Add("Emilian");
            ListTestAutomation.Add("Vlad");


            dictionaryNume.Add("Tester Manual", ListTestManual);
            dictionaryNume.Add("Tester Automation", ListTestManual);
            dictionaryNume.Add("Developeri", ListTestManual);


            foreach (var key in dictionaryNume.Keys)
            {
                List<string> List = dictionaryNume[key];
                Console.WriteLine("Key = {0} contains {1} values", key, List.Count);
                foreach (var value in List)
                {
                    Console.WriteLine(value);
                }

            }

        }



    }

}
