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
    class CocheraService
    {
        private ICochera dao;
        public CocheraService()
        {
            dao = new CocheraDao();
        }

        public DataTable RecuperarLibres()
        {

           return dao.RecuperarLibres();
        }

    }

}
