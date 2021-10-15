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

        public DataTable RecuperarFiltrados(string nombre, string apellido, string pasaporte, string pais)
        {
            return dao.RecuperarFiltrados(nombre, apellido, pasaporte, pais);
        }

        public DataTable RecuperarPorNumero(int id)
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

        public DataTable RecuperarPorPasaporte(string pasaporte)
        {
            return dao.RecuperarPorPasaporte(pasaporte);
        }

        // Valida que el pasaporte tenga el formato correcto, 3 letras y 6 números (AAA000000)
        public bool PasaporteCorrecto(string pasaporte)
        {

            Regex formato = new Regex(@"[A-Z]{3}[0-9]{6}");

            if (pasaporte.Length == 9)
            {
                if (formato.IsMatch(pasaporte))
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
