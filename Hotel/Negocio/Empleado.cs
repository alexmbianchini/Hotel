using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public int TipoDoc { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngresoTrabajo { get; set; }
        public DateTime FechaSalidaTrabajo { get; set; }
        public int Puesto { get; set; }
        public bool BorradoLogico { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM EMPLEADOS WHERE borrado_logico = 0 ORDER BY 4";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
    }
}