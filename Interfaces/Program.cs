using System;

/* INTERFACES
    Son conjuntos de directrices que deben cumplir las clases
    Las  clases pueden implementar las interfaces que nosotros creemos
    Podemos hacer que una clase herede de una interfaz

    Es parecido a una clase pero en las interface veremos como solo existen las definiciones de los método
    Es decir las directrices a seguir por una clase o comportamientos.
*/

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Ballena wally = new Ballena("Wally");

            wally.Nadar();

            Caballo spirit = new Caballo("Spirit");


            // Principio de sustitución
            IMamiferosTerrestres Ispirit = spirit;


            Console.WriteLine($"El numero de patas de un caballo es: {Ispirit.NumeroPatas()}");


            // Utilizando la clase Aviso
            AvisosTrafico av1 = new AvisosTrafico();

            av1.MostraAviso();

            AvisosTrafico av2 = new AvisosTrafico("GMAdrid", "Velocidad accedida del limite", "23/02/202");

            av2.MostraAviso();
        
        }
    }

    // Implementando interface
    interface IMamiferosTerrestres
    {
        // Métodos de la interfaz syntax
        /*
            Restricciones:
                - Variable
                - Constructores
                - Destructores
                - Modificador de acceso (public por defecto)
                - Anidamiento de clases o estructuras
         */
        int NumeroPatas();
    }

    interface IMamiferosYDeportes
    {
        string TipoDeporte();
        bool EsOlimpico();
    }

    // GENERANDO ABIGUEDAD DE INTERFACE
    // Interfaces con métodos iguales
    interface ISaltoConPatas
    {
        int NumeroPatas();
    }

    class Mamifero
    {
        string nombre;

        public Mamifero(string nombre)
        {
            this.nombre = nombre;
        }

        public void Respirar()
        {
            Console.WriteLine("Yo puedo respirar");
        }
    }

    class Ballena : Mamifero
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy Capaz de Nadar");
        }

    }

    // Primero va la clase a heredar y después las interfaces que quieres que implemente una clase separadas por coma
    class Caballo : Mamifero, IMamiferosTerrestres, IMamiferosYDeportes, ISaltoConPatas
    {
        const int entero = 4;
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        // La interfaz nos obliga a utilizar un método pero a nuestra manera
        /*public int NumeroPatas()
        {
            return 4;
        }*/

        public string TipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico() => true;

        // Generando la ambigüedad con las interfaces
        // Syntax, Aunque no se podrán llamar de manera publica en otras clases
        // Lo podríamos hacer con el principio de sustitución de la herencia o polimorfismo
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }
}
