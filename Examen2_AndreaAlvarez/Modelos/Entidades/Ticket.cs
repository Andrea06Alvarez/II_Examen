using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_AndreaAlvarez.Modelos.Entidades
{
    public class Ticket
    {
        public int Codigo { get; set; }

        public string NombreCliente { get; set; }

        public DateTime Fecha { get; set; }

        public int CantidadDeTicket { get; set; }

        public string TipoDeSoporte { get; set; }

        public string NombreEstado { get; set; }
    }
}
