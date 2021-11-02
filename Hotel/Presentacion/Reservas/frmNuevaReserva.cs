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

        // Variables y necesarios
        public static int idUsuario;
        DataTable tablaHuesped;
        public static string _patenteVehiculo, _marcaVehiculo, _modeloVehiculo, _nombre, _apellido, _pasaporte;
        public static int _idVehiculo;
        DataTable tablaCocheras;
        BindingList<DetalleReserva> listaDetalleReserva = new BindingList<DetalleReserva>();
        int cantidadDias = 0;
        float totalCochera = 0F;


        // Instancia de objetos
        HuespedService oHuesped = new HuespedService();
        ReservaService oReserva = new ReservaService();
        Reserva oReservaNew = new Reserva();
        


        // Constructores necesarios
        private frmNuevaReserva()
        {
            InitializeComponent();
            dgvReservas.AutoGenerateColumns = false;

        }

        private frmNuevaReserva(int id)
        {
            InitializeComponent();
            dgvReservas.AutoGenerateColumns = false;
            idUsuario = id;

        }


        // Instancias de Singleton
        public static frmNuevaReserva ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmNuevaReserva();
            }
            return instancia;
        }

        public static frmNuevaReserva ObtenerInstancia(int id)
        {
            if (instancia == null)
            {
                instancia = new frmNuevaReserva(id);
            }
            return instancia;
        }



        // Carga del formulario
        private void frmNuevaReserva_Load(object sender, EventArgs e)
        {
            this.CargarForm();
        }


        // Botón consultar Huesped; Permite consultar si un huesped está registrado en el hotel y trae la información necesaria
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Validar que el txt del pasaporte no esté vacío, en caso de que está vacío envía un mensaje.
            if(this.ValidarPasaporte())
            {
                // Validar que el formato del pasaporte sea correcto, en caso de que no es correcto, muestra un mensaje.
                if (oHuesped.PasaporteCorrecto(txtPasaporte.Text))
                {

                    // Recupera el huesped por el pasaporte, en caso de que no existe, la tabla no trae filas y envía un mensaje de que no existe.
                    tablaHuesped = oHuesped.RecuperarPorPasaporte(txtPasaporte.Text);
                    
                    if (tablaHuesped.Rows.Count != 0)
                    { 

                        txtNombre.Text = tablaHuesped.Rows[0]["nombre"].ToString();
                        txtApellido.Text = tablaHuesped.Rows[0]["apellido"].ToString();
                        txtPasaporte.Enabled = false;

                        // Habilitar los botones correspondientes para que el usuario pueda continuar con la transacción.
                        btnAgregarVehiculo.Enabled = true;
                        btnAgregarVehiculo.Visible = true;
                        btnConsultarHabitaciones.Enabled = true;
                        btnConsultarHabitaciones.Visible = true;
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


        // Botón agregar huesped que permite que crear un nuevo huesped y registrarlo en el hotel.
        private void btnAgregarHusped_Click(object sender, EventArgs e)
        {
            frmNuevoEditarHuesped frmNuevoH = new frmNuevoEditarHuesped(this.txtPasaporte.Text);
            frmNuevoH.SeleccionarModo(frmNuevoEditarHuesped.FormMode.reserva);
            frmNuevoH.ShowDialog();

            this.txtPasaporte.Text = _pasaporte;
            this.txtNombre.Text = _nombre;
            this.txtApellido.Text = _apellido;
            this.txtPasaporte.Enabled = false;

            // Habilitar los botones correspondientes para que el usuario pueda continuar con la transacción.
            btnAgregarVehiculo.Enabled = true;
            btnAgregarVehiculo.Visible = true;
            btnConsultarHabitaciones.Enabled = true;
            btnConsultarHabitaciones.Visible = true;
            txtCantidadPersonas.Enabled = true;
        }


        // Botón que permite agregar un vehículo del huesped registrado o agregar vehículos nuevos al huesped.
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            frmVehiculo frmVehiculo = new frmVehiculo(txtPasaporte.Text);
            frmVehiculo.SeleccionarModo(frmVehiculo.FormMode.reserva);
            frmVehiculo.ShowDialog();

            txtPatente.Text = _patenteVehiculo;
            txtMarca.Text = _marcaVehiculo;
            txtModelo.Text = _modeloVehiculo;
            this.btnQuitarVehiculo.Enabled = true;
            this.btnQuitarVehiculo.Visible = true;


        }


        // Botón que permite quitar el vehículo asignado para la reserva
        private void btnQuitarVehiculo_Click(object sender, EventArgs e)
        {
            txtPatente.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtNumeroCochera.Text = string.Empty;
            txtPrecioCochera.Text = string.Empty;
        }


        // Botón que consulta las habitaciones que están disponibles. 
        private void btnConsultarHabitaciones_Click(object sender, EventArgs e)
        {
            // Valida que las fechas estén en un rango correcto y que permita fechas válidas.
            if(ValidarFechas())
            {
                // Calcula la cantida de días para poder realizar los cálculos de subtotal.
                cantidadDias = CalcularCantidadDias(dtpFechaIngreso, dtpFechaSalida);

                // Carga la grilla con las habitaciones libres.
                this.CargarGrilla(dgvHabitaciones, oReserva.RecuperarHabitacionesLibres(dtpFechaIngreso.Value.ToString(), dtpFechaSalida.Value.ToString()));
                
                // Valida que la pantente no esté vacía y en caso de que haya datos de un vehículo asigna una cochera.
                if (txtPatente.Text != string.Empty)
                {
                        // Asigna una cochera secuencialmente que esté libre para el rango de fachas. En caso de que no haya cocheras disponibles no asigna e informa.
                        if (AsignarCochera())
                        {
                            
                            // carga los txt con la información de la cochera asignada.
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
            else
            {
                MessageBox.Show("Debe ingresar un rango de fechas válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Habilita el botón que permite agregar cocheras al detalle de la reserva.
            btnAgregarHabitacion.Enabled = true;
            btnAgregarHabitacion.Visible = true;
            
        }

               
        // Botón que permita agregar habitaciones a el detalle de la reserva.
        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            

            PasarFila(dgvHabitaciones, dgvReservas);

            CalcularTotales(dgvReservas);

            // Habilita los botenes correspondientes para que el usuario pueda continuar con la transacción.
            btnQuitarHabitacion.Enabled = true;
            btnQuitarHabitacion.Visible = true;
            btnAceptar.Enabled = true;
            btnAceptar.Visible = true;
            

        }


        // Botón que permite quitar habitaciones del detalle de la reserva y las devuelve a la grilla de habitaciones disponibles.
        private void btnQuitarHabitacion_Click(object sender, EventArgs e)
        {
            if (dgvReservas.Rows.Count == 0)
            {  
                MessageBox.Show("No hay habitaciones para quitar de la reserva", "Aviso", MessageBoxButtons.OK);
                btnQuitarHabitacion.Visible = false;
                btnQuitarHabitacion.Enabled = false;
            }
            else
            {
                PasarFila(dgvReservas, dgvHabitaciones);

                CalcularTotales(dgvReservas);
            }
                
            
             
        }


        // Botón aceptar que realiza toda la carga de la transacción.
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            // Carga la lista de detalles de reserva con todas las filas de la grilla del detalle de reserva.
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
                // Validar que los campos necesarios estén vacíos.
                if (ValidarCampos())
                {
                    // Carga los datos de la reserva y de todos los detalles de la reserva.
                    CargarReserva();

                    // Cargar datos de la transacción a la base de datos
                    if (listaDetalleReserva.Count != 0)
                    {
                        int idReserva = oReserva.Crear(oReservaNew, listaDetalleReserva);

                        MessageBox.Show(string.Concat("La Reserva N°: ", idReserva.ToString(), " se efectuó correctamente."), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception("Debe ingresar al menos una habitación para reservar.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva " + ex.Message + ex.StackTrace, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                instancia = null;
                this.Close();
            }


        }


        // Botón que cancela toda la transacción.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea cancelar la operación?", "Cancelar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                instancia = null;
                this.Close();
            }
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
            this.btnAgregarVehiculo.Visible = false;
            this.dtpFechaIngreso.Enabled = true;
            this.dtpFechaSalida.Enabled = true;
            this.btnConsultarHabitaciones.Enabled = false;
            this.btnConsultarHabitaciones.Visible = false;
            this.txtCantidadPersonas.Enabled = false;
            this.txtSubtotal.Enabled = false;
            this.btnAgregarHabitacion.Enabled = false;
            this.btnAgregarHabitacion.Visible = false;
            this.btnQuitarHabitacion.Enabled = false;
            this.btnQuitarHabitacion.Visible = false;
            this.txtTotal.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Visible = false;
            this.btnCancelar.Enabled = true;
            this.btnQuitarVehiculo.Enabled = false;
            this.btnQuitarVehiculo.Visible = false;
            this.txtSubtotal.Text = (0).ToString();
            this.txtSubtotalCochera.Text = (0).ToString();
            this.txtTotal.Text = (0).ToString();
            
        }


        private bool ValidarPasaporte()
        {
            if (!string.IsNullOrEmpty(txtPasaporte.Text))
                return true;
            else
                return false;
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

        

        private void CargarReserva()
        {
            oReservaNew.FechaHoraReserva = DateTime.Today;
            oReservaNew.IdHuesped = Convert.ToInt32(oHuesped.RecuperarPorPasaporte(this.txtPasaporte.Text).Rows[0]["id"]);
            oReservaNew.FechaHoraIngresoEstimada = dtpFechaIngreso.Value;
            oReservaNew.FechaHoraSalidaEstimada = dtpFechaSalida.Value;
            oReservaNew.IdUsuario = idUsuario;
            oReservaNew.CantidadPersonas = Convert.ToInt32(txtCantidadPersonas.Text);

            if (!string.IsNullOrEmpty(txtNumeroCochera.Text))
            {
                oReservaNew.NumeroCochera = Convert.ToInt32(txtNumeroCochera.Text);
                oReservaNew.PrecioUnitarioCochera = Convert.ToSingle(txtPrecioCochera.Text);
            }
            if (!string.IsNullOrEmpty(txtPatente.Text))
            {
                oReservaNew.IdVehiculo = _idVehiculo;
            }
            
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

        
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre");
                this.txtNombre.Focus();
                this.lblNombre.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtCantidadPersonas.Text))
            {
                MessageBox.Show("Debe ingresar la Cantidad de personas");
                this.txtCantidadPersonas.Focus();
                this.lblCantidadPersonas.ForeColor = Color.Red;
                return false;
            }

            return true;
        }
        


    }


}
