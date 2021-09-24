using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class PaisDao : IPais
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM PAISES WHERE borrado_logico = 0";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }


    }
}
