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
                " FROM COCHERAS c" +
                " WHERE c.borrado_logico = 0" +
                " AND c.numero NOT IN(SELECT c.numero" +
                                    " FROM RESERVA r" +
                                    " JOIN COCHERAS c ON(r.numero_cochera = c.numero)" +
                                    " WHERE r.borrado_logico = 0" +
                                    " AND r.fecha_hora_ingreso_estimada >= CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                    " AND r.fecha_hora_salida_estimada <= CONVERT(DATETIME, '" + fechaSalida + "', 103))";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarHabitacionesLibres(string fechaIngreso, string fechaSalida)
        {

            string consulta = "SELECT h1.numero, t.nombre as tipo, h1.piso, h1.precio, t.descripcion" +
                    " FROM HABITACIONES h1" +
                    " INNER JOIN TIPO_HABITACION t ON (h1.tipo_habitacion = t.cod_tipo)" +
                    " WHERE h1.borrado_logico = 0" +
                    " AND h1.numero NOT IN" +
                                           " (SELECT h.numero FROM HABITACIONES h INNER JOIN DETALLE_RESERVA d ON (h.numero = d.numero_habitacion)" +
                                           " INNER JOIN RESERVA r ON(d.id_reserva = r.id_reserva)" +
                                           " WHERE r.borrado_logico = 0" +
                                           " AND r.fecha_hora_ingreso_estimada >= CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                           " AND r.fecha_hora_salida_estimada <= CONVERT(DATETIME, '" + fechaSalida + "', 103))";
                                        
                    consulta += " ORDER BY t.cod_tipo";
            
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);



        }
    }
}
