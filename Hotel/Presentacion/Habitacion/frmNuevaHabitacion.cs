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
    public partial class frmNuevaHabitacion : Form
    {
        private FormMode formMode = new FormMode();


        // Instanciar objetos 
        HabitacionService oHabitacion;
        TipoHabitacionService oTipoHabitacion;

        //Variables a Utilizar
        int numHabitacion;
       
        public frmNuevaHabitacion()
        {
            InitializeComponent();
            oHabitacion = new HabitacionService();
            oTipoHabitacion = new TipoHabitacionService();
        }
        public frmNuevaHabitacion(int numHabitacion)
        {
            InitializeComponent();
            oHabitacion = new HabitacionService();
            oTipoHabitacion = new TipoHabitacionService();
            this.numHabitacion = numHabitacion;

        }

        public enum FormMode
        {
            insert,
            update
        }


        private void frmNuevaHabitacion_Load(object sender, EventArgs e)
        {
            // Cargar combo
            this.CargarCombo(cboTipoHabitacion, oTipoHabitacion.RecuperarTodos(), "descripcion", "cod_tipo");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Habitación";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Edición Habitación";
                        break;
                    }
            }


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

        public void SeleccionarModo(FormMode op)
        {
            this.formMode = op;
        }

        private void CargarCampos()
        {
            DataTable tablaHabitacion = new DataTable();
            DataTable tablaTipoH = new DataTable();
            DataTable tablaEstadoH = new DataTable();

            tablaHabitacion = oHabitacion.RecuperarPorNumero(numHabitacion);
            
            txtPiso.Text = tablaHabitacion.Rows[0]["piso"].ToString();
            txtPrecioHabitacion.Text = tablaHabitacion.Rows[0]["precio"].ToString();
            txtDescripcionHabitacion.Text = tablaHabitacion.Rows[0]["descripcion"].ToString();

            /*
            txtNombre.Text = tablaEmpleado.Rows[0]["nombre"].ToString();
            txtApellido.Text = tablaEmpleado.Rows[0]["apellido"].ToString();
            this.CargarCombo(cboTipoDocumento, oTipoDoc.RecuperarTodos(), "descripcion", "tipo_doc", (int)tablaEmpleado.Rows[0]["tipo_doc"]);
            this.CargarCombo(cboPuesto, oPuesto.RecuperarTodos(), "descripcion", "cod_puesto", (int)tablaEmpleado.Rows[0]["puesto"]);
            txtNumeroDocumento.Text = tablaEmpleado.Rows[0]["nro_doc"].ToString();

            txtUsuario.Text = tablaUsuario.Rows[0]["nombre"].ToString();
            */
        }

    }

}
