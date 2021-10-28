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
    class DetalleServicioCuentaService
    {
        private IDetalleServicioCuenta dao;
        public DetalleServicioCuentaService()
        {
            dao = new DetalleServicioCuentaDao();
        }

        public DataTable RecuperarDatosInforme(string fechaInicio, string fechaFin)
        {

            return dao.RecuperarDatosInforme(fechaInicio, fechaFin);
        }
    }
}
