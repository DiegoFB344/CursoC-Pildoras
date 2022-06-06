using System;

namespace Genericos
{
    /*
     * PROGRAMACIÒN GENÈRICA
     * 
     * Su principal uso es la re utilización del código
     * - Sencillez en el código.
     * - Re-utilización del código en numerosos escenarios.
     * - Comprobación de errores en tiempo de compilación.
     */



    class Program
    {
        static void Main(string[] args)
        {
            //AlmacenObjeto archivo = new AlmacenObjeto(4);
            //Utilizando la clase genérica
            AlmacenObjeto<Empleado> archivo = new AlmacenObjeto<Empleado>(4);

            /*archivo.Agregar("Antonio");
            archivo.Agregar("Elena");
            archivo.Agregar("Juan");
            archivo.Agregar("Sandra");*/

            //string nombrePersona = (string)archivo.getElement(2);

            archivo.Agregar(new Empleado(1500));
            archivo.Agregar(new Empleado(2500));
            archivo.Agregar(new Empleado(3500));
            archivo.Agregar(new Empleado(4500));

            //Empleado salarioEmpleado = (Empleado)archivo.getElement(2);
            //Ahora podemos prescindir del casting
            Empleado salarioEmpleado = (Empleado)archivo.getElement(2);

            Console.WriteLine(salarioEmpleado.GetSalario());
        }
    }


    /*
     * Creando una clase genérica
     * Se utiliza después del nombre de la clase los elementos <T> la letra es por convención.
     */
    class AlmacenObjeto<T>
    {
        private T[] datosElemento;
        //private object[] datosElemento;
        private int i = 0;


        public AlmacenObjeto(int z)
        {
            datosElemento = new T[z];
            //datosElemento = new object[z];
        }

        //public void Agregar(object obj)
        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public object getElement(int i)
        {
            return datosElemento[i];
        }
    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
}
