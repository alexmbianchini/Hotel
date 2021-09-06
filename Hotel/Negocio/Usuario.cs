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
    }
}
