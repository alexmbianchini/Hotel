using Hotel.Datos.Dao;
using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Servicios
{
    class TipoHabitacionService
    {
        private ITipoHabitacion dao;

        public TipoHabitacionService()
        {
            dao = new TipoHabitacionDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarPorCodigo(int codigo)
        {
            return dao.RecuperarPorCodigo(codigo);
        }

        public bool Crear(TipoHabitacion oTipo)
        {
            return dao.Crear(oTipo);
        }

        public bool Modificar(TipoHabitacion oTipo)
        {
            return dao.Modificar(oTipo);
        }
    }
}
