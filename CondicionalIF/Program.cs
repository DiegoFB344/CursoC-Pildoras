using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Operadores de comparación
                == Igual que
                != Diferente que
                <  Menor que
                <= Menor o igual que
                >  Mayor que
                >= Mayor o igual que

            Operadores lógico
                && Y lógico
                || O lógico

            Estructuras de control de Flujo (controlan el flujo de ejecución)
                Condicionales (if, else, else if)
                loops
            */


            /*
            IF Syntax

            if(condición) {
                instrucción si se cumple la condición
            }

            if(condition) instruction if the condition is true

             */


            // inicialización de la variable ya que si no podremos usarla en el siguiente if ya que depende del if anterior para su inicialización
            //string carnet = "";

            Console.WriteLine("Vamos ha evaluar si puedes conducir");
            Console.WriteLine("Introduce tu edad");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Tienes Carnet");
                string carnet = Console.ReadLine();

                // Condicionales anidados
                if (carnet == "si") Console.WriteLine("PUEDES MANEJAR");
                else Console.WriteLine("NO PUEDES MANEJAR");
            }

            // otra manera arriba^
            //if (carnet == "si") Console.WriteLine("PUEDES MANEJAR");
            //else Console.WriteLine("NO PUEDES MANEJAR");

        }
    }
}
