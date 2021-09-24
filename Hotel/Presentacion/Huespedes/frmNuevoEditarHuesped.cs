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

        private FormMode formMode = new FormMode();

        HuespedService oHuesped = new HuespedService();
        PaisService oPais = new PaisService();
        Hotel.Negocio.Huesped oHuespedSelected = new Hotel.Negocio.Huesped();

        private string numeroPasaporte;

        public frmNuevoEditarHuesped()
        {
            InitializeComponent();
        }

        public frmNuevoEditarHuesped(string numeroPasaporte)
        {
            InitializeComponent();
            this.numeroPasaporte = numeroPasaporte;
        }



        public enum FormMode
        {
            insert,
            update
        }

        private void frmNuevoEditarHuesped_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.CargarCombo(cboPais, oPais.RecuperarTodos(), "nombre", "id");
                        this.Text = "Nuevo Huesped";

                        break;
                    }

                case FormMode.update:
                    {
                        this.CargarCampos();
                        this.Text = "Edición Huesped";
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
                    if (this.ValidarCampos())
                    {
                        if (PasaporteCorrecto(this.txtPasaporte.Text))
                        {

                            if (oHuesped.ValidarPasaporte(this.txtPasaporte.Text))
                            {
                                this.AsignarValores();

                                if (oHuesped.Crear(oHuespedSelected))
                                {
                                    MessageBox.Show("Nuevo Huesped Agregado");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido al agregar un Huesped");
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
                    if (this.ValidarCampos())
                    {
                        
                        this.AsignarValores();

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

        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
                combo.DataSource = tabla;
                combo.DisplayMember = campoMostrar;
                combo.ValueMember = campoValor;
                combo.SelectedIndex = -1;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor, int campoIndice)
        {
                combo.DataSource = tabla;
                combo.DisplayMember = campoMostrar;
                combo.ValueMember = campoValor;
                combo.SelectedIndex = campoIndice - 1;
                combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


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

        private bool PasaporteCorrecto(string pasaporte)
        {
            //char[] caracteres = pasaporte.ToCharArray();

            Regex numeros = new Regex(@"[0-9]");
            Regex letras = new Regex(@"[A-Z]");

            if (pasaporte.Length == 9)
            {
                foreach (char c in pasaporte)
                {
                    int contador = 0;

                    if (!letras.IsMatch(c.ToString()) && contador < 4)
                    {
                        contador += 1;
                        continue;
                    }
                   
                    else if(!numeros.IsMatch(c.ToString()) && contador > 3 && contador < 10)
                    {
                        contador += 1;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
