using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos.Interfaces
{
    interface IDetalleServicioCuenta
    {
       DataTable RecuperarDatosInforme(string fechaInicio, string fechaFin);
       
    }
}
