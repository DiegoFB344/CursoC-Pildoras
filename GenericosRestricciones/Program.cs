using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleado<Secretaria> empleados = new AlmacenEmpleado<Secretaria>(3);

            empleados.Agregar(new Secretaria(1500));
            empleados.Agregar(new Secretaria(2500));
            empleados.Agregar(new Secretaria(3500));
        }
    }

    // Clase Genérica con Restricción
    class AlmacenEmpleado<T> where T : IEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;

        public AlmacenEmpleado(int z)
        {
            datosEmpleado = new T[z];
        }


        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T GetEmpleadio(int i)
        {
            return datosEmpleado[i];
        }
    }

    class Director : IEmpleados
    {
        private double salario;

        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Secretaria : IEmpleados
    {
        private double salario;

        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    interface IEmpleados
    {
        double GetSalario();
    }
}
