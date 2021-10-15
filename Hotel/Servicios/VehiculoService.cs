using Hotel.Datos.Dao;
using Hotel.Datos.Interfaces;
using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public DataTable RecuperarPorId(int id)
        {
            return dao.RecuperarPorId(id);
        }

        public DataTable RecuperarFiltrados(string patente, string marca, string pasaporte)
        {
            return dao.RecuperarFiltrados(patente, marca, pasaporte);
        }

        public bool PatenteCorrecta(string patente)
        {

            Regex formato1 = new Regex(@"[A-Z]{2}[0-9]{3}[A-Z]{2}");
            Regex formato2 = new Regex(@"[A-Z]{3}[0-9]{3}");

            if (patente.Length == 7)
            {
                if (formato1.IsMatch(patente))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (patente.Length == 6)
            {
                if (formato2.IsMatch(patente))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }

        }
    }


}
