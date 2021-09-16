using Hotel.Datos;
using Hotel.Negocio;
using Hotel.Presentacion.UsuarioEmpleado;
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
    public partial class frmUsuario : Form
    {
        UsuarioDao oUsuario = new UsuarioDao();
        EmpleadoDao oEmpleado = new EmpleadoDao();
        PuestoDao oPuesto = new PuestoDao();
        TipoDocumentoDao oTipoDoc = new TipoDocumentoDao();
        Usuario oUsuarioSelected = new Usuario();
        Empleado oEmpleadoSelected = new Empleado();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {   
            // Inicializamos los dateTimePicker con la fecha actual
            //this.dtpFechaIngreso.Value= DateTime.Today;


            //Carga de ComboBoxs
            this.CargarCombo(cboNombreUsuario, oUsuario.RecuperarTodos(), "nombre", "nombre");
            this.CargarCombo(cboApellidoEmpleado, oEmpleado.RecuperarTodos(), "apellido", "apellido");
            this.CargarCombo(cboPuesto, oPuesto.RecuperarTodos(), "descripcion", "cod_puesto");
            this.CargarCombo(cboNombreEmpleado, oEmpleado.RecuperarTodos(), "nombre", "nombre");
            this.CargarCombo(cboTipoDoc, oTipoDoc.RecuperarTodos(), "descripcion", "tipo_doc");
            this.CargarCombo(cboNroDoc, oEmpleado.RecuperarTodos(), "nro_doc", "nro_doc");

            //Carga de Grilla
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarGrilla());


            //Habilitacion de Botones
            this.btnConsultar.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnLimpiar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnSalir.Enabled = true;

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
                grilla.Rows.Add(tabla.Rows[i]["id"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["id_empleado"],
                                tabla.Rows[i]["tpo_doc"],
                                tabla.Rows[i]["nro_doc"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["puesto"]);
            }

        }



        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            //this.dtpFechaIngreso.Value = DateTime.Today;
            this.cboApellidoEmpleado.SelectedIndex = -1;
            this.cboNombreUsuario.SelectedIndex = -1;
            this.cboPuesto.SelectedIndex = -1;
            this.cboNombreEmpleado.SelectedIndex = -1;
            this.cboTipoDoc.SelectedIndex = -1;
            this.cboNroDoc.SelectedIndex = -1;
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            string _usuario, _apellido, _nombre, _puesto, _tipo_doc, _nro_doc;
            _usuario = _apellido = _nombre = _puesto = _tipo_doc = _nro_doc = string.Empty;

            /*
            if (dtpFechaIngreso.Value > DateTime.Today)
            {
                MessageBox.Show("Fecha no válida!");
                dtpFechaIngreso.Focus();
                return;
            }
            */
            if (cboNombreUsuario.SelectedIndex != -1)
                _usuario = cboNombreUsuario.SelectedValue.ToString();
            if (cboApellidoEmpleado.SelectedIndex != -1)
                _apellido = cboApellidoEmpleado.SelectedValue.ToString();
            if (cboNombreEmpleado.SelectedIndex != -1)
                _nombre = cboNombreEmpleado.SelectedValue.ToString();
            if (cboPuesto.SelectedIndex != -1)
                _puesto = cboPuesto.SelectedValue.ToString();
            if (cboTipoDoc.SelectedIndex != -1)
                _tipo_doc = cboTipoDoc.SelectedValue.ToString();
            if (cboNroDoc.SelectedIndex != -1)
                _nro_doc = cboNroDoc.SelectedValue.ToString();


            //dtpFechaIngreso.Value.ToString()) en caso de agregar fecha
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarFiltrados(_usuario, _apellido, _nombre, _puesto, _tipo_doc, _nro_doc));
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmUsuarioNuevo frmNuevo = new frmUsuarioNuevo();

            frmNuevo.Show();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            frmUsuarioEditar oEditar = new frmUsuarioEditar(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["clmIdUsuario"].Value), Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["clmIdEmpleado"].Value));
            oEditar.ShowDialog();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Eliminar el Empleado seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.oUsuarioSelected.Id = (int)dgvUsuarios.CurrentRow.Cells["clmIdUsuario"].Value;
                this.oEmpleadoSelected.IdEmpleado = (int)dgvUsuarios.CurrentRow.Cells["clmIdEmpleado"].Value;
                this.oEmpleadoSelected.FechaSalidaTrabajo = DateTime.Today;

                if (oEmpleado.Eliminar(oEmpleadoSelected) && oUsuario.Eliminar(oUsuarioSelected))
                {
                    MessageBox.Show("Empleado Eliminado con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
        }
    }
}
