using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IHabitacion
    {
        DataTable RecuperarTodos();
        DataTable RecuperarGrilla();
        DataTable RecuperarFiltrados(string numero, string piso, string tipo, string estado, string precioDesde, string precioHasta);
        DataTable RecuperarPorNumero(int numero);
        string ValidarHabitacionExistente(string numero);
        bool Modificar(Habitacion oHabitacion);
        DataTable RecuperarNumeros();
        bool Crear(Habitacion oHabitacion);

    }
}
