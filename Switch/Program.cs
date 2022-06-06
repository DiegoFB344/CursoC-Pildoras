using System;

namespace Switch
{
    class Program
    {
        private const string message = "Escribe tu opción";

        static void Main(string[] args)
        {
            /*
            Condicional Switch

            Syntax:


            Switch (expresión de control) {
                case expresión constante:
                    código a realizar
                    break;
                case expresión constante:
                    código a realizar
                    break;
                default:
                    código a realizar
                    break;
            }
             */

            Console.WriteLine(message);
            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad máxima 250km/h");
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
