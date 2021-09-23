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
    public partial class frmAMTipoHabitacion : Form
    {
        private FormMode formMode = new FormMode();

        //Objetos
        TipoHabitacionService oTipoH;
        TipoHabitacion oTipoHSelected;

        //Atributos
        int codTipoHabit;
        string nombreTipo;

        public frmAMTipoHabitacion()
        {
            InitializeComponent();
            oTipoH = new TipoHabitacionService();
            oTipoHSelected = new TipoHabitacion();
        }

        public frmAMTipoHabitacion(int codigo)
        {
            InitializeComponent();
            oTipoH = new TipoHabitacionService();
            oTipoHSelected = new TipoHabitacion();
            this.codTipoHabit = codigo;
        }

        public enum FormMode
        {
            insert,
            update
        }

        private void frmAMTipoHabitacion_Load(object sender, EventArgs e)
        {
            switch(formMode)
            {
                case FormMode.insert:
                    this.Text = "Nuevo Tipo Habitación";
                    break;
                

                case FormMode.update:
                    this.Text = "Modificación Tipo Habitación";
                    this.CargarCampos();
                    nombreTipo = this.txtNombre.Text;
                    break;
            }
        }

        private void CargarCampos()
        {
            DataTable tablaTipoHabit = new DataTable();

            tablaTipoHabit = oTipoH.RecuperarPorCodigo(codTipoHabit);

            txtNombre.Text = tablaTipoHabit.Rows[0]["nombre"].ToString();
            txtDescripcion.Text = tablaTipoHabit.Rows[0]["descripcion"].ToString();
        }

        public void SeleccionarModo(FormMode op)
        {
            this.formMode = op;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool ValidarCompletitudCampos()
        {
            //Validar que los campos no esten vacíos
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre");
                this.txtNombre.Focus();
                this.lblNombre.ForeColor = Color.Red;
                return false;
            }
            if (string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar un tipo de habitación");
                this.txtDescripcion.Focus();
                this.lblDescripcion.ForeColor = Color.Red;
                return false;
            }
            return true;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch(formMode)
            {
                case FormMode.insert:
                    if(this.ValidarCompletitudCampos())
                    {
                        if(ValidarNombre())
                        {
                            //oTipoHSelected.CodTipo = 
                        }

                    }
                    break;

                case FormMode.update:
                    if(this.ValidarCompletitudCampos())
                    {
                        if(ValidarNombre())
                        {
                            oTipoHSelected.CodTipo = codTipoHabit;
                            this.AsignarTodos();

                            if(oTipoH.Modificar(oTipoHSelected))
                            {
                                MessageBox.Show("Se ha editado el Tipo Habitación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al insertar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    break;
            }
        }

        private bool ValidarNombre()
        {
            string _nombre = this.oTipoH.ValidarNombreExistente(this.txtNombre.Text);

            if (_nombre == string.Empty && nombreTipo != this.txtNombre.Text)
            {
                MessageBox.Show("El nombre de usuario ya existe, por favor ingrese otro");
                this.txtNombre.Clear();
                this.txtNombre.Focus();
                return false;
            }
            return true;
        }
        
        private void AsignarTodos()
        {
            oTipoHSelected.Nombre = this.txtNombre.Text;
            oTipoHSelected.Descripcion = this.txtDescripcion.Text;
        }
    }
}
