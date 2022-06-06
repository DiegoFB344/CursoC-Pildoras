using System;
using System.Collections.Generic;
using System.Text;

namespace Colecciones
{
    class StackDictionary
    {
        /*
         * COLLECIONES STACK
         * L.I.F.O Last Int First Out
         * Métodos entrada salida:
         * - push()
         * - pop()
         */
        public void CrearStack()
        {

            Console.WriteLine("Agregando elementos al Stack");
            Stack<int> numerosStack = new Stack<int>();

            // Agregando a la cola

            foreach (var item in new int[] { 3, 5, 6, 64, 73 })
            {
                numerosStack.Push(item);
            }

            foreach (var item in numerosStack)
            {
                Console.WriteLine(item);
            }


            // Eliminando de la cola

            Console.WriteLine("Eliminando elementos en cola");
            numerosStack.Pop();


            foreach (var item in numerosStack)
            {
                Console.WriteLine(item);
            }

        }

        /*
         * COLECCION DICTIONARY
         * 
         * Elementos con clave-valor
         * Métodos agregar y eliminar:
         * - Add(Tkey, Tvalue)
         */
        public void CreaDictionaty()
        {
            Dictionary<string, int> edades = new Dictionary<string, int>();

            // Rellenando diccionario
            edades.Add("Eduardo", 30);
            edades.Add("Diana", 32);
            edades.Add("Mario", 34);
            edades.Add("Juan", 38);

            // Con Arrays
            edades["Mia"] = 26;
            edades["Armando"] = 69;

            // Recorriendo con foreach que devuelve un elemento de clave-valor
            foreach (KeyValuePair<string, int> personas in edades)
            {
                Console.WriteLine($"Nombre: {personas.Key} Edad: {personas.Value}");
            }
        }
    }
}
