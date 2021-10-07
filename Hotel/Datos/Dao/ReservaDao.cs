using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class ReservaDao : IReserva
    {
        public DataTable RecuperarCocherasLibres(string fechaIngreso, string fechaSalida)
        {

            string consulta = "SELECT c.numero, c.precio" +
                " FROM RESERVAS r" +
                " JOIN COCHERAS c ON (r.numero_cochera = c.numero)" +
                " WHERE c.borrado_logico = 0" +
                " AND r.fecha_hora_ingreso_estimada >= CONVERT(DATETIME,'" + fechaIngreso + "', 103)" +
                " AND r.fecha_hora_salida_estimada <= CONVERT(DATETIME, '" + fechaSalida + "', 103)";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
    }
}
