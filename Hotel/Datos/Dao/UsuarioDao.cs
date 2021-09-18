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
    class UsuarioDao : IUsuario
    {
        public int ValidarUsuario(string nombre, string clave)
        {

            string consulta = "SELECT * FROM Usuarios WHERE nombre ='" + nombre + "' AND password ='" + clave + "'";

            
            DataTable tabla = DBHelper.ObtenerInstancia().Ejecutar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return (int)tabla.Rows[0][0];
            }
            else
            {
                return 0;
            }
        }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM USUARIOS WHERE borrado_logico = 0 ORDER BY 4";

            
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarIds()
        {
            string consulta = "SELECT Id FROM USUARIOS";

            
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }


        public DataTable RecuperarPorId(int id)
        {
            string consulta = "SELECT nombre FROM USUARIOS" +
                " WHERE id=" + id;

            
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
        public DataTable RecuperarGrilla()
        {
            string consulta = "SELECT u.id as id, u.nombre as usuario, e.id_empleado as id_empleado, e.apellido as apellido," +
                " e.nombre as nombre, e.tipo_doc, e.nro_doc, p.descripcion as puesto, t.descripcion as tpo_doc" +
                " FROM USUARIOS u JOIN EMPLEADOS e ON (u.id_empleado = e.id_empleado)" +
                " JOIN PUESTOS p ON (e.puesto = p.cod_puesto)" +
                " JOIN TIPO_DOCUMENTO t ON (e.tipo_doc = t.tipo_doc)" +
                " WHERE u.borrado_logico = 0" +
                " ORDER BY u.id";

           
            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

        public DataTable RecuperarFiltrados(string usuario, string apellido, string nombre, string puesto, string tipodoc, string nrodoc)
        {
            string consulta = "SELECT u.id as id, u.nombre as usuario, e.id_empleado as id_empleado, e.apellido as apellido," +
                " e.nombre as nombre, e.tipo_doc, e.nro_doc, p.descripcion as puesto, t.descripcion as tpo_doc" +
                " FROM USUARIOS u JOIN EMPLEADOS e ON (u.id_empleado = e.id_empleado)" +
                " JOIN PUESTOS p ON (e.puesto = p.cod_puesto)" +
                " JOIN TIPO_DOCUMENTO t ON (e.tipo_doc = t.tipo_doc)" +
                " WHERE u.borrado_logico = 0";

            consulta += " AND u.nombre LIKE '%" + usuario + "%'";
            if (!string.IsNullOrEmpty(tipodoc))
                consulta += " AND e.tipo_doc = " + tipodoc;
            if (!string.IsNullOrEmpty(nrodoc))
                consulta += " AND e.nro_doc = " + nrodoc;
            consulta += " AND e.apellido LIKE '%" + apellido + "%'";
            consulta += " AND e.nombre LIKE '%" + nombre + "%'";
            if (!string.IsNullOrEmpty(puesto))
                consulta += " AND p.cod_puesto = " + puesto;

            consulta += " ORDER BY u.id";

            
            DataTable tabla = DBHelper.ObtenerInstancia().Ejecutar(consulta);
            return tabla;
        }

        public string ValidarUsuarioExistente(string nombre)
        {

            string consulta = "SELECT * FROM Usuarios WHERE nombre ='" + nombre + "'" +
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

        public bool Crear(Usuario oUsuario)
        {
            string consulta = "INSERT INTO USUARIOS (id, password, nombre, id_empleado, borrado_logico)" +
                " VALUES (" +
                 " '" + oUsuario.Id + "'," +
                 " '" + oUsuario.Password + "'," +
                 " '" + oUsuario.Nombre + "'," +
                 " '" + oUsuario.IdEmpleado + "', 0);";

            
            DBHelper.ObtenerInstancia().Ejecutar(consulta);
            return true;
        }

        public bool Eliminar(Usuario oUsuario)
        {
            string consulta = "UPDATE USUARIOS SET borrado_logico = 1" +
                " WHERE id =" + oUsuario.Id;

            
            DBHelper.ObtenerInstancia().Ejecutar(consulta);
            return true;
        }

        public bool Modificar(Usuario oUsuario)
        {
            string consulta = "UPDATE USUARIOS SET " +
                " password = '" + oUsuario.Password + "'," +
                " nombre = '" + oUsuario.Nombre + "'" +
                " WHERE id = " + oUsuario.Id;

            DBHelper.ObtenerInstancia().Ejecutar(consulta);
            return true;
        }

        public int ValidarPassword(int id, string clave)
        {

            string consulta = "SELECT * FROM Usuarios WHERE id ='" + id + "' AND password ='" + clave + "'";

            
            DataTable tabla = DBHelper.ObtenerInstancia().Ejecutar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return (int)tabla.Rows[0][0];
            }

            else
            {
                return 0;
            }
        }

        /*public string traerPuesto(int id)
        {
            string consulta = "Select P.nombre"
        }*/
    }
}
