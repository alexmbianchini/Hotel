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
    class TipoDocumentoService
    {
        private ITipoDocumento dao;

        public TipoDocumentoService()
        {
            dao = new TipoDocumentoDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}