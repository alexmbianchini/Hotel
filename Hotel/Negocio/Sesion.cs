using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Sesion
    {
        public int IdSesion { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public int IdUsuario { get; set; }
        public bool BorradoLogico { get; set; }

    }
}
