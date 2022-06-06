using System;
using System.Collections.Generic;
using System.Text;

namespace Colecciones
{
    /*
     * COLLECIONES LINK LIST
     * A diferencia de las listas convencionales que guardan los elementos
     * en memoria en posiciones adyacentes una tras de otra, al momento de mover
     * o eliminar algún elementos internamente lo que hace es re-ubicar todos los elementos
     * para sustituir el elemento básico y en rendimiento es malo si hablamos de muchos elementos.
     * 
     * Las "linkList" se guardan en forma de nodos las cuales tiene dos enlaces (link) de referencia
     * del elemento anterior y con el siguiente, con lo que al momento de eliminar y añadir elementos
     * solo se actualizan esto link´s y el rendimiento es mejor
     */

    class LinkList
    {

        public void CrearLinkList()
        {

            LinkedList<int> numerosLink = new LinkedList<int>();

            foreach (var item in new int[] { 2, 35, 12, 16, 6132, 23 })
            {
                numerosLink.AddFirst(item);
            }

            // Eliminando un elemento en particular
            numerosLink.Remove(16);

            // Agregando y eliminando nodos
            LinkedListNode<int> nodeImportante = new LinkedListNode<int>(12835);

            numerosLink.AddFirst(nodeImportante);

            //numerosLink.Remove(nodeImportante);

            /*foreach (var item in numerosLink)
            {
                Console.WriteLine(item);
            }*/

            // Manejándolo de otra manera
            for (LinkedListNode<int> node = numerosLink.First; node != null; node=node.Next)
            {
                int numero = node.Value;
                Console.WriteLine(numero);
            }
        }

    }
}
