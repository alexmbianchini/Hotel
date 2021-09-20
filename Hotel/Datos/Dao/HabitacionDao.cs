using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class HabitacionDao : IHabitacion
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM HABITACIONES WHERE borrado_logico = 0 ORDER BY 1";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarGrilla()
        {
            string consulta = "SELECT h.numero, h.piso, h.descripcion as descripcion, h.precio, t.cod_tipo, t.descripcion as tipo, e.descripcion as estado, e.idEstado" +
                " FROM HABITACIONES h JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " JOIN ESTADO_HABITACION e ON(h.estado = e.idEstado)" +
                " WHERE h.borrado_logico = 0" +
                " ORDER BY 1";


            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
        public DataTable RecuperarFiltrados(string numero, string piso, string tipo, string estado, string precioDesde, string precioHasta)
        {
            string consulta = "SELECT h.numero, h.piso, h.descripcion as descripcion, h.precio, t.cod_tipo, t.descripcion as tipo, e.descripcion as estado, e.idEstado" +
                " FROM HABITACIONES h JOIN TIPO_HABITACION t ON(h.tipo_habitacion = t.cod_tipo)" +
                " JOIN ESTADO_HABITACION e ON(h.estado = e.idEstado)" +
                " WHERE h.borrado_logico = 0";

            if (!string.IsNullOrEmpty(numero))
                consulta += " AND h.numero = " + numero;
            if (!string.IsNullOrEmpty(piso))
                consulta += " AND h.piso = " + piso;
            if (!string.IsNullOrEmpty(tipo))
                consulta += " AND t.cod_tipo = " + tipo;
            if (!string.IsNullOrEmpty(estado))
                consulta += " AND e.idEstado = " + estado;
            if (!string.IsNullOrEmpty(precioDesde))
                consulta += " AND h.precio >= " + precioDesde;
            if (!string.IsNullOrEmpty(precioHasta))
                consulta += " AND h.precio <= " + precioHasta;



            consulta += " ORDER BY 1";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorNumero(int numero)
        {
            string consulta = "SELECT h.piso, h.precio, h.descripcion FROM HABITACIONES h WHERE h.numero = " + numero;
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
                        
        }
    }

}
