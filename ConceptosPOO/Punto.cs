using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPOO
{
    class Punto
    {
        // Sobrecarga de constructores
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }


        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorObjetos++;

            Console.WriteLine($"Coordenada X: {x} \n Coordenada Y: {y}");
        }

        
        /*
         *  Este método con los this. dentro indica que referencia a al objeto que lo este invocando.
         *  Ademas este meto es llamado con objetos o instancia al objeto ya que no es un método static
         */
        public double DistanciaEntrePuntos(Punto punto)
        {
            int xDif = this.x - punto.x;
            int yDif = this.y - punto.y;

            double resultado = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return resultado;
        }


        // Método estático de acceso
        public static int ContadorObjetos() => contadorObjetos;

        // ##### VARIABLES ####
        private int x, y;


        // Las variables static sirven para compartir el valor de la misma entre todos las que la usa
        // Por convención sabemos que hay que llamarlas con un método de acceso
        // La variable tiene que ser static pero no necesariamente el método.
        private static int contadorObjetos = 0;

        // En c# todas las constantes son static sin tener que usar la palabra reservada static.
        public const int constantePrueba = 5;
    }
}
