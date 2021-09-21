using Hotel.Datos.Dao;
using Hotel.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Servicios
{
    class PisoService
    {
        private IPiso dao;
        public PisoService()
        {
            dao = new PisoDao();
        }

        public DataTable RecuperarNumeros()
        {
            return dao.RecuperarNumeros();
        }
    }
}
