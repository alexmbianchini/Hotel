using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IReserva
    {
        DataTable RecuperarCocherasLibres(string fechaIngreso, string fechaSalida);

        DataTable RecuperarHabitacionesLibres(string fechaIngreso, string fechaSalida);
        int Crear(Reserva oReserva, BindingList<DetalleReserva> oDetalle);

        DataTable RecuperarReservadas();

        DataTable RecueperarDetallesReservaEspecifica(int numeroReserva);

        bool Cancelar(int numeroReserva);

        DataTable RecuperarReservasParaCancelarFiltradas(string pasaporte, string fechaDesde, string fechaHasta);

    }
}
