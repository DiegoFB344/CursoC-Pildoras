using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Humano : Mamiferos
    {
        public Humano(string nombre) : base(nombre)
        {
        }


        //Para sellar la clase o métodos para que no puedan seguir heredando ocupamos la palabra reservada sealed
        public sealed override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Adolecente : Humano
    {
        public Adolecente(string nombre) : base(nombre)
        {
        }

        // Este método esta heredado de Humano no de la clase Mamífero
        /*public override void Pensar()
        {
            Console.WriteLine("Las hormonas me impiden pensar con claridad");
        }*/
    }
}
