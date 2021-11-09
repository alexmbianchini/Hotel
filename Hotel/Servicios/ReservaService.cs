using Hotel.Datos.Dao;
using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int Crear(Reserva oReserva, BindingList<DetalleReserva> oDetalle)
        {
            return dao.Crear(oReserva, oDetalle);
        }

        public DataTable RecuperarReservadas()
        {
            return dao.RecuperarReservadas();
        }

        public DataTable RecueperarDetallesReservaEspecifica(int numeroReserva)
        {
            return dao.RecueperarDetallesReservaEspecifica(numeroReserva);
        }

        public bool Cancelar(int numeroReserva)
        {
            return dao.Cancelar(numeroReserva);
        }

        public DataTable RecuperarReservasParaCancelarFiltradas(string pasaporte, string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarReservasParaCancelarFiltradas(pasaporte, fechaDesde, fechaHasta);
        }
        public bool ValidarFechas(DateTime fechaIngreso, DateTime fechaSalida)
        {
            if (fechaIngreso >= DateTime.Today
                && fechaIngreso < fechaSalida)
            {
                return true;
            }
            return false;
        }

        public bool ValidarFechaDesdeMenorFechaHasta(DateTime fechaDesde, DateTime fechaHasta)
        {
            if(fechaDesde <= fechaHasta)
            {
                return true;
            }
            return false;
        }

        public DataTable RecuperarDatosReservaReporte(string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarDatosReservaReporte(fechaDesde, fechaHasta);
        }
        public DataTable RecuperarDatosTipoHabitacionReservada(string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarDatosTipoHabitacionReservada(fechaDesde, fechaHasta);
        }

        public DataTable RecuperarDatosReservaCochera(string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarDatosReservaCochera(fechaDesde, fechaHasta);
        }

        public DataTable RecuperarParaReportePaises(string fechaDesde, string fechaHasta, int pais)
        {
            return dao.RecuperarParaReportePaises(fechaDesde, fechaHasta, pais);
        }

        public DataTable RecuperarDatosReservaCocheraXNroHabit(string fechaDesde, string fechaHasta)
        {
            return dao.RecuperarDatosReservaCocheraXNroHabit(fechaDesde, fechaHasta);
        }
    }
}
