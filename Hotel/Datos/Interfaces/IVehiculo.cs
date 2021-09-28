using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IVehiculo
    {
        DataTable RecuperarTodos();
        bool Crear(Vehiculo oVehiculo);
        bool Modificar(Vehiculo oVehiculo);
        bool Eliminar(Vehiculo oVehiculo);
        DataTable RecuperarPorPatente(string patente);
        DataTable RecuperarFiltrados(string patente, string marca, string pasaporte);
    }
}
