using System;
using System.Collections.Generic;

namespace DelgadoPredicadLamna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación del objeto delegado apuntando a la Clase Delegado con su método correspondiente
            ObjetoDelegado elDelegado = new ObjetoDelegado(Delegados.SaludoBienvenida);

            // Utilizando el delegado para llamar al método
            elDelegado();

            elDelegado = new ObjetoDelegado(Delegados.SaludoDespedida);

            elDelegado();

            /*################# Predicados #################*/
            List<int> listaNumeros = new List<int>();

            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            // Declarando predicado delegado
            Predicate<int> elDelegadoPred = new Predicate<int>(Predicados.DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);

            foreach (int item in numPares)
            {
                Console.WriteLine(item);
            }
        }

        // Definición del objeto delegado como un método
        delegate void ObjetoDelegado();


    }
}
