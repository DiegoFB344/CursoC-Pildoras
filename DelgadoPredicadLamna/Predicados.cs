using System;
using System.Collections.Generic;
using System.Text;

namespace DelgadoPredicadLamna
{
    /*
     * PREDICADOS
     * 
     * Son delegados que devuelven true o false
     * Muy utilizados para filtrar listas de valores comprobando si una condición es cierta para un valor dado
     * 
     * SINTAXIS
     * Predicate<T> NombrePredicado = new Predicate<T>(FunciónDelegado);
     */
    class Predicados
    {
        public static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
    }
}
