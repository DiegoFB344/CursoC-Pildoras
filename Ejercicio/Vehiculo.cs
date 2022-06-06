using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    // Clase Padre o superclass
    class Vehiculo
    {
        // Constructor

        string tipoVehiculo;
        bool motorEncendido;

        public Vehiculo(string tipoVehiculo)
        {
            motorEncendido = false;
            this.tipoVehiculo = tipoVehiculo;

            Console.WriteLine($"El vehículo seleccionado es: {tipoVehiculo} y el vinculo esta: {motorEncendido}");
        }


        public void EncenderMotor()
        {
            motorEncendido = true;
            Console.WriteLine($"El motor ahora esta encendido Motor: {motorEncendido}");
        }

        public void ApagarMotor()
        {
            motorEncendido = false;
            Console.WriteLine($"El motor ahora esta apagado Motor: {motorEncendido}");
        }

        public virtual void Conducir() => Console.WriteLine("Preparara para manejar tu vehículo: " + tipoVehiculo);
    }
}
