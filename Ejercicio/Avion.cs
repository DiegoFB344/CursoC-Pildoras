using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Avion : Vehiculo
    {
        // Generando el constructor
        public Avion(string nombreAvion) : base(nombreAvion)
        {

        }

        public string Despegar(string sonidoDespegando) => $"Despegar {sonidoDespegando}";
        public string Aterrizando(string sonidoAterrzando) => $"Aterrizando {sonidoAterrzando}";
        public override void Conducir() => Console.WriteLine("Ahora estas manejando el AVION");
    }
}
