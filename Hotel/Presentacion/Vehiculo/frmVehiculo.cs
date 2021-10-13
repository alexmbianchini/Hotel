using Hotel.Datos.Dao;
using Hotel.Negocio;
using Hotel.Servicios;
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
    public partial class frmVehiculo : Form
    {
        VehiculoService oVehiculo = new VehiculoService();
        Vehiculo oVehiculoSelected = new Vehiculo();

        string _pasaporte; 

        // Instanciar FormMode para utilizar en sentencia CASE
        private FormMode formMode = new FormMode();

        // Los diferentes modos que acepta el FormMode
        public enum FormMode
        {
            reserva,
            principal
        }

        public frmVehiculo()
        {
            InitializeComponent();
        }

        public frmVehiculo(string pasaporte)
        {
            InitializeComponent();
            _pasaporte = pasaporte;

        }



        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["patente"],
                                tabla.Rows[i]["marca"],
                                tabla.Rows[i]["modelo"],
                                tabla.Rows[i]["pasaporte"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["id"]);
            }

        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.principal:
                    CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
                    btnAgregar.Visible = false;
                    btnAgregar.Enabled = false;

                    break;

                case FormMode.reserva:
                    CargarGrilla(dgvVehiculo, oVehiculo.RecuperarFiltrados(string.Empty, string.Empty, _pasaporte));
                    btnAgregar.Visible = true;
                    btnAgregar.Enabled = true;

                    txtMarca.Enabled = false;
                    txtPasaporte.Enabled = false;
                    txtPatente.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnConsultar.Visible = false;
                    btnLimpiar.Enabled = false;
                    btnLimpiar.Visible = false;

                    break;
            }

            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Instanciar formulario para crear un Huesped
            frmNuevoEditarVehiculo frmNueva = new frmNuevoEditarVehiculo();
            frmNueva.SeleccionarModo(frmNuevoEditarVehiculo.FormMode.insert);
            frmNueva.ShowDialog();
            this.ActualizarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Instanciar un formulario para editar un huesped
            frmNuevoEditarVehiculo frmEditar = new frmNuevoEditarVehiculo(Convert.ToInt32(dgvVehiculo.CurrentRow.Cells["clmIdVehiculo"].Value));
            frmEditar.SeleccionarModo(frmNuevoEditarVehiculo.FormMode.update);
            frmEditar.ShowDialog();
            this.ActualizarGrilla();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el vehiculo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oVehiculoSelected.Id = Convert.ToInt32(dgvVehiculo.CurrentRow.Cells["clmIdVehiculo"].Value);

                // Retorna true si el huesped es eliminado o retorna false si no se puedo eliminar
                if (oVehiculo.Eliminar(oVehiculoSelected))
                {
                    MessageBox.Show("Vehiculo Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Vehiculo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.ActualizarGrilla();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPatente.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPasaporte.Text = string.Empty;
            this.ActualizarGrilla();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _patente, _marca, _pasaporte;
            _patente = _marca = _pasaporte = string.Empty;

            _patente = this.txtPatente.Text;
            _marca = this.txtMarca.Text;
            _pasaporte = this.txtPasaporte.Text;

            this.ActualizarGrilla();
        }

        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void dgvVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Selecciona unos de los dos opciones disponibles para el CASE
        public void SeleccionarModo(FormMode op)
        {
            this.formMode = op;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevaReserva.ObtenerInstancia();

            if (dgvVehiculo.Rows.Count != 0)
            {
                frmNuevaReserva._patenteVehiculo = dgvVehiculo.CurrentRow.Cells["clmPatente"].Value.ToString();
                frmNuevaReserva._marcaVehiculo = dgvVehiculo.CurrentRow.Cells["clmMarca"].Value.ToString();
                frmNuevaReserva._modeloVehiculo = dgvVehiculo.CurrentRow.Cells["clmModelo"].Value.ToString();
                frmNuevaReserva._idVehiculo = Convert.ToInt32(dgvVehiculo.CurrentRow.Cells["clmIdVehiculo"].Value);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehículo");
            }
            

            this.Close();
        }

        private void ActualizarGrilla()
        {
            switch (formMode)
            {
                case FormMode.principal:
                    this.CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
                    break;
                case FormMode.reserva:
                    CargarGrilla(dgvVehiculo, oVehiculo.RecuperarFiltrados(string.Empty, string.Empty, _pasaporte));
                    break;
            }
        }
    }

    
}
