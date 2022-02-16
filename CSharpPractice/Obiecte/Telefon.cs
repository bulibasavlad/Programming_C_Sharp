using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Obiecte
{
    internal class Telefon
    {
        private string Marca;
        //get si set pe o proprietate
        public string Model { get; set; }
        public string Culoare { get; private set; }

        //get si set pe o variabila globala
      
        private bool Camera;
      

        public Telefon(string Marca, string Model, string Culoare, bool Camera)
        {
            this.Marca = Marca;
            this.Model = Model;
            this.Culoare = Culoare;
            this.Camera = Camera;
    
          
        }

       


        public Telefon(string Marca, string Model, string Culoare)
        {
            this.Marca = Marca;
            this.Model = Model;
            this.Culoare = Culoare;
            

        }
        
        //Get+SET

        public string GetMarca()
        {
            return Marca;

        }
        public string GetCuloare()
        {
            return Culoare;

        }
        public void SetCuloare(string culoare)
        {
            Culoare = culoare;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Marca este {0}", Marca);
            Console.WriteLine("Culoarea este {0}", Culoare);
        }

        public void PrintCamera()
        {
            Console.WriteLine("Telefonul are sau nu are camera {0}", Camera);
        }
    }
}
