using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class DetalleReserva
    {
        public int IdDetalle { get; set; }
        public int IdReserva { get; set; }
        public int NroHabitacion { get; set; }
        public float PrecioUnitarioHabitacion { get; set; }
        public bool BorradoLogico { get; set; }
    }
}
