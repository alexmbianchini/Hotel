using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                                    " OR r.fecha_hora_salida_estimada <= CONVERT(DATETIME, '" + fechaSalida + "', 103))";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        /*public DataTable RecuperarHabitacionesLibres(string fechaIngreso, string fechaSalida)
        {

            string consulta = "SELECT h1.numero, t.nombre as tipo, h1.piso, h1.precio, t.descripcion" +
                    " FROM HABITACIONES h1" +
                    " INNER JOIN TIPO_HABITACION t ON (h1.tipo_habitacion = t.cod_tipo)" +
                    " WHERE h1.borrado_logico = 0" +
                    " AND h1.numero NOT IN" +
                                           " (SELECT h.numero FROM HABITACIONES h INNER JOIN DETALLE_RESERVA d ON (h.numero = d.numero_habitacion)" +
                                           " INNER JOIN RESERVA r ON(d.id_reserva = r.id_reserva)" +
                                           " WHERE r.borrado_logico = 0" +
                                           " AND r.fecha_hora_ingreso_estimada <= CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                           " AND r.fecha_hora_salida_estimada >= CONVERT(DATETIME, '" + fechaSalida + "', 103))";
                                        
                    consulta += " ORDER BY t.cod_tipo";
            
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);



        }*/

        /*public DataTable RecuperarHabitacionesLibres(string fechaIngreso, string fechaSalida)
        {

            string consulta = "SELECT h1.numero, t.nombre as tipo, h1.piso, h1.precio, t.descripcion" +
                    " FROM HABITACIONES h1" +
                    " INNER JOIN TIPO_HABITACION t ON (h1.tipo_habitacion = t.cod_tipo)" +
                    " WHERE h1.borrado_logico = 0" +
                    " AND h1.numero NOT IN" +
                                           " (SELECT h.numero FROM HABITACIONES h INNER JOIN DETALLE_RESERVA d ON (h.numero = d.numero_habitacion)" +
                                           " INNER JOIN RESERVA r ON(d.id_reserva = r.id_reserva)" +
                                           " WHERE r.borrado_logico = 0" +
                                           " AND ((r.fecha_hora_ingreso_estimada <= CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                           " AND r.fecha_hora_salida_estimada >= CONVERT(DATETIME, '" + fechaSalida + "', 103))" +
                                           " OR(r.fecha_hora_ingreso_estimada <= CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                           " AND r.fecha_hora_salida_estimada <= CONVERT(DATETIME, '" + fechaSalida + "', 103))" +
                                           " OR (r.fecha_hora_ingreso_estimada >= CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                           " AND r.fecha_hora_salida_estimada >= CONVERT(DATETIME, '" + fechaSalida + "', 103))))"; 
            consulta += " ORDER BY t.cod_tipo";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);

        }*/

        public DataTable RecuperarHabitacionesLibres(string fechaIngreso, string fechaSalida)
        {

            string consulta = "SELECT h1.numero, t.nombre as tipo, h1.piso, h1.precio, t.descripcion" +
                " FROM HABITACIONES h1" +
                " INNER JOIN TIPO_HABITACION t ON(h1.tipo_habitacion = t.cod_tipo)" +
                " WHERE h1.borrado_logico = 0" +
                " AND h1.numero NOT IN (SELECT h.numero" +
                                       " FROM HABITACIONES h" +
                                       " INNER JOIN DETALLE_RESERVA d ON(h.numero = d.numero_habitacion)" +
                                       " INNER JOIN RESERVA r ON(d.id_reserva = r.id_reserva)" +
                                       " WHERE r.borrado_logico = 0" +
                                       " AND (CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                       " BETWEEN r.fecha_hora_ingreso_estimada AND r.fecha_hora_salida_estimada)" +
                                       " OR (CONVERT(DATETIME, '" + fechaSalida + "', 103)" +
                                       " BETWEEN r.fecha_hora_ingreso_estimada AND r.fecha_hora_salida_estimada)" +
                                       " OR (r.fecha_hora_ingreso_estimada BETWEEN CONVERT(DATETIME,'"+ fechaIngreso +"', 103)" +
                                       " AND CONVERT(DATETIME, '" + fechaSalida + "', 103))) ";
                consulta += " ORDER BY t.cod_tipo";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);

        }
        private int GenerarId()
        {
            DataTable tabla = RecuperarIds();

            return tabla.Rows.Count + 1;
        }

        private DataTable RecuperarIds()
        {
            string consulta = "SELECT id_reserva FROM RESERVA";
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public int Crear(Reserva oReserva, BindingList<DetalleReserva> oDetalle)
        {
            int id = 0;
            DBHelper db = new DBHelper();
            string insercion = "";
            try
            {
                db.Open();
                db.BeginTransaction();
                oReserva.IdReserva = GenerarId();
                if (oReserva.IdVehiculo != 0)
                {
                    insercion = "INSERT INTO RESERVA (id_reserva, fecha_hora_reserva, id_huesped, fecha_hora_ingreso_estimada," +
                        " fecha_hora_salida_estimada, id_usuario, id_vehiculo, cantidad_personas, estado, numero_cochera, precio_unitario_cochera," +
                        " borrado_logico)" +
                        " VALUES (" +
                        oReserva.IdReserva + "," +
                        " CONVERT(DATETIME, '" + oReserva.FechaHoraReserva + "', 103), " +
                        oReserva.IdHuesped + "," +
                        " CONVERT(DATETIME, '" + oReserva.FechaHoraIngresoEstimada + "', 103)," +
                        " CONVERT(DATETIME, '" + oReserva.FechaHoraSalidaEstimada + "', 103), " +
                        oReserva.IdUsuario + ", " +
                        oReserva.IdVehiculo + ", " +
                        oReserva.CantidadPersonas + ", " +
                        "1, " +
                        oReserva.NumeroCochera + "," +
                        " '" + oReserva.PrecioUnitarioCochera + "', 0)";
                }
                else
                {
                    insercion = "INSERT INTO RESERVA (id_reserva, fecha_hora_reserva, id_huesped, fecha_hora_ingreso_estimada," +
                    " fecha_hora_salida_estimada, id_usuario, cantidad_personas, estado," +
                    " borrado_logico)" +
                    " VALUES (" +
                    oReserva.IdReserva + "," +
                    " CONVERT(DATETIME, '" + oReserva.FechaHoraReserva + "', 103), " +
                    oReserva.IdHuesped + "," +
                    " CONVERT(DATETIME, '" + oReserva.FechaHoraIngresoEstimada + "', 103)," +
                    " CONVERT(DATETIME, '" + oReserva.FechaHoraSalidaEstimada + "', 103), " +
                    oReserva.IdUsuario + ", " +
                    oReserva.CantidadPersonas + ", " +
                    "1, 0)";
                }
                db.Transaccion(insercion);

                foreach (var detalle in oDetalle)
                {
                    detalle.IdReserva = oReserva.IdReserva;
                    string insercionDet = "INSERT INTO DETALLE_RESERVA (id_detalle, id_reserva, numero_habitacion, precio_unitario_habitacion, borrado_logico)" +
                        " VALUES (" +
                        detalle.IdDetalle + ", " +
                        detalle.IdReserva + ", " +
                        detalle.NroHabitacion + "," +
                        " '" + detalle.PrecioUnitarioHabitacion + "', 0)";
                    db.Transaccion(insercionDet);
                }

                db.Commit();
                id = oReserva.IdReserva;

            }
            catch(Exception ex)
            {
                db.Rollback();
                throw ex;                
            }
            finally
            {
                db.Close();
            }
            return id;
        }
    }
}
