using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    /*################# CLASES ABSTRACTAS #################*/
    /*
     * Son aquellas de las cual se toman abstracciones para otras clases
     * Son las que por lo general menos comportamientos o características tiene (Básicas)
     * Son también utilizadas para poder crear métodos Abstractos los cual son parecidas a las Interfaces
     * Ya que son obligatorias para las clases que heredan de ellas pero también con la posibilidad de desarrollar el comportamiento diferente.
     */
    abstract class Animales
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        // La clase es abstract lo que obliga a la misma clase a ser abstract
        // ya que solo pueden vivir en clases del mismo tipo.
        // Recordar que solo se declara la el método pero no se inicia con nada.
        public abstract void GetNombre();
    }
}
