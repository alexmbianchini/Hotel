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
    public partial class frmHabitacion : Form
    {
        Habitacion oHabitacion = new Habitacion();
        TipoHabitacion oTipoH = new TipoHabitacion();
        EstadoHabitacion oEstadoH = new EstadoHabitacion();

        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            //Carga de Combos
            this.CargarCombo(cboNumero, oHabitacion.RecuperarTodos(), "numero", "numero");
            this.CargarCombo(cboPiso, oHabitacion.RecuperarTodos(), "piso", "numero");
            this.CargarCombo(cboTipo, oTipoH.RecuperarTodos(), "descripcion", "cod_tipo");
            this.CargarCombo(cboEstado, oEstadoH.RecuperarTodos(), "descripcion", "idEstado");

            //Carga Grilla
            this.CargarGrilla(dgvHabitaciones, oHabitacion.RecuperarGrilla());




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
            string _numero, _piso, _tipo, _estado;
            _numero = _piso = _tipo = _estado = string.Empty;


            if (cboNumero.SelectedIndex != -1)
                _numero = cboNumero.SelectedValue.ToString();
            if (cboPiso.SelectedIndex != -1)
                _piso = cboPiso.SelectedValue.ToString();
            if (cboTipo.SelectedIndex != -1)
                _tipo = cboTipo.SelectedValue.ToString();
            if (cboEstado.SelectedIndex != -1)
                _estado = cboEstado.SelectedValue.ToString();


            this.CargarGrilla(dgvHabitaciones, oHabitacion.RecuperarFiltrados(_numero, _piso, _tipo, _estado));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cboNumero.SelectedIndex = -1;
            this.cboPiso.SelectedIndex = -1;
            this.cboTipo.SelectedIndex = -1;
            this.cboEstado.SelectedIndex = -1;
        }
    }
}
