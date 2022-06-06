using System;

namespace ConceptosBasicos
{
    //Clases propias
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 5;

            // Clase predefinida
            Console.WriteLine("Hello World!");

            // Interpolador de strings
            Console.WriteLine($"Tienes una edad de {edad} edad");


            // Conversión explícita (casting)
            double numero1 = 2.5;
            int casting;

            casting = (int)numero1;

            // conversion implícita
            int numero2 = 101000;
            long implicita = numero2;

            // Cambiando string a tipos de datos numéricos primitivos
            Console.WriteLine("Put a number");

            // Guardamos el resultado en una variable para poder utilizarla después
            // ReadLine devuelve un string

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Put a second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tu edad es {num + num2}");


            // CONSTANTES
            /*
             * Espacio en memoria del ordenador donde se almacenara
             * un valor que no podrá cambiar durante la ejecución del programa
             * 
             * Buenas practicas escribir el nombre de la constante en mayúsculas
             */

            const int VALOR = 5;
            const int VALOR2 = 5;

            Console.WriteLine("El valor de la constante es {0} y {1}", VALOR, VALOR2);

            // llamando a nuestro método
            mensajeEnPantalla();
            sumaDosNumeros(2, 5);
            sumaFloat(3, 56);
        }

        // MOETODOS
        /*
         * - Son grupos de sentencias (instrucciones) que se les da un nombre identificativo, que realizara una tarea en concreto
         * - Sirven para realizar una tarea en un momento determinado, hasta que es llamado.
         * - Syntax:
         *  typeReturn nameMethod (parameter) {
         *      body of method;
         *  }
         *  
         *  Método o función en C# serian lo mismo
         *  para la aplicación en consola las funciones que creemos serán llamadas desde el método main (el principal) para ser ejecutada
         *  
         *  De momento pondremos la palabra becerrada static antes del método para poder llamarlo en el método main
         *  ya que si no lo hacemos nos saldrá un error por que pide que se ejecute una referencia al objeto.
         */


        static void mensajeEnPantalla()
        {
            Console.WriteLine("Este es un método nuevo");
        }

        static int sumaDosNumeros(int num1, int num2)
        {
            int resultado;
            resultado = num1 + num2;

            // Siempre llevan la palabra return para devolver el tipo de dato
            return resultado;
        }

        // Usando el curso de expresiones para el método con landa (=>)
        static float sumaFloat(int num1, float num2) => num1 / num2;


        // Sobrecarga de métodos
        /*
         * Características:
         * - Tener diferente numero de parámetros. O
         * - Tener diferentes tipos de datos como parámetros.
         * 
         * El método que llamara dependerá de los parámetros que le pases
         */
        static int suma(int operador1, int operador2) => operador1 + operador2;
        static int suma(int operador1, int operador2, int numero3) => operador1 + operador2 + numero3;
        static float suma(float operador1, int operador2) => operador1 + operador2;
    }
}
