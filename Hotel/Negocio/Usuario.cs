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
        public DateTime Caducidad { get; set; }
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

        public DataTable RecuperarGrilla()
        {
            string consulta = "SELECT u.id as id, u.nombre as usuario, e.id_empleado as id_empleado, e.apellido as nombre," +
                " e.fecha_ingreso_trabajo as fecha_ingreso, p.descripcion as puesto" +
                " FROM USUARIOS u JOIN EMPLEADOS e ON (u.id_empleado = e.id_empleado)" +
                " JOIN PUESTOS p ON (e.puesto = p.cod_puesto)" +
                " WHERE u.borrado_logico = 0" +
                " ORDER BY u.id";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }

    }
}
