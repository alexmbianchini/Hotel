using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class HabitacionDao
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM HABITACIONES WHERE borrado_logico = 0 ORDER BY 1";

            DBHelper oDatos = new DBHelper();
            return oDatos.Ejecutar(consulta);
        }

        public DataTable RecuperarGrilla()
        {
            string consulta = "SELECT h.numero, h.estado as estado, h.piso, h.descripcion as descripcion, h.precio, t.descripcion as tipo" +
                " FROM HABITACIONES h JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " JOIN ESTADO_HABITACION e ON(h.estado = e.idEstado)" +
                " WHERE h.borrado_logico = 0" +
                " ORDER BY 1";


            DBHelper oDatos = new DBHelper();
            return oDatos.Ejecutar(consulta);
        }
        public DataTable RecuperarFiltrados(string numero, string piso, string tipo, string estado)
        {
            string consulta = "SELECT h.numero, h.piso, h.descripcion as descripcion, h.precio, t.descripcion as tipo, e.descripcion as estado" +
                " FROM HABITACIONES h JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " JOIN ESTADO_HABITACION e ON(h.estado = e.idEstado)" +
                " WHERE h.borrado_logico = 0";

            if (!string.IsNullOrEmpty(numero))
                consulta += " AND h.numero = " + numero;
            if (!string.IsNullOrEmpty(piso))
                consulta += " AND h.piso = " + piso;
            if (!string.IsNullOrEmpty(tipo))
                consulta += " AND t.descripcion = " + tipo;
            if (!string.IsNullOrEmpty(estado))
                consulta += " AND e.descripcion = " + estado;


            consulta += "ORDER BY 1";
            DBHelper oDatos = new DBHelper();
            return oDatos.Ejecutar(consulta);
        }
    }
}
