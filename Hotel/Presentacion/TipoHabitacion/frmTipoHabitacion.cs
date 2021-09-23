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

namespace Hotel.Presentacion.TipoHabitacion
{
    public partial class frmTipoHabitacion : Form
    {
        TipoHabitacionService oTipoHabitacion;
        TipoHabitacion oTipohabitacionSelected;

        public frmTipoHabitacion()
        {
            InitializeComponent();
            oTipoHabitacion = new TipoHabitacionService(); 
        }

        private void frmTipoHabitacion_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cboNombre, oTipoHabitacion.RecuperarTodos(), "nombre", "cod_tipo");
        }
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
