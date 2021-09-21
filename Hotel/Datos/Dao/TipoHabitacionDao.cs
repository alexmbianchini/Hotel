using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class TipoHabitacionDao : ITipoHabitacion
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TIPO_HABITACION WHERE borrado_logico = 0 ORDER BY 1";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarPorCodigo(int codigo)
        {
            string consulta = "SELECT descripcion FROM TIPO_HABITACION WHERE borrado_logico = 0" +
                " AND cod_tipo = " + codigo +
                " ORDER BY descripcion";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public bool Crear(TipoHabitacion oTipo)
        {
            string consulta = "INSERT INTO TIPO_HABITACION (cod_tipo, nombre, descripcion, borrado_logico)" +
                " VALUES (" +
                 " '" + oTipo.CodTipo + "'," +
                 " '" + oTipo.Nombre + "'," +
                 " '" + oTipo.Descripcion + "'," +
                 " 0);";


            DBHelper.ObtenerInstancia().Ejecutar(consulta);
            return true;
        }


        public bool Modificar(TipoHabitacion oTipo)
        {
            string consulta = "UPDATE TIPO_HABITACION SET " +
                " descripcion = '" + oTipo.Descripcion + "'" +
                " WHERE cod_tipo = " + oTipo.CodTipo;

            DBHelper.ObtenerInstancia().Ejecutar(consulta);
            return true;
        }
    }
}
