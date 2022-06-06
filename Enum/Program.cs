using System;

namespace Enum
{
    /* ENUM
     * Son un conjunto de constantes con nombre
     * Para representar y manejar valores fijos (constantes) en un programa
     * Generalmente son creadas en name space fuera de la clase principal 
     * para ser utilizada por las demás clases que creemos.
     */

    enum Bonus
    {
        Primavera=1000, Verano, Otoño, Invierno
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bonus antonio = Bonus.Invierno;
            double salarioAntonio = (double)antonio;
            Console.WriteLine(salarioAntonio);

            Empleado juan = new Empleado(Bonus.Invierno, 3000);
            Console.WriteLine("El salario del empelado es: " + juan.SALARIO);
        }
    }

    class Empleado
    {
        private double salario, bonus;

        public double SALARIO
        {
            get => salario + bonus;
        }

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;
            this.salario = salario;
        }
    }
}
