using Hotel.Presentacion.Huesped;
using Hotel.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Presentacion
{
    public partial class frmNuevaReserva : Form
    {
        // Patrón Singleton
        private static frmNuevaReserva instancia;

        private frmNuevaReserva()
        {
            InitializeComponent();
        }

        public static frmNuevaReserva ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmNuevaReserva();
            }
            return instancia;
        }


        HuespedService oHuesped = new HuespedService();
        CocheraService oCochera = new CocheraService();
        ReservaService oReserva = new ReservaService();

        DataTable tablaHuesped;
        public static string _patenteVehiculo, _marcaVehiculo, _modeloVehiculo;
        public static int _idVehiculo;
        DataTable tablaCocheras;
        

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
            this.dtpFechaIngreso.Enabled = true;
            this.dtpFechaSalida.Enabled = true;
            this.btnConsultarHabitaciones.Enabled = false;
            this.txtCantidadPersonas.Enabled = false;
            this.txtSubtotal.Enabled = false;
            this.btnAgregarHabitacion.Enabled = false;
            this.btnQuitarHabitacion.Enabled = false;
            this.txtTotal.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = true;



        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(this.ValidarPasaporte())
            {
                if (PasaporteCorrecto(txtPasaporte.Text))
                {
                    if (!oHuesped.ValidarPasaporte(txtPasaporte.Text))
                    {
                        tablaHuesped = oHuesped.RecuperarPorPasaporte(txtPasaporte.Text);

                        txtNombre.Text = tablaHuesped.Rows[0]["nombre"].ToString();
                        txtApellido.Text = tablaHuesped.Rows[0]["apellido"].ToString();

                        btnAgregarVehiculo.Enabled = true;

                    }
                    else
                    {
                        if(MessageBox.Show("El Huesped no está registrado en el sistema, desea registrarlo?", "Información", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            //Registrar Huesped
                            frmNuevoEditarHuesped frmNuevoH = new frmNuevoEditarHuesped();
                            frmNuevoH.SeleccionarModo(frmNuevoEditarHuesped.FormMode.insert);
                        }
                    }
                }                    
                else
                {
                    MessageBox.Show("Debe ingresar un formato de pasaporte 'AAA000000', 3 letras y 6 números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPasaporte.Clear();
                    this.txtPasaporte.Focus();
                    this.lblPasaporte.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un pasaporte", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPasaporte.Clear();
                this.txtPasaporte.Focus();
                this.lblPasaporte.ForeColor = Color.Red;
            }

        }

        private bool ValidarPasaporte()
        {
            if (!string.IsNullOrEmpty(txtPasaporte.Text))
                return true;
            else
                return false;
        }

        private bool PasaporteCorrecto(string pasaporte)
        {

            Regex formato = new Regex(@"[A-Z]{3}[0-9]{6}");

            if (pasaporte.Length == 9)
            {
                if (formato.IsMatch(pasaporte))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        private void btnConsultarHabitaciones_Click(object sender, EventArgs e)
        {
            if (txtPatente.Text != string.Empty)
            {


                if (AsignarCochera())
                {
                    txtNumeroCochera.Text = tablaCocheras.Rows[0]["numero"].ToString();
                    txtPrecioCochera.Text = tablaCocheras.Rows[0]["precio"].ToString();

                }
                else
                {
                    MessageBox.Show("No hay Cocheras Disponibles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPatente.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();

                }
            }



        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo(txtPasaporte.Text);
            frmVehiculo.SeleccionarModo(frmVehiculo.FormMode.reserva);
            frmVehiculo.ShowDialog();

            txtPatente.Text = _patenteVehiculo;
            txtMarca.Text = _marcaVehiculo;
            txtModelo.Text = _modeloVehiculo;

            

        }


        public bool AsignarCochera()
        {
            tablaCocheras = oReserva.RecuperarCocherasLibres(dtpFechaIngreso.Value.ToString(), dtpFechaSalida.Value.ToString());

            if (tablaCocheras.Rows.Count > 0)
            { 

                return true;
            }
            else
            {
                return false; 
            }
        }
    }

}
