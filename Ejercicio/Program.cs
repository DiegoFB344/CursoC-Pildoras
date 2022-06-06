using System;

namespace Ejercicio
{
    /* EJERCICIO
     * Creación de 3 clases
     * - Avión
     * - Vehículo
     * - Coche
     * Métodos comunes a las 3 clases
     * - Arrancar Motor
     * - Parar Motor
     * Método virtual
     * - conducir
     */
    class Program
    {
        static void Main(string[] args)
        {
            var coche = new Choche("Ferrai");
            var avion = new Avion("Jet");

            Console.WriteLine();

            coche.Conducir();
            coche.EncenderMotor();
            Console.WriteLine(coche.Acelerar("rrrruuuuuuunnnn"));
            Console.WriteLine(coche.Frenar("wiiiiiiichhh"));
            coche.ApagarMotor();

            Console.WriteLine();

            avion.Conducir();
            avion.EncenderMotor();
            Console.WriteLine(avion.Despegar("rrrruuuuuuunnnn"));
            Console.WriteLine(avion.Aterrizando("wiiiiiiichhh"));
            avion.ApagarMotor();

            Console.WriteLine();

            Console.WriteLine("Utilizando el polimorfismo");

            Vehiculo miVehiculo = coche;
            miVehiculo.Conducir();
            miVehiculo = avion;
            miVehiculo.Conducir();
        }
    }
}
