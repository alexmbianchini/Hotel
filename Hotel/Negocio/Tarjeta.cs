using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Tarjeta
    {
        public int IdTarjeta { get; set; }

        public int NroTarjeta { get; set; }

        public int CodTipoTarjeta { get; set; }

        public DateTime FechaCaducidad { get; set; }

        public string NroPasaporte { get; set; }

        public bool BorradoLogico { get; set; }
    }
}
