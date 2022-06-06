using System;
using System.Collections.Generic;
using System.Text;

namespace DelgadoPredicadLamna
{
    /*
     * DELEGADOS
     * 
     * Funciones que delegan tareas a otras funciones
     * Muy similares a los apuntadores en C++
     * Un delegado es un apuntador a un método
     * 
     * LLamada a eventos
     * Se reduce significativamente el código al manejar diferentes escenarios
     * Código muy reutilizable
     * 
     * SINTAXIS
     * 
     * delegate tipoDato NombreDelegado(argumentos);
     * 
     * Solo podrá llamar métodos con la misma estructura
     */
    class Delegados
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola, Bienvenido!");
        }

        internal static void SaludoDespedida()
        {
            Console.WriteLine("Hasta luego");
        }
    }
}
