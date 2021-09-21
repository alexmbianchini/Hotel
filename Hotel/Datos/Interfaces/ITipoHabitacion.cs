using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface ITipoHabitacion
    {
        DataTable RecuperarTodos();
        DataTable RecuperarPorCodigo(int codigo);

        bool Crear(TipoHabitacion oTipo);

        bool Modificar(TipoHabitacion oTipo);
    }
}
