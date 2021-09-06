using Hotel.Negocio;
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
        Usuario oUsuario = new Usuario();
        Empleado oEmpleado = new Empleado();
        Puesto oPuesto = new Puesto();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {   
            // Inicializamos los dateTimePicker con la fecha actual
            this.dtpFechaIngreso.Value= DateTime.Today;


            //Carga de ComboBoxs
            this.CargarCombo(cboNombreUsuario, oUsuario.RecuperarTodos(), "nombre", "id");
            this.CargarCombo(cboApellidoEmpleado, oEmpleado.RecuperarTodos(), "apellido", "id_empleado");
            this.CargarCombo(cboPuesto, oPuesto.RecuperarTodos(), "descripcion", "cod_puesto");
            this.CargarCombo(cboNombreEmpleado, oEmpleado.RecuperarTodos(), "nombre", "id_empleado");

            //Carga de Grilla
            this.CargarGrilla(dgvUsuarios, oUsuario.RecuperarGrilla());


            //Habilitacion de Botones
            this.btnConsultar.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnEliminar.Enabled = true;
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
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["puesto"],
                                tabla.Rows[i]["fecha_ingreso"]);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.dtpFechaIngreso.Value = DateTime.Today;
            this.cboApellidoEmpleado.SelectedIndex = -1;
            this.cboNombreUsuario.SelectedIndex = -1;
            this.cboPuesto.SelectedIndex = -1;
            this.cboNombreEmpleado.SelectedIndex = -1;
            
        }

    }
}
