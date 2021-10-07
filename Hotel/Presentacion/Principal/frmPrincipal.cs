﻿using Hotel.Servicios;
using Hotel.Negocio;
using Hotel.Presentacion.UsuarioEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Presentacion.Huespedes;

namespace Hotel.Presentacion
{
    public partial class frmPrincipal : Form
    {
        Empleado oEmpleadoSelected = new Empleado();
        UsuarioService oUsuario = new UsuarioService();

        
        frmLogin fLog = new frmLogin();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            fLog.ShowDialog();


            if (fLog.MiUsuarioSelected.Id == 0)
            {
                this.Close();
                return;
            }
            else
            {
                this.Text += " - Usuario: " + fLog.MiUsuarioSelected.Nombre;

            }
            fLog.Dispose();


            // Validar que solo el Gerente pueda ingresar a las funciones de modificación de datos. 
            string puesto = oUsuario.TraerPuestoEmpleado(fLog.MiUsuarioSelected.Id);

            if (puesto != "Gerente")
            {
                btnUsuarios.Enabled = false;
                return;
            }
        }

        // Otra forma de verificar lo del gerente es ponerlo dentro de cada boton, ELIJAN la que más les guste
        /*
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (puesto == "Gerente")
            {
                frmUsuario fru = new frmUsuario();
                fru.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso Denegado! No autorizado para el ingreso!");
            }
        }
         */
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario fru = new frmUsuario();
            fru.ShowDialog();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            frmHabitacion frh = new frmHabitacion();
            frh.ShowDialog();
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            frmPassword frmP = new frmPassword(fLog.MiUsuarioSelected.Id);
            frmP.ShowDialog();
        }

        private void btnTipoHabitacion_Click(object sender, EventArgs e)
        {
            frmTipoHabitacion frth = new frmTipoHabitacion();
            frth.ShowDialog();
        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
            frmHuesped frh = new frmHuesped();
            frh.ShowDialog();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo();
            frmVehiculo.SeleccionarModo(frmVehiculo.FormMode.principal);
            frmVehiculo.ShowDialog();
        }
    }
}
