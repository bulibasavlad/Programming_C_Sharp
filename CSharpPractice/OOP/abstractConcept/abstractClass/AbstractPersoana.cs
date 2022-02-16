using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.abstractClass
{
    abstract class AbstractPersoana
    {

        //clasa abstracta = poate sau nu sa contian metode abstracte
        //la clasa abstracta se foloseste cuvantul abstract
        //o clasa abstracta nu se poate instatia folosind cuvantul "new"
        //o clasa abstracta poate sa implementeze o interfata
        //o clasa abstracta poate sa contina un constructor

        //diferente intre clasa abstracta si interfata:
        //o interfata nu poate oferii implementare pentru clasa abstracta
        //interfata poate sa extinda o alta interfata
        //o clasa abstracta poate sa extinda o alta clasa abstracta si sa implementezi mai multe interfete
       public abstract void Munceste();
       public  abstract void Invata();
        
        public void DetaliiPersoana()
        {
            Console.WriteLine("Destaliile despre persoana sunt:");
        }




    }
}
