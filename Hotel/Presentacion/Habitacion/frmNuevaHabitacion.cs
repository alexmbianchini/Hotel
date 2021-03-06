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
        Habitacion oHabitacionSelected;
        ComboBoxService oCombo = new ComboBoxService();
        //TipoHabitacion oTipoHSelected;
        PisoService oPiso;

        //Atributos a utilizar
        private int numHabitacion;
       
        public frmNuevaHabitacion()
        {
            InitializeComponent();
            oHabitacion = new HabitacionService();
            oTipoHabitacion = new TipoHabitacionService();
            oHabitacionSelected = new Habitacion();
            //oTipoHSelected = new TipoHabitacion();
            oPiso = new PisoService();
        }
        public frmNuevaHabitacion(int numHabitacion)
        {
            InitializeComponent();
            oHabitacion = new HabitacionService();
            oTipoHabitacion = new TipoHabitacionService();
            oHabitacionSelected = new Habitacion();
            //oTipoHSelected = new TipoHabitacion();
            oPiso = new PisoService();
            this.numHabitacion = Convert.ToInt32(numHabitacion);
        }

        public enum FormMode
        {
            insert,
            update
        }


        private void frmNuevaHabitacion_Load(object sender, EventArgs e)
        {
            // Cargar combo
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        oCombo.CargarCombo(cboTipoHabitacion, oTipoHabitacion.RecuperarTodos(), "nombre", "cod_tipo");
                        this.Text = "Nueva Habitación";
                        //this.txtDescripcionHabitacion.Enabled = false;
                        break;
                    }

                case FormMode.update:
                    {
                        this.CargarCampos();
                        this.Text = "Edición Habitación";
                        break;
                    }
            }


        }

        

        public void SeleccionarModo(FormMode op)
        {
            this.formMode = op;
        }

        private void CargarCampos()
        {
            DataTable tablaHabitacion = new DataTable();

            tablaHabitacion = oHabitacion.RecuperarPorNumero(numHabitacion);
            
            txtPiso.Text = tablaHabitacion.Rows[0]["piso"].ToString();
            txtPrecioHabitacion.Text = tablaHabitacion.Rows[0]["precio"].ToString();
            //txtDescripcionHabitacion.Text = tablaHabitacion.Rows[0]["descripcion"].ToString();
            oCombo.CargarCombo(cboTipoHabitacion, oTipoHabitacion.RecuperarTodos(), "nombre", "cod_tipo", (int)tablaHabitacion.Rows[0]["tipo_habitacion"]);

        }


        private bool ValidarCompletitudCampos()
        {
            //Validar que los campos no esten vacíos
            if(string.IsNullOrEmpty(this.txtPiso.Text))
            {
                MessageBox.Show("Debe ingresar un piso");
                this.txtPiso.Focus();
                this.lblPisoHabitacion.ForeColor = Color.Red;
                return false;
            }
            if(this.cboTipoHabitacion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un tipo de habitación");
                this.cboTipoHabitacion.Focus();
                this.lblTipoHabitacion.ForeColor = Color.Red;
                return false;
            }
            if(string.IsNullOrEmpty(this.txtPrecioHabitacion.Text))
            {
                MessageBox.Show("Debe ingresar un precio de habitación");
                this.txtPrecioHabitacion.Focus();
                this.lblPrecioHabitacion.ForeColor = Color.Red;
                return false;
            }
            /*if (string.IsNullOrEmpty(this.txtDescripcionHabitacion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción de la habitación");
                this.txtDescripcionHabitacion.Focus();
                this.lblDescripcionHabitacion.ForeColor = Color.Red;
                return false;
            }*/
            
            return true;

        }


        private bool ValidarPiso()
        {

            int _cantidad = oPiso.RecuperarNumeros().Rows.Count;

            if (Convert.ToInt32(txtPiso.Text) > _cantidad || Convert.ToInt32(txtPiso.Text) < 1)
            {
                MessageBox.Show("Ingrese un piso entre 1 y 5, piso no válido!");
                this.txtPiso.Clear();
                this.txtPiso.Focus();
                return true;
            }
            return false;
        }

        private bool ValidarPrecio()
        {
            if (Convert.ToDouble(txtPrecioHabitacion.Text) < 0)
            {
                MessageBox.Show("Ingrese un precio válido!");
                this.txtPrecioHabitacion.Clear();
                this.txtPrecioHabitacion.Focus();
                return true;
            }
            return false;
        }

        private void AsignarValores()
        {
            //Asigna los valores de los campos al Usuario, menos el número 
            this.oHabitacionSelected.Piso = Convert.ToInt32(txtPiso.Text);
            this.oHabitacionSelected.TipoHabitacion = Convert.ToInt32(cboTipoHabitacion.SelectedValue);
            this.oHabitacionSelected.Precio = (float)Convert.ToDouble(txtPrecioHabitacion.Text);
            //this.oTipoHSelected.Descripcion = txtDescripcionHabitacion.Text;
            //this.oTipoHSelected.CodTipo = Convert.ToInt32(cboTipoHabitacion.SelectedValue);
        }
        private int GenerarNumero(DataTable tabla)
        {
            int numero = tabla.Rows.Count + 1;

            return numero;
        }

        private void btnAceptarHabitacion_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    if (this.ValidarCompletitudCampos())
                    {
                        if (ValidarPiso())
                        {

                        }
                        else
                        {
                            if (ValidarPrecio())
                            {

                            }
                            else
                            {
                                //Se pasan las validaciones, generamos numero y asignamos los valores para insertar el usuario en la BD
                                oHabitacionSelected.Numero = this.GenerarNumero(this.oHabitacion.RecuperarNumeros());
                                this.AsignarValores();

                                //Agregar a la BD
                                if (oHabitacion.Crear(oHabitacionSelected))
                                {
                                    MessageBox.Show("Nueva Habitación Ingresada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un Error al crear la Habitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    break;
                case FormMode.update:
                    if (this.ValidarCompletitudCampos())
                    {
                        //Validación de que los campos tengan valores válidos al dominio
                        if (ValidarPiso())
                        {

                        }
                        else
                        {
                            if (ValidarPrecio())
                            {

                            }
                            else
                            {
                                //Se pasan las validaciones y asignamos los valores para insertar el usuario en la BD
                                this.oHabitacionSelected.Numero = numHabitacion;
                                this.AsignarValores();

                                //Modificacion en la BD
                                if (oHabitacion.Modificar(oHabitacionSelected)) //&& oTipoHabitacion.Modificar(oTipoHSelected)
                                {
                                    MessageBox.Show("Se ha editado la Habitación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error al insertar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                    }
                    break;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

}
