using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class EstadoHabitacion
    {
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
        public bool BorradoLogico { get; set; }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM ESTADO_HABITACION WHERE borrado_logico = 0 ORDER BY 1";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
    }
}
