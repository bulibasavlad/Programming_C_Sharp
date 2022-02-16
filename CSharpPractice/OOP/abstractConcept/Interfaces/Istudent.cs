using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.OOP.abstractConcept.Interfaces
{
    internal interface Istudent
    {
        //abstractizarea datelor = conceptul prin care putem definii comportamentul unei clase
        //se poate face cu interfete/clase abstracte
        //o interfata trebuie sa inceapa cu litera "I"
        //toate metodele dintr o interfata trebuie sa fie abstracte
        //interfata nu contine constructori
        //clasa care implementeaza interfata rezulta ==> trebuie sa implementeze toate metodele interfetei
        //interfata poate sa mosteneasca o alta interfata
        //interfata nu poate sa implementeze o clasa abstracta
        //o clasa poate implementa mai multe interfete

        void Invata();
        void DetaliiStudent();

       

    }




}
