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
    class HabitacionService
    {
        private IHabitacion dao;
        public HabitacionService()
        {
            dao = new HabitacionDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DataTable RecuperarGrilla()
        {
            return dao.RecuperarGrilla();
        }
        public DataTable RecuperarFiltrados(string numero, string piso, string tipo, string estado, string precioDesde, string precioHasta)
        {
            return dao.RecuperarFiltrados(numero, piso, tipo, estado, precioDesde, precioHasta);
        }

        public DataTable RecuperarPorNumero(int numero)
        {
            return dao.RecuperarPorNumero(numero);
        }
    }
}
