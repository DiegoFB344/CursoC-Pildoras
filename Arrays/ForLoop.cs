using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{

    class ForLoop
    {
        public static void recorreLoop(string[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }

        public void recorreLoop2(int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
        }

        // Método que retorne un array
        public int[] LeerDatos()
        {
            Console.WriteLine($"Cuantos elementos quieres en el arreglo");
            string respuesta = Console.ReadLine();
            int numeroElementos = int.Parse(respuesta);
            int[] datos = new int[numeroElementos];

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Introduce el valor {i} del arreglo");
                respuesta = Console.ReadLine();
                int datoArray = int.Parse(respuesta);
                datos[i] = datoArray;
            }

            return datos;
        }
    }
}
