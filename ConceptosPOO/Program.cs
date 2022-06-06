using System;

// Como ejemplo digamos que estamos utilizando demasiado los métodos de la clase Math
// Para simplificar y no poner delante Math.Método() usamos lo siguiente

using static System.Math;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();


            // Usando sus métodos astáticos sin math.
            double raiz = Sqrt(25);
            double potencia = Pow(5, 2);

            Console.WriteLine(raiz + " " + potencia);


            // CLASES ANONIMAS
            /*
             Syntax
            tipo de dato var
            instancia de la clase con new
            llave y dentro sus propiedades con sus respectivos valores pero sin designar tipos de datos.
             */
            var miVariable = new { Nombre = "Eduardo", Edad = 19 };

            // Acceso a esa clase anónima con su variable

            Console.WriteLine(miVariable.Nombre);
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(1, 1);

            double distancia = origen.DistanciaEntrePuntos(destino);

            Console.WriteLine(distancia);

            Console.WriteLine($"Número de objetos creados: {Punto.ContadorObjetos()}");

            int test = Punto.constantePrueba;
        }
    }
}
