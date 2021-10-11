using Hotel.Negocio;
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

        // Variables
        private static int idUsuario;

        private frmNuevaReserva(int idUsuario)
        {
            InitializeComponent();
            dgvReservas.AutoGenerateColumns = false;

        }

        public static frmNuevaReserva ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmNuevaReserva(idUsuario);
            }
            return instancia;
        }


        HuespedService oHuesped = new HuespedService();
        CocheraService oCochera = new CocheraService();
        ReservaService oReserva = new ReservaService();
        Reserva oReservaNew = new Reserva();
        BindingList<DetalleReserva>  listaDetalleReserva = new BindingList<DetalleReserva>();
        int cantidadDias = 0;
        float totalCochera = 0F;
        
 
        DataTable tablaHuesped;
        public static string _patenteVehiculo, _marcaVehiculo, _modeloVehiculo, _nombre, _apellido, _pasaporte;
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
            this.txtSubtotalCochera.Enabled = false;
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
            this.btnQuitarVehiculo.Enabled = false;
            this.txtSubtotal.Text = (0).ToString();
            this.txtSubtotalCochera.Text = (0).ToString();
            this.txtTotal.Text = (0).ToString();






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
                        txtPasaporte.Enabled = false;

                        btnAgregarVehiculo.Enabled = true;
                        btnConsultarHabitaciones.Enabled = true;
                        txtCantidadPersonas.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El Huesped no está registrado en el sistema, debe registrarlo", "Información", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.btnAgregarHusped.Focus();

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConsultarHabitaciones_Click(object sender, EventArgs e)
        {
            if(ValidarFechas())
            {
                cantidadDias = CalcularCantidadDias(dtpFechaIngreso, dtpFechaSalida);

                this.CargarGrilla(dgvHabitaciones, oReserva.RecuperarHabitacionesLibres(dtpFechaIngreso.Value.ToString(), dtpFechaSalida.Value.ToString()));
                if (txtPatente.Text != string.Empty)
                {
                        if (AsignarCochera())
                        {
                            var precio = tablaCocheras.Rows[0]["precio"];
                            txtNumeroCochera.Text = tablaCocheras.Rows[0]["numero"].ToString();
                            txtPrecioCochera.Text = precio.ToString();

                            totalCochera = cantidadDias * Convert.ToInt32(precio);
                            txtSubtotalCochera.Text = (totalCochera).ToString();

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

            btnAgregarHabitacion.Enabled = true;
            




        }

        private void btnAgregarHusped_Click(object sender, EventArgs e)
        {
            frmNuevoEditarHuesped frmNuevoH = new frmNuevoEditarHuesped(this.txtPasaporte.Text);
            frmNuevoH.SeleccionarModo(frmNuevoEditarHuesped.FormMode.reserva);
            frmNuevoH.ShowDialog();

            this.txtPasaporte.Text = _pasaporte;
            this.txtNombre.Text = _nombre;
            this.txtApellido.Text = _apellido;
            this.txtPasaporte.Enabled = false;
                    

        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            

            PasarFila(dgvHabitaciones, dgvReservas);

            CalcularTotales(dgvReservas);

            btnQuitarHabitacion.Enabled = true;
            btnAceptar.Enabled = true;


        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo(txtPasaporte.Text);
            frmVehiculo.SeleccionarModo(frmVehiculo.FormMode.reserva);
            frmVehiculo.ShowDialog();

            txtPatente.Text = _patenteVehiculo;
            txtMarca.Text = _marcaVehiculo;
            txtModelo.Text = _modeloVehiculo;
            this.btnQuitarVehiculo.Enabled = true;
            

        }

        private void btnQuitarHabitacion_Click(object sender, EventArgs e)
        {

            
            PasarFila(dgvReservas, dgvHabitaciones);

            CalcularTotales(dgvReservas);

          

            

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        

        private bool AsignarCochera()
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar Campos
            foreach (DataGridViewRow fila in dgvReservas.Rows)
            {
                listaDetalleReserva.Add(new DetalleReserva()
                {
                    IdDetalle = listaDetalleReserva.Count + 1,
                    NroHabitacion = Convert.ToInt32(fila.Cells[0].Value),
                    PrecioUnitarioHabitacion = Convert.ToSingle(fila.Cells[3].Value)
                });
            }

            
            try
            {
                // Cargar datos a los objetos
                CargarReserva();

                // Cargar datos a la base de datos

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

        private void CargarReserva()
        {
            oReservaNew.FechaHoraReserva = DateTime.Today;
            oReservaNew.IdHuesped = Convert.ToInt32(oHuesped.RecuperarPorPasaporte(this.txtPasaporte.Text).Rows[0]["id"]);
            oReservaNew.FechaHoraIngresoEstimada = dtpFechaIngreso.Value;
            oReservaNew.FechaHoraSalidaEstimada = dtpFechaSalida.Value;
            oReservaNew.IdUsuario = idUsuario;
            oReservaNew.IdVehiculo = _idVehiculo;
            oReservaNew.CantidadPersonas = Convert.ToInt32(txtCantidadPersonas.Text);
            oReservaNew.NumeroCochera = Convert.ToInt32(txtNumeroCochera.Text);
            oReservaNew.PrecioUnitarioCochera = Convert.ToSingle(txtPrecioCochera.Text);
        }

        private bool ValidarFechas()
        {
            if(this.dtpFechaIngreso.Value >= DateTime.Today 
                && this.dtpFechaIngreso.Value < this.dtpFechaSalida.Value)
            {
                return true;
            }
            return false;
        }
       
        
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["numero"],
                                tabla.Rows[i]["piso"],
                                tabla.Rows[i]["tipo"],
                                tabla.Rows[i]["precio"],
                                tabla.Rows[i]["descripcion"]);
            }

        }

        private void PasarFila(DataGridView dgv1, DataGridView dgv2)
        {
            DataGridViewRow filaSeleccionada = dgv1.CurrentRow;

            dgv2.Rows.Add(new object[]
            {
                filaSeleccionada.Cells[0].Value,
                filaSeleccionada.Cells[1].Value,
                filaSeleccionada.Cells[2].Value,
                filaSeleccionada.Cells[3].Value,
                filaSeleccionada.Cells[4].Value
            });

            dgv1.Rows.Remove(filaSeleccionada);
        }

        private int CalcularCantidadDias(DateTimePicker dia1, DateTimePicker dia2)
        {
            TimeSpan resta = Convert.ToDateTime(dia2.Value) - Convert.ToDateTime(dia1.Value);

            int cantidad = Convert.ToInt32(resta.Days);

            return cantidad;
        }


        private void CalcularTotales(DataGridView dataGridView)
        {
            var subtotal = 0F;

            foreach (DataGridViewRow fila in dataGridView.Rows)
            {
                subtotal += this.cantidadDias * Convert.ToSingle(fila.Cells[3].Value);
            }

            txtSubtotal.Text = subtotal.ToString();

            var importeTotal = subtotal + this.totalCochera;

            txtTotal.Text = importeTotal.ToString();
        }

        

        


    }


}
