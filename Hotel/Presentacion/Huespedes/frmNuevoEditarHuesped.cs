using Hotel.Servicios;
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
using static Hotel.Presentacion.frmAMTipoHabitacion;
using System.Text.RegularExpressions;

namespace Hotel.Presentacion.Huesped
{
    public partial class frmNuevoEditarHuesped : Form
    {

        // Instanciar FormMode para utilizar en sentencia CASE
        private FormMode formMode = new FormMode();

        // Instanciar objetos que vamos a utilizar
        HuespedService oHuesped = new HuespedService();
        PaisService oPais = new PaisService();
        Hotel.Negocio.Huesped oHuespedSelected = new Hotel.Negocio.Huesped();

        // Stirng para almacenar pasaporte recuperado de la grilla.
        private string numeroPasaporte;

        public frmNuevoEditarHuesped()
        {
            InitializeComponent();
        }

        // constructor que se utiliza para traer el pasaporte desde la grilla
        public frmNuevoEditarHuesped(string numeroPasaporte)
        {
            InitializeComponent();
            this.numeroPasaporte = numeroPasaporte;
        }


        // Los diferentes modos que acepta el FormMode
        public enum FormMode
        {
            insert,
            update
        }

        private void frmNuevoEditarHuesped_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                // EN caso de que se quiera crear un Huesped...
                case FormMode.insert:
                    {
                        this.CargarCombo(cboPais, oPais.RecuperarTodos(), "nombre", "id");
                        this.Text = "Nuevo Huesped";

                        break;
                    }
                // En caso de que se quiera modificar un Huesped...
                case FormMode.update:
                    {
                        this.CargarCampos();
                        this.Text = "Edición Huesped";
                        // Se deshabilita el TextBox de Pasaporte ya que el número de pasaporte es PK y no se debe poder modificar.
                        this.txtPasaporte.Enabled = false;
                        break;
                    }
            }


        }



        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            switch (formMode)
            {
                case FormMode.insert:
                    // Validar que los campos estén cargados
                    if (this.ValidarCampos())
                    {
                        // Validar que el pasaporte tenga el formato correcto
                        if (PasaporteCorrecto(this.txtPasaporte.Text))
                        {
                            // Validar que no exista otro huesped con el mismo pasaporte
                            if (oHuesped.ValidarPasaporte(this.txtPasaporte.Text))
                            {
                                // Asignar los valores ingresados al objeto Huesped
                                this.AsignarValores();

                                // Creación del Huesped, retorna true si se agregó exitosamente, retorna false si no se logró crear.
                                if (oHuesped.Crear(oHuespedSelected))
                                {
                                    MessageBox.Show("Nuevo Huesped Agregado");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error al agregar un Huesped");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Ya existe un Huesped con este Pasaporte!");
                                this.txtPasaporte.Focus();
                                this.lblPasaporte.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Formato de pasaporte debe ser 'AAA000000', 3 letras y 6 números");
                            this.txtPasaporte.Focus();
                            this.lblPasaporte.ForeColor = Color.Red;
                        }
                    }

                    break;

                case FormMode.update:
                    // Validar que los campos estén cargados
                    if (this.ValidarCampos())
                    {
                        // Asigna los valores ingresados al objeto Huesped
                        this.AsignarValores();

                        // Modificacion del Huesped, retorna true si se modificó exitosamente, retorna false si no se logró modificar.
                        if (oHuesped.Modificar(oHuespedSelected))
                        {
                            MessageBox.Show("Datos modificados");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido al modificar los datos");
                        }

                        
                    }


                    break;

            }
        }

        // Carga los campos con el objeto recuepeardo de la Grilla.
        private void CargarCampos()
        { 
                DataTable tablaHuesped = new DataTable();

                tablaHuesped = oHuesped.RecuperarPorNumero(numeroPasaporte);

                txtNombre.Text = tablaHuesped.Rows[0]["nombre"].ToString();
                txtApellido.Text = tablaHuesped.Rows[0]["apellido"].ToString();
                txtPasaporte.Text = tablaHuesped.Rows[0]["numero_pasaporte"].ToString();
                txtMail.Text = tablaHuesped.Rows[0]["mail"].ToString();
                this.CargarCombo(cboPais, oPais.RecuperarTodos(), "nombre", "id", (int)tablaHuesped.Rows[0]["pais"]);

        }
        // Cargar combos genéricos
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
                combo.DataSource = tabla;
                combo.DisplayMember = campoMostrar;
                combo.ValueMember = campoValor;
                combo.SelectedIndex = -1;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Cargar combos genéericos, con valor inicial ya seleccionado.
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor, int campoIndice)
        {
                combo.DataSource = tabla;
                combo.DisplayMember = campoMostrar;
                combo.ValueMember = campoValor;
                combo.SelectedIndex = campoIndice - 1;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Valida que los campos no estén vacíos.
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre");
                this.txtNombre.Focus();
                this.lblNombre.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un Apellido");
                this.txtApellido.Focus();
                this.lblApellido.ForeColor = Color.Red;
                return false;
            }

            if (cboPais.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un País");
                this.cboPais.Focus();
                this.lblPais.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPasaporte.Text))
            {
                MessageBox.Show("Debe seleccionar un Número de Pasaporte");
                this.txtPasaporte.Focus();
                this.lblPasaporte.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtMail.Text))
            {
                MessageBox.Show("Debe ingresar un Mail");
                this.txtMail.Focus();
                this.lblMail.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void AsignarValores()
        {
            // Insertar los datos en el objeto 
            this.oHuespedSelected.Nombre = txtNombre.Text;
            this.oHuespedSelected.Apellido = txtApellido.Text;
            this.oHuespedSelected.NumeroPasaporte = txtPasaporte.Text;
            this.oHuespedSelected.PaisResidencia = Convert.ToInt32(cboPais.SelectedValue);
            this.oHuespedSelected.Mail = txtMail.Text;
        }
        
        // Selecciona unos de los dos opciones disponibles para el CASE
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

        
        // Valida que el pasaporte tenga el formato correcto, 3 letras y 6 números (AAA000000)
        private bool PasaporteCorrecto(string pasaporte)
        {
            
            Regex formato = new Regex(@"[A-Z]{3}[0-9]{6}");

            if (pasaporte.Length == 9)
            {
                if (formato.IsMatch(pasaporte))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }

        }
    }
}
