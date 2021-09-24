using Hotel.Presentacion.Huesped;
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

namespace Hotel.Presentacion.Huespedes
{
    public partial class frmHuesped : Form
    {

        HuespedService oHuesped = new HuespedService();
        PaisService oPais = new PaisService();
        Hotel.Negocio.Huesped oHuespedSelected = new Hotel.Negocio.Huesped();

        public frmHuesped()
        {
            InitializeComponent();
        }

        private void frmHuesped_Load(object sender, EventArgs e)
        {
            this.CargarTodo();
        }

        private void CargarTodo()
        {
            this.CargarCombo(cboPais, oPais.RecuperarTodos(), "nombre", "id");

            this.CargarGrilla(dvgHuespedes, oHuesped.RecuperarTodos());
        }

        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["numero_pasaporte"],
                                tabla.Rows[i]["mail"],
                                tabla.Rows[i]["pais"]);
            }
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoEditarHuesped frmNueva = new frmNuevoEditarHuesped();
            frmNueva.SeleccionarModo(frmNuevoEditarHuesped.FormMode.insert);
            frmNueva.ShowDialog();
            this.CargarTodo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmNuevoEditarHuesped frmEditar = new frmNuevoEditarHuesped((dvgHuespedes.CurrentRow.Cells["clmNumeroPasaporte"].Value).ToString());
            frmEditar.SeleccionarModo(frmNuevoEditarHuesped.FormMode.update);
            frmEditar.ShowDialog();
            this.CargarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el Empleado seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oHuespedSelected.NumeroPasaporte = dvgHuespedes.CurrentRow.Cells["clmNumeroPasaporte"].Value.ToString();
                

                if (oHuesped.Eliminar(oHuespedSelected))
                {
                    MessageBox.Show("Huesped Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Huesped", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.CargarTodo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtPsaporte.Text = string.Empty;
            this.cboPais.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string _nombre, _apellido, _pasaporte, _pais;
            _nombre = _apellido = _pasaporte = _pais = string.Empty;

            _nombre = this.txtNombre.Text;
            _apellido = this.txtApellido.Text;
            _pasaporte = this.txtPsaporte.Text;
            if (this.cboPais.SelectedIndex != -1)
            {
                _pais = this.cboPais.SelectedValue.ToString();
            }

            this.CargarGrilla(dvgHuespedes, oHuesped.RecuperarFiltrados(_nombre, _apellido, _pasaporte, _pais));
        }
    }
}
