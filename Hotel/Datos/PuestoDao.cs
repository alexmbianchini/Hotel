using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos
{
    class PuestoDao
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM PUESTOS WHERE borrado_logico = 0 ORDER BY 1";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);
        }
    }
}
