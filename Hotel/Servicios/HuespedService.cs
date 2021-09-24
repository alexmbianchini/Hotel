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
    class HuespedService
    {
        private IHuesped dao;

        public HuespedService()
        {
            dao = new HuespedDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarPorNumero(string id)
        {
            return dao.RecuperarPorNumero(id);
        }

        public bool ValidarPasaporte(string pasaporte)
        {
            return dao.ValidarPasaporte(pasaporte);

        }

        public bool Crear(Huesped oHuesped)
        {
            return dao.Crear(oHuesped);
        }

        public bool Modificar(Huesped oHuesped)
        {
            return dao.Modificar(oHuesped);
        }

        public bool Eliminar(Huesped oHuesped)
        {
            return dao.Eliminar(oHuesped);
        }
    }
}
