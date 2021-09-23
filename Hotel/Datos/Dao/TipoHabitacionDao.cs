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
            string consulta = "SELECT * FROM TIPO_HABITACION WHERE borrado_logico = 0" +
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


            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }


        public bool Modificar(TipoHabitacion oTipo)
        {
            string consulta = "UPDATE TIPO_HABITACION SET " +
                " nombre = '" + oTipo.Nombre + "'" +
                " descripcion = '" + oTipo.Descripcion + "'" +
                " WHERE cod_tipo = " + oTipo.CodTipo;

            DBHelper.ObtenerInstancia().Actualizar(consulta);
            return true;
        }

        public DataTable RecuperarFiltrados(string codigo, string nombre, string descripcion) 
        {
            string consulta = "SELECT * FROM TIPO_HABITACION WHERE borrado_logico = 0";

            if (!string.IsNullOrEmpty(codigo))
                consulta += " AND cod_tipo = " + codigo;
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND nombre = '" + nombre + "'";
            if (!string.IsNullOrEmpty(descripcion))
                consulta += " AND descripcion LIKE '%" + descripcion + "%'";

            consulta += " ORDER BY 1";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);


        }

        public string ValidarNombreExistente(string nombre)
        {
            string consulta = "SELECT * FROM TIPO_HABITACION WHERE nombre ='" + nombre + "'" +
                " AND borrado_logico = 0";


            DataTable tabla = DBHelper.ObtenerInstancia().Ejecutar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return string.Empty;
            }
            else
            {
                return nombre;
            }
        }
    }
}
