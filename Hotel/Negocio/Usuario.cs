using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Usuario
    {
        public int Id { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public bool BorradoLogico { get; set; }

        public int validarUsuario(string nombre, string clave)
        {

            string consulta = "SELECT * FROM Usuarios WHERE nombre ='" + nombre + "' AND contraseña ='" + clave + "'";

            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultar(consulta);
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

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarIds()
        {
            string consulta = "SELECT Id FROM USUARIOS";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }


        public DataTable RecuperarPorId(int id)
        {
            string consulta = "SELECT nombre FROM USUARIOS" +
                " WHERE id=" + id;

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
        public DataTable RecuperarGrilla()
        {
            string consulta = "SELECT u.id as id, u.nombre as usuario, e.id_empleado as id_empleado, e.apellido as apellido,"+
                " e.nombre as nombre, e.tipo_doc, e.nro_doc, p.descripcion as puesto, t.descripcion as tpo_doc" +
                " FROM USUARIOS u JOIN EMPLEADOS e ON (u.id_empleado = e.id_empleado)" +
                " JOIN PUESTOS p ON (e.puesto = p.cod_puesto)" +
                " JOIN TIPO_DOCUMENTO t ON (e.tipo_doc = t.tipo_doc)" +
                " WHERE u.borrado_logico = 0" +
                " ORDER BY u.id";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

        public DataTable RecuperarFiltrados(string usuario, string apellido, string nombre, string puesto, string tipodoc, string nrodoc)
        {
            string consulta = "SELECT u.id as id, u.nombre as usuario, e.id_empleado as id_empleado, e.apellido as apellido," +
                " e.nombre as nombre, e.tipo_doc, e.nro_doc, p.descripcion as puesto, t.descripcion as tpo_doc" +
                " FROM USUARIOS u JOIN EMPLEADOS e ON (u.id_empleado = e.id_empleado)" +
                " JOIN PUESTOS p ON (e.puesto = p.cod_puesto)" +
                " JOIN TIPO_DOCUMENTO t ON (e.tipo_doc = t.tipo_doc)" +
                " WHERE u.borrado_logico = 0";

            if (!string.IsNullOrEmpty(usuario))
                consulta += " AND u.nombre = '" + usuario + "'";
            if (!string.IsNullOrEmpty(tipodoc))
                consulta += " AND e.tipo_doc = " + tipodoc;
            if (!string.IsNullOrEmpty(nrodoc))
                consulta += " AND e.nro_doc = " + nrodoc;
            if (!string.IsNullOrEmpty(apellido))
                consulta += " AND e.apellido = '" + apellido + "'";
            if (!string.IsNullOrEmpty(nombre))
                consulta += " AND e.nombre = '" + nombre + "'";
            if (!string.IsNullOrEmpty(puesto))
                consulta += " AND p.cod_puesto = " + puesto;

            consulta += " ORDER BY u.id";

            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultar(consulta);
            return tabla;
        }

        public string ValidarUsuarioExistente(string nombre)
        {

            string consulta = "SELECT * FROM Usuarios WHERE nombre ='" + nombre + "'";

            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return string.Empty;
            }
            else
            {
                return nombre;
            }
        }

        internal bool Crear(Usuario oUsuario)
        {
            string consulta = "INSERT INTO USUARIOS (id, contraseña, nombre, id_empleado, borrado_logico)" +
                " VALUES (" +
                 " '" + oUsuario.Id + "'," +
                 " '" + oUsuario.Contrasena + "'," +
                 " '" + oUsuario.Nombre + "'," +
                 " '" + oUsuario.IdEmpleado + "', 0);";

            DBHelper oDatos = new DBHelper();
            oDatos.consultar(consulta);
            return true;
        }

        internal bool Eliminar(Usuario oUsuario)
        {
            string consulta = "UPDATE USUARIOS SET borrado_logico = 1" +
                " WHERE id =" + oUsuario.Id;

            DBHelper oDatos = new DBHelper();
            oDatos.consultar(consulta);
            return true;
        }

        internal bool Modificar(Usuario oUsuario)
        {
            string consulta = "UPDATE USUARIOS SET " +
                " contraseña = '" + oUsuario.Contrasena + "'," +
                " nombre = '" + oUsuario.Nombre + "'" +
                " WHERE id = " + oUsuario.Id;

            DBHelper oDatos = new DBHelper();
            oDatos.consultar(consulta);
            return true;
        }

        public int validarPassword(int id, string clave)
        {

            string consulta = "SELECT * FROM Usuarios WHERE id ='" + id + "' AND contraseña ='" + clave + "'";

            DBHelper oDatos = new DBHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0)
            {
                return (int)tabla.Rows[0][0];
            }

            else
            {
                return 0;
            }
        }

    }

}
