using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class AvisosTrafico : IAvisos
    {

        // Constructores

        public AvisosTrafico()
        {
            remitente = "DGT";

            mensaje = "Sección cometida: Page antes de 3 días y recibiera un descuento del 50%";

            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }



        // Clases obligadas por la Interface
        public string FechaAviso()
        {
            return fecha;
        }

        public void MostraAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}", mensaje, remitente, fecha);
        }


        // Campo de clase encapsulado
        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
