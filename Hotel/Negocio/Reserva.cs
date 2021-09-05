using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime FechaHoraReserva { get; set; }
        public string PasaporteHuesped { get; set; }
        public DateTime FechaHoraIngresoEstimada { get; set; }
        public DateTime FechaHoraIngresoReal { get; set; }
        public DateTime FechaHoraSalidaEstimada { get; set; }
        public DateTime FechaHoraSalidaReal { get; set; }
        public int IdUsuario { get; set; }
        public string PatenteVehiculo { get; set; }
        public int CantidadPersonas { get; set; }
        public int Estado { get; set; }
        public int NumeroCochera { get; set; }
        public float PrecioUnitarioCochera { get; set; }
        public bool BorradoLógico { get; set; }

    }
}


