using Hotel.Datos;
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
    public partial class frmHabitacion : Form
    {
        HabitacionService oHabitacion = new HabitacionService();
        TipoHabitacionService oTipoH = new TipoHabitacionService();
        EstadoHabitacionService oEstadoH = new EstadoHabitacionService();
        Habitacion oHabitacionSelected = new Habitacion();

        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            this.CargarTodos();

        }


        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["numero"],
                                tabla.Rows[i]["estado"],
                                tabla.Rows[i]["piso"],
                                tabla.Rows[i]["tipo"],
                                tabla.Rows[i]["precio"],
                                tabla.Rows[i]["descripcion"]);
            }

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            string _numero, _piso, _tipo, _estado, _precioDesde, _precioHasta;
            _numero = _piso = _tipo = _estado = _precioDesde = _precioHasta = string.Empty;


            _numero = txtNumero.Text;
            _piso = txtPiso.Text;
            if (cboTipo.SelectedIndex != -1)
                _tipo = cboTipo.SelectedValue.ToString();
            if (cboEstado.SelectedIndex != -1)
                _estado = cboEstado.SelectedValue.ToString();
            _precioDesde = txtPrecioMin.Text;
            _precioHasta = txtPrecioMax.Text;


            this.CargarGrilla(dgvHabitaciones, oHabitacion.RecuperarFiltrados(_numero, _piso, _tipo, _estado, _precioDesde, _precioHasta));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumero.Text = string.Empty;
            this.txtPiso.Text = string.Empty;
            this.cboTipo.SelectedIndex = -1;
            this.cboEstado.SelectedIndex = -1;
            this.txtPrecioMin.Text = string.Empty;
            this.txtPrecioMax.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevaHabitacion frmNueva = new frmNuevaHabitacion();
            frmNueva.SeleccionarModo(frmNuevaHabitacion.FormMode.insert);
            frmNueva.ShowDialog();
            this.CargarTodos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTodos()
        {
            //Carga de Combos
            //this.CargarCombo(cboNumero, oHabitacion.RecuperarTodos(), "numero", "numero");
            //this.CargarCombo(cboPiso, oHabitacion.RecuperarTodos(), "piso", "piso");
            this.CargarCombo(cboTipo, oTipoH.RecuperarTodos(), "nombre", "cod_tipo");
            this.CargarCombo(cboEstado, oEstadoH.RecuperarTodos(), "descripcion", "idEstado");

            //Carga Grilla
            this.CargarGrilla(dgvHabitaciones, oHabitacion.RecuperarGrilla());
           
            //Habilitacion de Botones
            this.btnConsultar.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnLimpiar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnSalir.Enabled = true;
        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["clmIdUsuario"].Value), Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["clmIdEmpleado"].Value)
            frmNuevaHabitacion frmEditar = new frmNuevaHabitacion(Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells["clmNumero"].Value));
            frmEditar.SeleccionarModo(frmNuevaHabitacion.FormMode.update);
            frmEditar.ShowDialog();
            this.CargarTodos();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar la Habitación seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oHabitacionSelected.Numero = (int)dgvHabitaciones.CurrentRow.Cells["clmNumero"].Value;
                

                if (oHabitacion.Eliminar(oHabitacionSelected))
                {
                    MessageBox.Show("Habitación Eliminada con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar la Habitación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.CargarTodos();
        }
    }
}
