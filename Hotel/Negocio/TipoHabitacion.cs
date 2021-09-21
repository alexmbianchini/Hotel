using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class TipoHabitacion
    {
        public int CodTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool BorradoLogico { get; set; }


    }

}
