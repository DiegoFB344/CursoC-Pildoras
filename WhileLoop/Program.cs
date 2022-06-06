using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            int intentos = 0;

            Console.WriteLine("Cual es el numero que genere");

            /*int respuesta = -1;


            while (numeroAleatorio != respuesta)
            {
                respuesta = int.Parse(Console.ReadLine());
                intentos++;


                if (respuesta < numeroAleatorio) Console.WriteLine("El numero es mayor");
                if (respuesta > numeroAleatorio) Console.WriteLine("El numero es menor");
            }

            */



            // DoWhile
            // En el anterior caso tuvimos que inicialización la variable respuesta para que el while pudiera correr ahora:


            int respuesta;
            do
            {
                respuesta = int.Parse(Console.ReadLine());
                intentos++;

                if (respuesta < numeroAleatorio) Console.WriteLine("El numero es mayor");
                if (respuesta > numeroAleatorio) Console.WriteLine("El numero es menor");
            } while (numeroAleatorio != respuesta);

            Console.WriteLine($"Es correcto el numero que genere es: {numeroAleatorio}");
            Console.WriteLine($"Lo lograste en tan solo: {intentos} intentos");
        }
    }
}
