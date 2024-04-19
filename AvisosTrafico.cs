using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class AvisosTrafico : IAvisos
    {
        public AvisosTrafico() {

            remitente = "DGT";

            mensaje = "Sanción cometida. Pague antes de 3 dias para paragar la mitad";

            fecha = "";
        
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAvisos()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2}",mensaje,remitente,fecha);
        }

        private string remitente;
        private string mensaje;
        private string fecha;

    }
}
