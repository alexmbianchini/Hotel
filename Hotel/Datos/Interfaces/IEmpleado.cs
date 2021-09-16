using Hotel.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IEmpleado
    {
        DataTable RecuperarTodos();
        DataTable RecuperarIds();
        DataTable RecuperarPorId(int id);
        string ValidarEmpleadoExistente(string nroDoc, string tipoDoc);
        bool Crear(Empleado oEmpleado);
        bool Eliminar(Empleado oEmpleado);
        bool Modificar(Empleado oEmpleado);




    }
}
