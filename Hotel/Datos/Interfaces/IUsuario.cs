using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IUsuario
    {
        int ValidarUsuario(string nombre, string clave);
        DataTable RecuperarTodos();
        DataTable RecuperarIds();
        DataTable RecuperarPorId(int id);
        DataTable RecuperarGrilla();
        DataTable RecuperarFiltrados(string usuario, string apellido, string nombre, string puesto, string tipodoc, string nrodoc);
        string ValidarUsuarioExistente(string nombre);
        bool Crear(Usuario oUsuario);
        bool Eliminar(Usuario oUsuario);
        bool Modificar(Usuario oUsuario);
        int ValidarPassword(int id, string clave);

    }
}
