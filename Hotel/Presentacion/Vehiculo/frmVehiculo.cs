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

        public frmVehiculo()
        {
            InitializeComponent();
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
                                tabla.Rows[i]["apellido"]);
            }

        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Instanciar formulario para crear un Huesped
            frmNuevoEditarVehiculo frmNueva = new frmNuevoEditarVehiculo();
            frmNueva.SeleccionarModo(frmNuevoEditarVehiculo.FormMode.insert);
            frmNueva.ShowDialog();
            this.CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Instanciar un formulario para editar un huesped
            frmNuevoEditarVehiculo frmEditar = new frmNuevoEditarVehiculo((dgvVehiculo.CurrentRow.Cells["clmPatente"].Value).ToString());
            frmEditar.SeleccionarModo(frmNuevoEditarVehiculo.FormMode.update);
            frmEditar.ShowDialog();
            this.CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el vehiculo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oVehiculoSelected.Patente = dgvVehiculo.CurrentRow.Cells["clmPatente"].Value.ToString();

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
            this.CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPatente.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPasaporte.Text = string.Empty;
            this.CargarGrilla(dgvVehiculo, oVehiculo.RecuperarTodos());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _patente, _marca, _pasaporte;
            _patente = _marca = _pasaporte = string.Empty;

            _patente = this.txtPatente.Text;
            _marca = this.txtMarca.Text;
            _pasaporte = this.txtPasaporte.Text;

            this.CargarGrilla(dgvVehiculo, oVehiculo.RecuperarFiltrados(_patente, _marca, _pasaporte));
        }

        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }
    }
    
}
