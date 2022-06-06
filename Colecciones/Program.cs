using System;
using System.Collections.Generic;

namespace Colecciones
{
    /*
     * COLECCIONES
     * 
     * Son clases que pertenecen al name-space System.Collection.Generic
     * Estas clases permiten almacenar elementos
     * Son clases Genéricas como indica el name-space
     * No tienen las limitaciones de los Arrays, pero consumen mas recurso:
     * - Ordenar elementos
     * - Añadir elementos en tiempo de ejecución
     * - Eliminar elementos
     * - Buscar
     * - Etc.
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>(); // Declarando una lista (colección de tipo List)

            int[] arrayNumeros = new int[] { 3, 9, 21, 16, 74, 37, 50 };

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                numeros.Add(arrayNumeros[i]);
            }

            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Cuantos elementos quieres introducir");

            int elem = int.Parse(Console.ReadLine());

            for (int i = 0; i < elem; i++)
            {
                Console.WriteLine($"Introduce el elemento {i} para agregarlo a la colección");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Los elementos que añadiste son: ");

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Has eliminado el ultimo elemento te dejo la nueva lista");
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }




            LinkList linkList = new LinkList();

            linkList.CrearLinkList();


            Queue queue = new Queue();

            queue.CrearQueue();

            StackDictionary sD = new StackDictionary();
            sD.CrearStack();

            sD.CreaDictionaty();
        
        }
    }
}
