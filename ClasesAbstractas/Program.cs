using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagartija juancho = new Lagartija("Juancho");
            juancho.GetNombre();


            Humano Juan = new Humano("Juan");
            Juan.GetNombre();
        }
    }
}
