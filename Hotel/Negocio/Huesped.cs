﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Huesped
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PaisResidencia { get; set; }
        public string NumeroPasaporte { get; set; }
        public bool BorradoLogico { get; set; }

        public string Mail { get; set; }
        public int Id { get; set; }
    }
}
