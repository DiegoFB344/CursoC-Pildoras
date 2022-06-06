using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);
            int miRespuesta;
            int intentos = 0;

            Console.WriteLine("Cual es el numero que genere" +
                "Consigue un premio" +
                    "Sigue así");

            do
            {
                // las Exception van de la mas especifica hacia las genéricas
                // Generalmente solo puedes mandar las exception genéricas al ultimo pero con 
                // los filtros esto nos ayuda a poder configurar las exception especificas
                try
                {
                    miRespuesta = int.Parse(Console.ReadLine());
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Dato no valido Overflow");
                    miRespuesta = -1;
                }
                // filtros excepciona
                catch (Exception ex) when (ex.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Dato no valido Exception General");
                    // Lanzar en consola el mensaje del error (ingles)
                    Console.WriteLine(ex.Message);
                    miRespuesta = -1;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Dato no valido Format");
                    miRespuesta = -1;
                }

                intentos++;

                if (miRespuesta < numeroAleatorio) Console.WriteLine("El numero es mayor, intenta otra vez");
                if (miRespuesta > numeroAleatorio) Console.WriteLine("El numero es menor, intenta otra vez");

            } while (numeroAleatorio != miRespuesta);

            Console.WriteLine($"El numero que genere es: {numeroAleatorio}, excelente trabajo solo te costo {intentos} intentos");


            Console.WriteLine("A partir de aquí continuara el programa");


            // Mandar o forzar la revision de alguna exception que por defecto pudiera pasarse
            /*
             Configurar cheeked por defecto con el depurador de VS
            En el explorador de la solución hacemos click derecho a nuestra solución del proyecto y
            en el menu contextual seleccionamos propiedades > compilación > avanzadas > comprobar el desbordamiento aritmético
             */
            checked
            {
                int num = int.MaxValue;
                int resultado = num + 20;
                Console.WriteLine(resultado);
            }


        }
    }
}
