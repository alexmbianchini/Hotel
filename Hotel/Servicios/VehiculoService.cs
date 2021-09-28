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
    class VehiculoService
    {
        private IVehiculo dao;

        public VehiculoService()
        {
            dao = new VehiculoDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public bool Crear(Vehiculo oVehiculo)
        {
            return dao.Crear(oVehiculo);
        }

        public bool Modificar(Vehiculo oVehiculo)
        {
            return dao.Modificar(oVehiculo);
        }

        public bool Eliminar(Vehiculo oVehiculo)
        {
            return dao.Eliminar(oVehiculo);
        }

        public DataTable RecuperarPorPatente(string patente)
        {
            return dao.RecuperarPorPatente(patente);
        }

        public DataTable RecuperarFiltrados(string patente, string marca, string pasaporte)
        {
            return dao.RecuperarFiltrados(patente, marca, pasaporte);
        }
    }
}
