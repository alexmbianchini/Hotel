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
        // Instanciar objetos a utililar.
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
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
        }

        // Cargar todos los datos de la grilla y el ComBox
        private void CargarTodo()
        {
            this.CargarCombo(cboPais, oPais.RecuperarTodos(), "nombre", "id");

            this.CargarGrilla(dvgHuespedes, oHuesped.RecuperarTodos());
        }

        // Carga la grilla con todos los Huespedes que recupera de la DB.
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
            // Instanciar formulario para crear un Huesped
            frmNuevoEditarHuesped frmNueva = new frmNuevoEditarHuesped();
            frmNueva.SeleccionarModo(frmNuevoEditarHuesped.FormMode.insert);
            frmNueva.ShowDialog();
            this.CargarTodo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Instanciar un formulario para editar un huesped
            frmNuevoEditarHuesped frmEditar = new frmNuevoEditarHuesped((dvgHuespedes.CurrentRow.Cells["clmNumeroPasaporte"].Value).ToString());
            frmEditar.SeleccionarModo(frmNuevoEditarHuesped.FormMode.update);
            frmEditar.ShowDialog();
            this.CargarTodo();
        }

        // Botón para eliminar un huesped
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el Empleado seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oHuespedSelected.NumeroPasaporte = dvgHuespedes.CurrentRow.Cells["clmNumeroPasaporte"].Value.ToString();
                
                // Retorna true si el huesped es eliminado o retorna false si no se puedo eliminar
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
            // cierra el frm
            this.Close();
        }

        // Limpia los campos para que se puedan volver a utlizar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtPsaporte.Text = string.Empty;
            this.cboPais.SelectedIndex = -1;
            this.CargarTodo();
        }

        // Realiza una consulta con datos filtrados 
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

        private void dvgHuespedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }
    }
}
