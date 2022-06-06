using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Juan = new Empleado("Juan");

            // Sintaxis sin la propiedad
            /*Juan.SetSalario(1200);

            double salario = Juan.GetSalario + 5500;

            Console.WriteLine($"El salario de {Juan.GetNombre()} es: {Juan.GetSalario()}");*/

            // CON LA PROPIEDAD
            Juan.SALARIO = 12909;
            Juan.SALARIO += 500;
            Console.WriteLine("El salario de Juan es: " + Juan.SALARIO);

        }
    }

    class Empleado
    {

        // Por convención a las variables privadas que serán parte de una propiedad
        // Las ponen generalmente con un _variable para reconocerlas fácilmente en el código
        private string _nombre;
        private double _salario;

        // constructor

        public Empleado(string nombre)
        {
            this._nombre = nombre;
        }

        // Sintaxis sin la propiedad

        /*public void SetSalario(double salario)
        {
            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo se asignara 0 como salario");
                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }

        public double GetSalario()
        {
            return salario;
        }

        public string GetNombre()
        {
            return nombre;
        }*/



        /*
         * CREACIÓN DE PROPIEDADES
         * Nos permite acceder directamente a la propiedad como si fuera un campo de clase public,
         * pero a la vez nos impide romper reglas que hemos creado
         */

        public double SALARIO
        {
            //get { return salario; }
            // expression bodied
            //set { _salario = EvaluaSalario(value); }
            get => _salario;
            set => _salario = EvaluaSalario(value);
        }

        private double EvaluaSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }
    }
}
