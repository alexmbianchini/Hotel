using Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Usuario
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public bool BorradoLogico { get; set; }

        
    }

}
