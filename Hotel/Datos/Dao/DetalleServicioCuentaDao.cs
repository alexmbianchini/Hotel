using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class DetalleServicioCuentaDao : IDetalleServicioCuenta
    {
        public DataTable RecuperarDatosInforme(string fechaInicio, string fechaFin)
        {
            string consulta = "SELECT d.nro_cuenta, d.nro_habitacion, d.cod_producto, d.precio_unitario, d.fecha_hora, m.descripcion" +
                " FROM DETALLE_SERVICIOS_CUENTA d" +
                " INNER JOIN MENU m ON(d.cod_producto = m.codigo_producto)" +
                " WHERE d.fecha_hora BETWEEN CONVERT(DATETIME, '" + fechaInicio + "', 103) AND CONVERT(DATETIME, '" + fechaFin + "', 103)";


            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
    }
}
