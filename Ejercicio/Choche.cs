using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Choche : Vehiculo
    {
        // Constructor
        public Choche(string nombreVehiculo) : base(nombreVehiculo)
        {

        }

        public string Acelerar(string sonidoAcelarar) => $"Acelerando {sonidoAcelarar}";
        public string Frenar(string sonidoFrenando) => $"Frenando {sonidoFrenando}";

        public override void Conducir()
        {
            base.Conducir();
            Console.WriteLine("Ahora estas manejando el AUTO");
        }
    }
}
