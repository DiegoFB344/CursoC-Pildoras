using System;
using System.IO;

namespace Destructores
{
    /*################# DESTRUCTORES #################*/

    /*
     * Funciona con el Garbage Collection
     * Cuando creamos objetos y variables, estamos reservando en la memoria temporal del equipo
     * El stack y Heap es donde se almacenan y el Garbage Collection ubica los objetos que ya no se utilizan 
     * y los elimina ese recurso.
     * 
     * Funcionamiento del Destructor
     * Se encarga de ejecutar un código cuando se elimina un recurso de la memoria por parte del Garbage Collection
     * Tener en cuenta que se elimina cualquier referencia del recurso.
     * 
     * Ejemplo se Uso:
     * - Conexiones de BDD
     * - Cierre de stream de datos en el manejo externo de ficheros
     * - Eliminación de objetos de colecciones
     * - Etc.
     * 
     */



    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivo miArchivo = new ManejoArchivo();
            miArchivo.Mensaje();
        }
    }

    class ManejoArchivo
    {
        StreamReader archivo = null;
        int contador = 0;

        string linea;

        public ManejoArchivo()
        {
            archivo = new StreamReader(@"D:\Developer\CursoC#\Destructores\TextFile1.txt");

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void Mensaje() => Console.WriteLine($"El archivo tiene {contador} lineas");


        // Destructor
        /*
         * - Solo se usan en clases
         * - Solo puede aver un destructor en la clase
         * - No se heredan ni se sobrecargan
         * - No se llaman son invocados automáticamente
         * - No tiene modificadores de acceso ni parámetros.
         * 
         * NOTA.- Tener cuidado con este destructor
         */
        ~ManejoArchivo()
        {
            archivo.Close();
        }
    }



}
