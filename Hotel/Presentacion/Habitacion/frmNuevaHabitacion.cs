using Hotel.Datos;
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
    public partial class frmNuevaHabitacion : Form
    {
        // Instanciar objetos 

        HabitacionDao oHabitacion = new HabitacionDao();
        TipoHabitacionDao oTipoHabitacion = new TipoHabitacionDao();
        public frmNuevaHabitacion()
        {
            InitializeComponent();
        }

        private void frmNuevaHabitacion_Load(object sender, EventArgs e)
        {
            // Cargar combo
            this.CargarCombo(cboTipoHabitacion, oTipoHabitacion.RecuperarTodos(), "descripcion", "cod_tipo");


        }

        // Funcion para cargar combo
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

}
