using Hotel.Datos.Dao;
using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Servicios
{
    class ReservaService
    {
        private IReserva dao;
        public ReservaService()
        {
            dao = new ReservaDao();
        }

        public DataTable RecuperarCocherasLibres(string fechaIngreso, string fechaSalida)
        {
            return dao.RecuperarCocherasLibres(fechaIngreso, fechaSalida);
        }
        public DataTable RecuperarHabitacionesLibres(string fechaIngreso, string fechaSalida)
        {
            return dao.RecuperarHabitacionesLibres(fechaIngreso, fechaSalida);
        }
        public int Crear(Reserva oReserva, List<DetalleReserva> oDetalle)
        {
            return dao.Crear(oReserva, oDetalle);
        }
    }
}
