﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio
{
    class Cuenta
    {
        public int IdCuenta { get; set; }
        public DateTime FechaHoraFacturacion { get; set; }
        public int IdReserva { get; set; }
        public int IdTarjeta { get; set; }
        public int IdUsuario { get; set; }
        public bool BorradoLogico { get; set; }

    }
}
