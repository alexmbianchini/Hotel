using Hotel.Datos.Dao;
using Hotel.Datos.Interfaces;
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
    }
}
