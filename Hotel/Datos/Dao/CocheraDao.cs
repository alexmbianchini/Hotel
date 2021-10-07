using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class CocheraDao : ICochera
    {

        public DataTable RecuperarLibres()
        {
            
            string consulta = "SELECT c.numero, c.precio" +
                " FROM COCHERAS c" +
                " JOIN ESTADO_COCHERA e ON (c.estado = e.id)" +
                " WHERE c.borrado_logico = 0" +
                " AND e.nombre = 'Libre'";

            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }
    }
}
