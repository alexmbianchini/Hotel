using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Presentacion
{
    public partial class frmNuevaReserva : Form
    {
        public frmNuevaReserva()
        {
            InitializeComponent();
        }


        private void frmNuevaReserva_Load(object sender, EventArgs e)
        {
            this.CargarForm();
        }

        private void CargarForm()
        {
            this.txtPasaporte.Enabled = true;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtPatente.Enabled = false;
            this.txtModelo.Enabled = false;
            this.txtMarca.Enabled = false;
            this.txtNumeroCochera.Enabled = false;
            this.txtPrecioCochera.Enabled = false;
            this.btnConsultar.Enabled = true;
            this.btnAgregarHusped.Enabled = true;
            this.btnAgregarVehiculo.Enabled = false;
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaSalida.Enabled = false;
            this.btnConsultarHabitaciones.Enabled = false;
            this.txtCantidadPersonas.Enabled = false;
            this.txtSubtotal.Enabled = false;
            this.btnAgregarHabitacion.Enabled = false;
            this.btnQuitarHabitacion.Enabled = false;
            this.txtTotal.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = true;



        }
    }

}
