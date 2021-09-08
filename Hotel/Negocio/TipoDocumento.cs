using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class TipoDocumento
    {
        public int TipoDoc { get; set; }
        public string Descripcion { get; set; }
        public bool BorradoLogico { get; set; }


        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM TIPO_DOCUMENTO WHERE borrado_logico = 0 ORDER BY 2";

            DBHelper oDatos = new DBHelper();
            return oDatos.consultar(consulta);

        }


    }


}
