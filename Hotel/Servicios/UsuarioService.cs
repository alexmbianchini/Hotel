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
            return dao.RecuperarPorId(id);
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

        public string TraerPuestoEmpleado(int id)
        {
            return dao.TraerPuestoEmpleado(id);
        }

        // Valida coincidencia de contraseñas, si las contraseñas coinciden retorna true y si no retorna false
        public bool ValidarConfirmacionPassword(string Password, string Confirmacion)
        {
            if (Password == Confirmacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validación de complejidad de contraseña 
        public Boolean PasswordSegura(String PasswordSinVerificar)
        {
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");


            //si no contiene las letras, regresa false
            if (!letras.IsMatch(PasswordSinVerificar))
            {
                return false;
            }
            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(PasswordSinVerificar))
            {
                return false;
            }

            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(PasswordSinVerificar))
            {
                return false;
            }
            // si la longitud es menor a 8 caracteres, retorna falso
            if (PasswordSinVerificar.LongCount() < 8)
            {
                return false;
            }

            //si cumple con todo, regresa true
            return true;
        }
    }
}
