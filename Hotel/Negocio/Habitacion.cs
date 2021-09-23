using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Habitacion
    {
        public int Numero { get; set; }
        public int Piso { get; set; }
        public int TipoHabitacion { get; set; }
        public float Precio { get; set; }
        public bool BorradoLogico { get; set; }
        public bool Estado { get; set; }


    }


}


