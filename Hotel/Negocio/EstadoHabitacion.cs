using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class EstadoHabitacion
    {
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
        public bool BorradoLogico { get; set; }


    }
}
