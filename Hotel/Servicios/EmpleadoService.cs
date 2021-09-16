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
    class EmpleadoService
    {
        private IEmpleado dao;
        public EmpleadoService()
        {
            dao = new EmpleadoDao();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();

        }

        public DataTable RecuperarIds()
        {
            return dao.RecuperarIds();
        }

        public DataTable RecuperarPorId(int id)
        {
            return dao.RecuperarPorId(id);
        }

        public string ValidarEmpleadoExistente(string nroDoc, string tipoDoc)
        {

            return dao.ValidarEmpleadoExistente(nroDoc, tipoDoc);
        }

        public bool Crear(Empleado oEmpleado)
        {
            return dao.Crear(oEmpleado);
        }

        public bool Eliminar(Empleado oEmpleado)
        {
            return dao.Eliminar(oEmpleado);
        }

        public bool Modificar(Empleado oEmpleado)
        {
            return dao.Modificar(oEmpleado);
        }
    }
}
