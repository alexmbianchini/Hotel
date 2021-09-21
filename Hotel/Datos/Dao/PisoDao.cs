using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Dao
{
    class PisoDao : IPiso 
    {
        public DataTable RecuperarNumeros()
        {
            string consulta = "SELECT numero FROM PISOS";


            return DBHelper.ObtenerInstancia().Ejecutar(consulta);
        }

    }
}
