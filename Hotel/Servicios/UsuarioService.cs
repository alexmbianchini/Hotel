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
    class UsuarioService
    {
        private IUsuario dao;
        public UsuarioService()
        {
            dao = new UsuarioDao();
        }

        public int ValidarUsuario(string nombre, string clave)
        {
            return dao.ValidarUsuario(nombre, clave);

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
            return RecuperarPorId(id);
        }
        public DataTable RecuperarGrilla()
        {
            return dao.RecuperarGrilla();
        }

        public DataTable RecuperarFiltrados(string usuario, string apellido, string nombre, string puesto, string tipodoc, string nrodoc)
        {
            return dao.RecuperarFiltrados(usuario, apellido, nombre, puesto, tipodoc, nrodoc);
        }

        public string ValidarUsuarioExistente(string nombre)
        {
            return dao.ValidarUsuarioExistente(nombre);
        }

        public bool Crear(Usuario oUsuario)
        {
            return dao.Crear(oUsuario);
  
        }

        public bool Eliminar(Usuario oUsuario)
        {
            return dao.Eliminar(oUsuario);
        }


        public bool Modificar(Usuario oUsuario)
        {
            return dao.Modificar(oUsuario);
        }

        public int ValidarPassword(int id, string clave)
        {
            return dao.ValidarPassword(id, clave);

        }
    }
}

