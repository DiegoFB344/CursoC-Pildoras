using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo babieca = new Caballo("Babieca");
            Humanos humano = new Humanos("Lalo");
            Gorila copito = new Gorila("Carlos el gorila");

            humano.GetNombre();


            // PRINCIPIO DE SUSTITUCION (ES SIEMPRE UN)
            Mamifero animal = new Caballo("Caramel");
            Mamifero persona = new Humanos("Pedro");

            // Super clase cósmica de la biblioteca API .NET de la cual heredan todas las demás clases
            Object miAnimal = new Caballo("Spirit");

            // Ejemplo de utilidad
            // La forma de guardar un array de diferentes instancias o clases es haciendo una sustitución 
            // en la cual podemos poner de forma jerarquice las super clases

            Mamifero[] array = new Mamifero[] { babieca, humano, copito };


            array[0].GetNombre();

            foreach (var item in array)
            {
                item.Pensar();
            }
        }
    }

    class Mamifero
    {

        private string name;

        // constructor
        public Mamifero(string name)
        {
            this.name = name;
        }

        /*
         PROTECTED MODIFICADOR DE ACCESO
            Son accesibles desde la clases y desde aquellas que heredan mientras que de las otras no son accesibles
         */
        protected void CuidarCrias() => Console.WriteLine("Cuido a mis crías");

        public void TomarAgua() => Console.WriteLine("Tomando agua");

        public void GetNombre() => Console.WriteLine($"El nombre del ser vivo es: {name}");


        /*
             ########## POLIMORFISMO ############
         */

        // OCULTACIÓN de métodos para las clases heredadas
        // Al poner un método que puedes utilizar como heredado, también puedes poner el mismo 
        // método en las clases hijas y hay algunas palabras reservadas para poder reutilizar o sobre escribir el método de la clase padre


        /*
        * Para modificar el método padre o para decir algo agregar ademas de lo que ya contiene
        * mas comportamientos o código que puede afectar a nuestro hijo de manera diferente pero 
        * respetando el comportamiento por defecto que le hemos dado a nuestro método padre.
        * 
        */

        // usamos la palabra reservada virtual para que nuestro método pueda ser modificado
        // al momento de ser llamada en otras clases heredadas.
        public virtual void Pensar() => Console.WriteLine("Método de nuestra clase padre MAMIFEROS");
    }


    class Caballo : Mamifero
    {
        // Constructor
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar() => Console.WriteLine("Puedo galopar");

        public override void Pensar() => Console.WriteLine("Método de nuestra clase Caballo el cual esta con override pero sin base.Pensar()");


        // PROTECTED
        // Debes de instancia una clase u objeto del tipo heredado ya que ahora nuestra varia o método ahora es protected y es accesible en las clases heredadas

        public void Respirar()
        {
            CuidarCrias();

            var miMamifero = new Caballo("");

            miMamifero.CuidarCrias();
        }



    }

    class Humanos : Mamifero
    {
        public Humanos(string nombreHumano) : base(nombreHumano)
        {

        }

        // Aquí nos da una advertencia VS que nos indica que tenemos un método que existe en la clase padre o heredada
        // Lo que dice es que sobrescribiera o sustituirá el método hijo por el del padre.
        // Pero si ponemos la palabra reservada 'new' antes del método le decimos a VS que estamos enterado y quitara la advertencia.
        // Amenos que como ya sabemos hagamos una sobrecarga de métodos poniendo diferentes parámetros o cambiando el tipo de dato
        new public void Pensar() => Console.WriteLine("Método de clase Humano sobre escrita con la palabra clave new");
    }

    class Gorila : Mamifero
    {
        /*
            Constructor :base, esto significa que si modificamos el constructor por defecto del padre
            nos pedirá que agreguemos un constructor a nuestro hijo ya que no tiene el constructor por defecto y clase no funcionara
            public Constructor(){}; por defecto.
         */
        public Gorila(string nombreGorila) : base(nombreGorila) { }

        public void trepar()
        {
            Console.WriteLine("Puedo trepar");
        }


        /*
            Utilizando la modificación de un método heredado padre y utilizamos la palabra clave 'override'
         */

        public override void Pensar()
        {
            // Usamos la siguiente instrucción para poder insertar el programa predefinido
            // en pocas palabras es pasar todo lo que tenga dentro ese método y después hacer lo nuestro.
            // si no lo ponemos lo que haremos seria sobre escribir el método osea seria como si la hiciéramos de nuevo
            base.Pensar();
            Console.WriteLine("Método de la clase Gorila agregando la base.Pensar() para sumar el comportamiento por defecto");

        }

    }
}
