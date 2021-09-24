using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IHuesped
    {
        DataTable RecuperarTodos();

        DataTable RecuperarFiltrados(string nombre, string apellido, string pasaporte, string pais);

        DataTable RecuperarPorNumero(string id);

        bool ValidarPasaporte(string pasaporte);

        bool Crear(Huesped oHuesped);

        bool Modificar(Huesped oHuesped);

        bool Eliminar(Huesped oHuesped);
    }
}
