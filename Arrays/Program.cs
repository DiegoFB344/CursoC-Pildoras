using System;

namespace Arrays
{
    class Program
    {
        // Estructura de datos que contiene una colección de valores del mismo tipo.
        // Se utiliza par aguardar valores que tiene alguna relación entre si (la edad de los empleados)
        /*
         Syntax:
            int[] miMatriz;
            miMatriz = new int[5];

            int[] miMatriz = new int[5];

            Dando valores, el array tiene posiciones o indices y esta empieza en la posición [0

            miMatriz[0] = 15;

            Se pueden rellenar con de manera dinámica.

            int[] miMatriz = {5,3,6,1,34,};
            
         */


        static void Main(string[] args)
        {
            // Array limitada ya que indicas cuantos elementos habrá.
            int[] edades = new int[2] { 5, 2 };

            // Array implícito
            var dato = new[] { "Juan", "Mexico" };

            // Array de objeto
            Empleado[] arrayEmpleados = new Empleado[2];

            // Inicialización el array con la instancia de Empleado
            arrayEmpleados[0] = new Empleado("Eduardo", 20);

            Empleado Ana = new Empleado("Ana", 20);

            arrayEmpleados[1] = Ana;

            // Array de tipos o clases anónimas

            var personas = new[]
            {
                new { Nombre = "Juan", Edad = 49 },
                new { Nombre = "Diana", Edad = 20 },
                new { Nombre = "Perla", Edad = 40 },
            };

            Console.WriteLine(personas[1]);

            ForLoop.recorreLoop(dato);

            ForLoop forLoop = new ForLoop();

            forLoop.recorreLoop2(edades);


            foreach (var item in personas)
            {
                Console.WriteLine(item.Nombre);
            }

            foreach (var item in arrayEmpleados)
            {
                Console.WriteLine(item.GetInfo());
            }


            int[] array = forLoop.LeerDatos();


            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        class Empleado
        {
            string nombre;
            int edad;

            // Method access
            public string GetInfo() => $"Nombre del empleado: {nombre} y su Edad: {edad}";


            public Empleado(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        }
    }
}
