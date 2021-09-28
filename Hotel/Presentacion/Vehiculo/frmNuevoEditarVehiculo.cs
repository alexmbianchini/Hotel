using Hotel.Negocio;
using Hotel.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Presentacion
{
    public partial class frmNuevoEditarVehiculo : Form
    {
        // Instanciar FormMode para utilizar en sentencia CASE
        private FormMode formMode = new FormMode();

        // Los diferentes modos que acepta el FormMode
        public enum FormMode
        {
            insert,
            update
        }


        VehiculoService oVehiculo = new VehiculoService();
        HuespedService oHuesped = new HuespedService();
        Vehiculo oVehiculoSelected = new Vehiculo();
        private string _patente; 

        public frmNuevoEditarVehiculo()
        {
            InitializeComponent();
        }
        public frmNuevoEditarVehiculo(string patente)
        {
            InitializeComponent();
            _patente = patente;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    // Validar que los campos estén cargados
                    if (this.ValidarCampos())
                    {
                        if (PatenteCorrecta(txtPatente.Text))
                        {
                            // Validar que el pasaporte tenga el formato correcto
                            if (PasaporteCorrecto(this.txtPasaporte.Text))
                            {
                                // Validar que exista el pasaporte
                                if (!oHuesped.ValidarPasaporte(this.txtPasaporte.Text))
                                {
                                    // Asignar los valores ingresados al objeto Huesped
                                    this.AsignarValores();

                                    // Creación del Huesped, retorna true si se agregó exitosamente, retorna false si no se logró crear.
                                    if (oVehiculo.Crear(oVehiculoSelected))
                                    {
                                        MessageBox.Show("Nuevo Vehiculo Agregado");
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ha ocurrido un error al agregar un Vehiculo");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("No existe un Huesped con este Pasaporte!");
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
                        else
                        {
                            MessageBox.Show("El Formato de patente debe ser 'AA000AA' o 'AAA000'");
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
                        if (oVehiculo.Modificar(oVehiculoSelected))
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
    

        private void frmNuevoEditarVehiculo_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;

            switch (formMode)
            {
                // EN caso de que se quiera crear un Huesped...
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Vehiculo";

                        break;
                    }
                // En caso de que se quiera modificar un Huesped...
                case FormMode.update:
                    {
                        this.CargarCampos();
                        this.Text = "Edición Vehiculo";
                        // Se deshabilita el TextBox de Pasaporte ya que el número de pasaporte es PK y no se debe poder modificar.
                        this.txtPasaporte.Enabled = false;
                        this.txtPatente.Enabled = false;
                        break;
                    }
            }
        }



        // Carga los campos con el objeto recuepeardo de la Grilla.
        private void CargarCampos()
        {
            DataTable tablaVehiculo = new DataTable();

            tablaVehiculo = oVehiculo.RecuperarPorPatente(_patente);

            txtPatente.Text = tablaVehiculo.Rows[0]["patente"].ToString();
            txtMarca.Text = tablaVehiculo.Rows[0]["marca"].ToString();
            txtModelo.Text = tablaVehiculo.Rows[0]["modelo"].ToString();
            txtPasaporte.Text = tablaVehiculo.Rows[0]["pasaporte"].ToString();
            txtNombre.Text = tablaVehiculo.Rows[0]["nombre"].ToString();
            txtApellido.Text = tablaVehiculo.Rows[0]["apellido"].ToString();
        }



        // Valida que los campos no estén vacíos.
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtPasaporte.Text))
            {
                MessageBox.Show("Debe ingresar un Número de Pasaporte");
                this.txtPasaporte.Focus();
                this.lblPasaporte.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPatente.Text))
            {
                MessageBox.Show("Debe ingresar una Patente");
                this.txtPatente.Focus();
                this.lblPatente.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtMarca.Text))
            {
                MessageBox.Show("Debe ingresar una Patente");
                this.txtMarca.Focus();
                this.lblMarca.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtModelo.Text))
            {
                MessageBox.Show("Debe ingresar una Patente");
                this.txtModelo.Focus();
                this.lblModelo.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe verificar que exista un Huesped");
                this.lblNombre.ForeColor = Color.Red;
                this.lblApellido.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void AsignarValores()
        {
            // Insertar los datos en el objeto 
            this.oVehiculoSelected.Patente = txtPatente.Text;
            this.oVehiculoSelected.Marca = txtMarca.Text;
            this.oVehiculoSelected.Modelo = txtModelo.Text;
            this.oVehiculoSelected.PasaporteHuesped = txtPasaporte.Text;
        }

        // Selecciona unos de los dos opciones disponibles para el CASE
        public void SeleccionarModo(FormMode op)
        {
            this.formMode = op;
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


        private bool PatenteCorrecta(string patente)
        {

            Regex formato1 = new Regex(@"[A-Z]{2}[0-9]{3}[A-Z]{2}");
            Regex formato2 = new Regex(@"[A-Z]{3}[0-9]{3}");

            if (patente.Length == 7)
            {
                if (formato1.IsMatch(patente))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (patente.Length == 6)
            {
                if (formato2.IsMatch(patente))
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

       private void txtPasaporte_KeyUp(object sender, KeyEventArgs e)
        {
            /*DataTable huesped = oHuesped.RecuperarPorNumero(txtPasaporte.Text);

            txtNombre.Text = huesped.Rows[0]["nombre"].ToString();
            txtApellido.Text = huesped.Rows[0]["apellido"].ToString();*/

        } 

        private void txtPasaporte_KeyDown(object sender, KeyEventArgs e)
        {
           /* DataTable huesped = oHuesped.RecuperarPorNumero(txtPasaporte.Text);

            txtNombre.Text = huesped.Rows[0]["nombre"].ToString();
            txtApellido.Text = huesped.Rows[0]["apellido"].ToString();
           */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnBuscarHuesped_Click(object sender, EventArgs e)
        {
            DataTable huesped = oHuesped.RecuperarPorNumero(txtPasaporte.Text);

            if (PasaporteCorrecto(txtPasaporte.Text))
            {
                if (huesped.Rows.Count > 0)
                {
                    txtNombre.Text = huesped.Rows[0]["nombre"].ToString();
                    txtApellido.Text = huesped.Rows[0]["apellido"].ToString();
                }
                else
                {
                    MessageBox.Show("No existe un Huesped con este Pasaporte!");
                    this.txtPasaporte.Focus();
                    this.txtPasaporte.Text = string.Empty;
                    this.lblPasaporte.ForeColor = Color.Red;
                }
                
            }
            else
            {
                MessageBox.Show("El Formato de pasaporte debe ser 'AAA000000', 3 letras y 6 números");
                this.txtPasaporte.Focus();
                this.txtPasaporte.Text = string.Empty;
                this.lblPasaporte.ForeColor = Color.Red;
            }
        }
    }
}
