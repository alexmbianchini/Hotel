using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class DetalleServicioCuenta
    {
        public int NroCuenta { get; set; }
        public int NroHabitacion { get; set; }
        public int CodProducto { get; set; }
        public float PrecioUnitario { get; set; }
        public DateTime FechaHora { get; set; }
        public bool BorradoLogico { get; set; }
        public int IdDetalle { get; set; }
    }
}
