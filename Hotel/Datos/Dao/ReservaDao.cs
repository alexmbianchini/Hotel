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
                                    " AND r.estado = 1" +
                                    " AND (CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                    " BETWEEN r.fecha_hora_ingreso_estimada AND r.fecha_hora_salida_estimada)" +
                                    " OR (CONVERT(DATETIME, '" + fechaSalida + "', 103)" +
                                    " BETWEEN r.fecha_hora_ingreso_estimada AND r.fecha_hora_salida_estimada)" +
                                    " OR (r.fecha_hora_ingreso_estimada BETWEEN CONVERT(DATETIME,'" + fechaIngreso + "', 103)" +
                                    " AND CONVERT(DATETIME, '" + fechaSalida + "', 103))) ";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }



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
                                       " AND r.estado = 1" +
                                       " AND (CONVERT(DATETIME, '" + fechaIngreso + "', 103)" +
                                       " BETWEEN r.fecha_hora_ingreso_estimada AND r.fecha_hora_salida_estimada)" +
                                       " OR (CONVERT(DATETIME, '" + fechaSalida + "', 103)" +
                                       " BETWEEN r.fecha_hora_ingreso_estimada AND r.fecha_hora_salida_estimada)" +
                                       " OR (r.fecha_hora_ingreso_estimada BETWEEN CONVERT(DATETIME,'" + fechaIngreso + "', 103)" +
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
            catch (Exception ex)
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


        public DataTable RecuperarReservadas()
        {

            string consulta = "SELECT r.id_reserva, h.numero_pasaporte as pasaporte, h.nombre, h.apellido, r.fecha_hora_ingreso_estimada, " +
                " r.fecha_hora_salida_estimada, r.numero_cochera, r.cantidad_personas" +
                " FROM RESERVA r" +
                " INNER JOIN HUESPEDES h ON(r.id_huesped = h.id)" +
                " INNER JOIN ESTADO_RESERVA e ON(r.estado = e.id_estado)" +
                " WHERE e.descripcion = 'Reservado'";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecueperarDetallesReservaEspecifica(int numeroReserva)
        {

            string consulta = "SELECT d.id_detalle, d.numero_habitacion, t.nombre as tipo, d.precio_unitario_habitacion" +
                " FROM DETALLE_RESERVA d" +
                " INNER JOIN HABITACIONES h ON(d.numero_habitacion = h.numero)" +
                " INNER JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " WHERE d.id_reserva = " + numeroReserva;

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public bool Cancelar(int numeroReserva)
        {
            string consulta = "UPDATE RESERVA SET estado = 4" +
                " WHERE id_reserva =" + numeroReserva;


            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;

        }

        public DataTable RecuperarReservasParaCancelarFiltradas(string pasaporte, string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT r.id_reserva, h.numero_pasaporte as pasaporte, h.nombre, h.apellido, r.fecha_hora_ingreso_estimada, " +
                " r.fecha_hora_salida_estimada, r.numero_cochera, r.cantidad_personas" +
                " FROM RESERVA r" +
                " INNER JOIN HUESPEDES h ON(r.id_huesped = h.id)" +
                " INNER JOIN ESTADO_RESERVA e ON(r.estado = e.id_estado)" +
                " WHERE e.descripcion = 'Reservado'";
            consulta += " AND (r.fecha_hora_ingreso_estimada BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103) AND CONVERT(DATETIME, '" + fechaHasta + "', 103))";
            consulta += " AND (r.fecha_hora_salida_estimada BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103) AND CONVERT(DATETIME, '" + fechaHasta + "', 103))";
            if (!string.IsNullOrEmpty(pasaporte))
                consulta += " AND h.numero_pasaporte = '" + pasaporte + "'";
            
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarDatosReservaReporte(string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real, RESERVA.fecha_hora_salida_real, RESERVA.cantidad_personas, HUESPEDES.numero_pasaporte, PAISES.nombre AS pais" +
                ", RESERVA.precio_unitario_cochera, TIPO_HABITACION.nombre AS tipo_habitacion, DETALLE_RESERVA.precio_unitario_habitacion," +
                " DATEDIFF(DAY, RESERVA.fecha_hora_ingreso_estimada, RESERVA.fecha_hora_salida_estimada) AS cantidad_dias" +

                " FROM RESERVA" +
                " INNER JOIN  HUESPEDES ON RESERVA.id_huesped = HUESPEDES.id INNER JOIN DETALLE_RESERVA ON RESERVA.id_reserva = DETALLE_RESERVA.id_reserva INNER JOIN" +
                " HABITACIONES ON DETALLE_RESERVA.numero_habitacion = HABITACIONES.numero INNER JOIN TIPO_HABITACION ON HABITACIONES.tipo_habitacion = TIPO_HABITACION.cod_tipo INNER JOIN" +
                " PAISES ON HUESPEDES.pais_residencia = PAISES.id" +


                " WHERE RESERVA.borrado_logico = 0 AND RESERVA.estado = 3" +
                " AND RESERVA.fecha_hora_ingreso_real BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103)" +
                " AND CONVERT(DATETIME, '" + fechaHasta + "', 103)" +
                " ORDER BY RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real";

            /*
        SELECT        RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real, RESERVA.fecha_hora_salida_real, RESERVA.cantidad_personas, HUESPEDES.numero_pasaporte, PAISES.nombre AS pais, RESERVA.numero_cochera, 
                                 RESERVA.precio_unitario_cochera, TIPO_HABITACION.nombre AS tipo_habitacion, DETALLE_RESERVA.precio_unitario_habitacion, DATEDIFF(DAY, RESERVA.fecha_hora_ingreso_estimada, RESERVA.fecha_hora_salida_estimada) 
                                 AS cantidad_dias, (DATEDIFF(DAY, RESERVA.fecha_hora_ingreso_estimada, RESERVA.fecha_hora_salida_estimada) * DETALLE_RESERVA.precio_unitario_habitacion) AS total_habitaciones, 
						         (DATEDIFF(DAY, RESERVA.fecha_hora_ingreso_estimada, RESERVA.fecha_hora_salida_estimada) * RESERVA.precio_unitario_cochera) AS total_cocheras 
        FROM			RESERVA INNER JOIN
                                 HUESPEDES ON RESERVA.id_huesped = HUESPEDES.id INNER JOIN
                                 DETALLE_RESERVA ON RESERVA.id_reserva = DETALLE_RESERVA.id_reserva INNER JOIN
                                 HABITACIONES ON DETALLE_RESERVA.numero_habitacion = HABITACIONES.numero INNER JOIN
                                 TIPO_HABITACION ON HABITACIONES.tipo_habitacion = TIPO_HABITACION.cod_tipo INNER JOIN
                                 PAISES ON HUESPEDES.pais_residencia = PAISES.id

        WHERE RESERVA.borrado_logico = 0 AND RESERVA.estado = 3 
        AND RESERVA.fecha_hora_ingreso_estimada BETWEEN CONVERT(DATETIME, RESERVA.fecha_hora_ingreso_estimada, 103) AND CONVERT(DATETIME, RESERVA.fecha_hora_salida_estimada, 103)
            */

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarDatosTipoHabitacionReservada(string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT t.nombre as tipo_habitacion, " +
                "(DATEDIFF(DAY, r.fecha_hora_ingreso_estimada, r.fecha_hora_salida_estimada) * d.precio_unitario_habitacion) AS ingreso" +
                " FROM RESERVA r" +
                " INNER JOIN DETALLE_RESERVA d ON (r.id_reserva = d.id_reserva)" +
                " INNER JOIN HABITACIONES h ON (d.numero_habitacion = h.numero)" +
                " INNER JOIN TIPO_HABITACION t ON (h.tipo_habitacion = t.cod_tipo)" +
                " WHERE r.borrado_logico = 0" +
                " AND r.fecha_hora_ingreso_real BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103)" +
                " AND CONVERT(DATETIME, '" + fechaHasta + "', 103)";
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarDatosReservaCochera(string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real, RESERVA.fecha_hora_salida_real" +
                ", RESERVA.precio_unitario_cochera," +
                " DATEDIFF(DAY, RESERVA.fecha_hora_ingreso_estimada, RESERVA.fecha_hora_salida_estimada) AS cantidad_dias" +

                " FROM RESERVA" +

                " WHERE RESERVA.borrado_logico = 0 AND RESERVA.estado = 3" +
                " AND RESERVA.fecha_hora_ingreso_real BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103)" +
                " AND CONVERT(DATETIME, '" + fechaHasta + "', 103)" +
                " ORDER BY RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real";


            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarParaReportePaises(string fechaDesde, string fechaHasta, int pais)
        {
            string consulta = "SELECT RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real, RESERVA.fecha_hora_salida_real, RESERVA.cantidad_personas, PAISES.nombre AS pais," +
               " DATEDIFF(DAY, RESERVA.fecha_hora_ingreso_estimada, RESERVA.fecha_hora_salida_estimada) AS cantidad_dias" +

                " FROM RESERVA" +
                " INNER JOIN HUESPEDES ON RESERVA.id_huesped = HUESPEDES.id " +
                " INNER JOIN" +
                " PAISES ON HUESPEDES.pais_residencia = PAISES.id" +


                " WHERE RESERVA.borrado_logico = 0 AND RESERVA.estado = 3" +
                " AND RESERVA.fecha_hora_ingreso_real BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103)" +
                " AND CONVERT(DATETIME, '" + fechaHasta + "', 103)";
                if (pais != 0)
                {
                consulta += " AND HUESPEDES.pais_residencia = " + pais;
                }
                
                consulta += " ORDER BY RESERVA.id_reserva, RESERVA.fecha_hora_ingreso_real";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarDatosReservaCocheraXNroHabit(string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT d.precio_unitario_habitacion, d.numero_habitacion," +
                " DATEDIFF(DAY, r.fecha_hora_ingreso_estimada, r.fecha_hora_salida_estimada) AS cantidad_dias," +
                " DATEDIFF(DAY, r.fecha_hora_ingreso_estimada, r.fecha_hora_salida_estimada) * d.precio_unitario_habitacion as precio" +

                " FROM RESERVA r" +
                " INNER JOIN DETALLE_RESERVA d ON (r.id_reserva = d.id_reserva)" +

                " WHERE r.borrado_logico = 0 AND r.estado = 3" +
                " AND r.fecha_hora_ingreso_real BETWEEN CONVERT(DATETIME, '" + fechaDesde + "', 103)" +
                " AND CONVERT(DATETIME, '" + fechaHasta + "', 103)" +
                " ORDER BY r.id_reserva, r.fecha_hora_ingreso_real";


            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
    }
}

