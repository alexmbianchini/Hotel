﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hotel.Presentacion.frmPrincipal());
            //Application.Run(new Presentacion.frmUsuario());
            //Application.Run(new Presentacion.frmHabitacion());
            //Application.Run(new Presentacion.UsuarioEmpleado.frmPassword());
            //Application.Run(new Presentacion.frmTipoHabitacion());
            //Application.Run(new Hotel.Presentacion.Huespedes.frmHuesped());
            //Application.Run(new Presentacion.frmVehiculo());
            //Application.Run(Hotel.Presentacion.frmNuevaReserva.ObtenerInstancia());
        }
    }
}
