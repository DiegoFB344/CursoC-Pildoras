using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    class Mamiferos : Animales
    {
        // Campos de clase encapsuladas
        string nombreMamifero;


        // Constructor
        public Mamiferos(string nombre)
        {
            this.nombreMamifero = nombre;
        }


        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamífero es: " + nombreMamifero);
        }

        public virtual void Pensar()
        {
            Console.WriteLine("El pensamiento instintivo");
        }




    }
}
