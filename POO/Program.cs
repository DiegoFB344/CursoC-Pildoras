using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo; // creación de un objeto de tipo Circulo, Variable/objeto tipo circulo

            //Instanciación, Ejemplarizar, Instancia de una clase
            miCirculo = new Circulo(); // Inicialización de la variable/objeto tipo Circulo

            double resultado = miCirculo.calcularArea(5);
            Console.WriteLine(resultado);


            Circulo miCirculo2 = new Circulo();

            ConversorEurosDolar converso = new ConversorEurosDolar();

            double resultadoConverso = converso.convierte(10);
            Console.WriteLine(resultadoConverso);

        }

    }

    // Creando nuestra clase
    class Circulo
    {
        double pi = 3.1416; // Propiedad de la clase, campo de clase

        // Método para calcular su area
        public double calcularArea(int radio) => pi * radio * radio;
    }

    // Utilidad para el encapsulamiento
    class ConversorEurosDolar
    {
        public double euro = 12;

        public double convierte(double cantidad) => cantidad * euro;

        // Método de acceso y las ventajas es que puedes programar un comportamiento para hacer los cambios
        public void CambiarEuro(float nuevoValor)
        {
            if (nuevoValor > 0) euro = nuevoValor;
            else euro = 12;
        }
    }
}
