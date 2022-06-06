using System;
using System.Collections.Generic;
using System.Text;

namespace Colecciones
{
    /*
     * COLECCIONES QUEUE (COLA)
     * F.I.F.O First In First Out
     */
    class Queue
    {
        public void CrearQueue()
        {
            Console.WriteLine("Creando un QUEUE");
            Queue<int> numeroQueue = new Queue<int>();

            // Agregando a la cola

            foreach (var item in new int[] { 3, 5, 6, 64, 73 })
            {
                numeroQueue.Enqueue(item);
            }

            foreach (var item in numeroQueue)
            {
                Console.WriteLine(item);
            }


            // Eliminando de la cola

            Console.WriteLine("Eliminando elementos en cola");
            numeroQueue.Dequeue();


            foreach (var item in numeroQueue)
            {
                Console.WriteLine(item);
            }


        }
    }



}
