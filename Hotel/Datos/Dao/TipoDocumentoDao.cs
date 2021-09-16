using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class TipoDocumentoDao
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TIPO_DOCUMENTO WHERE borrado_logico = 0 ORDER BY 2";

            DBHelper oDatos = new DBHelper();
            return oDatos.Ejecutar(consulta);

        }
    }
}
