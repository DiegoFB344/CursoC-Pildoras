using System;

namespace POO_Constructores
{
    // CONSTRUCTORES
    // Tiene como finalidad dar un estado inicial al momento de crear un objeto o la instancia de la clase
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crear objeto o instancia de tipo Coche()
             * dar un estado inicial de nuestro coche
             * La palabra reservada new nos ayuda a llamar al constructor
             */
            Coche coche1 = new Coche();

            Console.WriteLine(coche1.GetString());

            Coche coche2 = new Coche(2.3, 3);

            Console.WriteLine(coche2.GetString());

            coche2.SetExtras(true, "Cuero");

            Console.WriteLine(coche2.GetExtras());
        }
    }

    class Coche
    {
        /*
         * Constructor
         * Un método algo especial
         * Tine el mismo nombre que la clase
         * El método no puedo devolver ningún dato
         * No puede ser void
         * Puedes hacer sobrecarga de constructores tipo el de métodos.
         * 
         */
        public Coche()
        {
            ruedas = 4;
            largo = 250.45;
            ancho = 80.834;
        }

        public Coche(double largoCoche, int anchoCoche)
        {
            ruedas = 4;
            ancho = anchoCoche;
            largo = largoCoche;

        }


        // Recordemos que para tener acceso a nuestras propiedad usamos los métodos de acceso
        // Son muy útiles para poder obtener el valor de nuestra variable sin poder modificar su valor (solo lectura)
        public string GetString() => $"Info del coche:\n Ruedas: {ruedas} \n Largo: {largo} \n Ancho: {ancho}";


        // ############ SETER and GETER ##########
        // Método de acceso para modificar el valor de alguna variable encapsulada.
        public void SetExtras(bool paraClima, string paraTapiceria)
        {
            climatizador = paraClima;
            tapiceria = paraTapiceria;
        }

        public string GetExtras() => $"Extras de coche: \n Tapicería: {tapiceria} \n Clima: {climatizador}";


        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private string tapiceria;
    }
}
