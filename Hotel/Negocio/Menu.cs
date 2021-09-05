using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Menu
    {
        public int CodigoProducto { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public bool BorradoLogico { get; set; }
    }
}
