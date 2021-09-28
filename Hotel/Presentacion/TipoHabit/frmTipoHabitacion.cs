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
    public partial class frmTipoHabitacion : Form
    {
        TipoHabitacionService oTipoHabitacion;
        TipoHabitacion oTipoHabitacionSelected;

        public frmTipoHabitacion()
        {
            InitializeComponent();
            oTipoHabitacion = new TipoHabitacionService();
            oTipoHabitacionSelected = new TipoHabitacion();
        }

        private void frmTipoHabitacion_Load(object sender, EventArgs e)
        {
            this.CargarTodo();

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
                grilla.Rows.Add(tabla.Rows[i]["cod_tipo"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["descripcion"]);
            }

        }

        private void CargarTodo()
        {
            //Carga de Combos y Grilla
            this.CargarCombo(cboNombre, oTipoHabitacion.RecuperarTodos(), "nombre", "nombre");
            this.CargarGrilla(dgvTipoHabit, oTipoHabitacion.RecuperarTodos());

            //Botones
            this.btnConsultar.Enabled = true;
            this.btnLimpiar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnSalir.Enabled = true;
        }

        private void dgvTipoHabit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = string.Empty;
            this.cboNombre.SelectedIndex = -1;
            this.txtDescripcion.Text = string.Empty;
            this.CargarGrilla(dgvTipoHabit, oTipoHabitacion.RecuperarTodos());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _codigo, _nombre, _descripcion;
            _codigo = _nombre = _descripcion = string.Empty;

            _codigo = this.txtCodigo.Text;
            if (cboNombre.SelectedIndex != -1)
                _nombre = cboNombre.SelectedValue.ToString();
            _descripcion = this.txtDescripcion.Text;

            this.CargarGrilla(dgvTipoHabit, oTipoHabitacion.RecuperarFiltrados(_codigo, _nombre, _descripcion));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAMTipoHabitacion frmNuevo = new frmAMTipoHabitacion();
            frmNuevo.SeleccionarModo(frmAMTipoHabitacion.FormMode.insert);
            frmNuevo.ShowDialog();
            this.CargarTodo();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAMTipoHabitacion frmEditar = new frmAMTipoHabitacion(Convert.ToInt32(dgvTipoHabit.CurrentRow.Cells["clmCodigo"].Value));
            frmEditar.SeleccionarModo(frmAMTipoHabitacion.FormMode.update);
            frmEditar.ShowDialog();
            this.CargarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el Tipo Habitacion seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oTipoHabitacionSelected.CodTipo = (int)dgvTipoHabit.CurrentRow.Cells["clmCodigo"].Value;


                if (oTipoHabitacion.Eliminar(oTipoHabitacionSelected))
                {
                    MessageBox.Show("Tipo Habitación Eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Tipo Habitación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.CargarTodo();
        }
    }
}
