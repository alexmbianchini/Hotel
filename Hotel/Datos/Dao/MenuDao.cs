using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class MenuDao : IMenu 
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM MENU WHERE borrado_logico = 0";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
    }
}
