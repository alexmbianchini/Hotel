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

        //Atributos a utilizar
        private int numHabitacion;
       
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
            oHabitacionSelected = new Habitacion();
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
                        this.CargarCombo(cboTipoHabitacion, oTipoHabitacion.RecuperarTodos(), "descripcion", "cod_tipo");
                        this.Text = "Nueva Habitación";
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

        // Funcion para cargar combo
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor, int campoIndice)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = campoIndice - 1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = - 1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            txtDescripcionHabitacion.Text = tablaHabitacion.Rows[0]["descripcion"].ToString();
            this.CargarCombo(cboTipoHabitacion, oTipoHabitacion.RecuperarTodos(), "descripcion", "cod_tipo", (int)tablaHabitacion.Rows[0]["tipo_habitacion"]);

        }

        private void btnAceptarHabitacion_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    if(this.ValidarCompletitudCampos())
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
                                this.GenerarNumero(this.oHabitacion.RecuperarNumeros());
                                this.AsignarValores();

                                //Agregar a la BD
                                if (oHabitacion.Crear(oHabitacionSelected))
                                {
                                    MessageBox.Show("Nueva Habitación Ingresada con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if(this.ValidarCompletitudCampos())
                    {
                        //Validación de que los campos tengan valores válidos al dominio
                        if(ValidarPiso())
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
                                if(oHabitacion.Modificar(oHabitacionSelected))
                                {
                                    MessageBox.Show("Se ha editado la Habitación con Éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error al insertar los datos", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                                }

                            }
                        }
                    }
                    break;
            }
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
            if (string.IsNullOrEmpty(this.txtDescripcionHabitacion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción de la habitación");
                this.txtDescripcionHabitacion.Focus();
                this.lblDescripcionHabitacion.ForeColor = Color.Red;
                return false;
            }
            
            return true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private bool ValidarPiso()
        {
            if (Convert.ToInt32(txtPiso.Text) > 5 || Convert.ToInt32(txtPiso.Text) < 1)
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
            this.oHabitacionSelected.Descripcion = txtDescripcionHabitacion.Text;
        }
        private int GenerarNumero(DataTable tabla)
        {
            int numero = tabla.Rows.Count + 1;

            return numero;
        }

    }

}
