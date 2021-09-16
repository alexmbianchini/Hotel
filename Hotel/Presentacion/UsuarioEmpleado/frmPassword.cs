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
using System.Text.RegularExpressions;
using Hotel.Servicios;

namespace Hotel.Presentacion.UsuarioEmpleado
{
    public partial class frmPassword : Form
    {
        // Instanciar objetos 
        Usuario oUsuarioSelected = new Usuario();
        UsuarioService oUsuario = new UsuarioService();


        // Creación de constructor 
        public frmPassword(int id)
        {
            InitializeComponent();
            this.oUsuarioSelected.Id = id;
        }
        public frmPassword()
        {
            InitializeComponent();
        }

        private void frmPassword_Load(object sender, EventArgs e)

        {
            // Recuperar Usuario logueado
            this.oUsuarioSelected.Nombre = (oUsuario.RecuperarPorId(this.oUsuarioSelected.Id).Rows[0]["nombre"]).ToString();           
            this.lblUsuario.Text = "Usuario : " + this.oUsuarioSelected.Nombre;
 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Validar que los campos obligatorios no estén vacíos 
            if (this.ValidarCampos())
            {
                // Validar que la contraseña actual del usuario es correcta
                int _validarActual = this.oUsuario.ValidarPassword(this.oUsuarioSelected.Id, this.txtPasswordActual.Text);

                if (_validarActual == 0)
                {
                    MessageBox.Show("La contraseña actual es incorrecta");
                    this.txtPasswordActual.Focus();
                    this.txtPasswordActual.Clear();
                    return;
                }

                else
                {
                    // Validar seguirdad de la contraseña, chequeando de que contenga, números, letras, caracteres especiales y una longitud de 8 caracteres como mínimo
                    if (PasswordSegura(this.txtPasswordNueva.Text))
                    {
                        // Validar que las dos Contraseñas  nuevas sean iguales, si retorna false es porque no coinciden.
                        bool _validacion = this.ValidarConfirmacionPassword(this.txtPasswordNueva.Text, this.txtPasswordConfirmar.Text);

                        if (_validacion == false)
                        {
                            MessageBox.Show("Las Contraseñas no coinciden");
                            this.txtPasswordConfirmar.Focus();
                            this.txtPasswordConfirmar.Clear();
                            return;
                        }
                        else
                        {
                            // Cargar datos al objeto  
                            this.oUsuarioSelected.Contrasena = this.txtPasswordNueva.Text;


                            // Modificar datos en la base de datos y verificar que se inserten con éxito
                            if (oUsuario.Modificar(oUsuarioSelected))
                            {
                                MessageBox.Show("Se ha Cambiado la Contraseña Con Éxito!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un Error al Editar los datos");
                            }
                        }
                    }
                    // si no se cumple con las condiciones del seguridad de la contraseña
                    else
                    {
                        MessageBox.Show("Las Contraseñas debe contener números, letras, caracteres y un mínimo de 8 dígitos");
                        this.txtPasswordConfirmar.Focus();
                        this.txtPasswordConfirmar.Clear();
                        return;
                    }
                    
                }
            }
        }


        // Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }


        // Validación de complejidad de contraseña 
        public Boolean PasswordSegura(String PasswordSinVerificar)
        {
            //letras de la A a la Z, mayusculas y minusculas
            Regex letras = new Regex(@"[a-zA-z]");
            //digitos del 0 al 9
            Regex numeros = new Regex(@"[0-9]");
            //cualquier caracter del conjunto
            Regex caracEsp = new Regex("[!\"#\\$%&'()*+,-./:;=?@\\[\\]^_`{|}~]");


            //si no contiene las letras, regresa false
            if (!letras.IsMatch(PasswordSinVerificar))
            {
                return false;
            }
            //si no contiene los numeros, regresa false
            if (!numeros.IsMatch(PasswordSinVerificar))
            {
                return false;
            }

            //si no contiene los caracteres especiales, regresa false
            if (!caracEsp.IsMatch(PasswordSinVerificar))
            {
                return false;
            }
            // si la longitud es menor a 8 caracteres, retorna falso
            if (PasswordSinVerificar.LongCount() < 8)
            {
                return false;
            }

            //si cumple con todo, regresa true
            return true;
        }


        // Validar campos no vacíos
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtPasswordActual.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña Actual");
                this.txtPasswordActual.Focus();
                this.lblPasswordActual.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPasswordNueva.Text))
            {
                MessageBox.Show("Debe ingresar la Nueva Contraseña");
                this.txtPasswordNueva.Focus();
                this.lblPasswordNueva.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPasswordConfirmar.Text))
            {
                MessageBox.Show("Debe confirmar la Contraseña");
                this.txtPasswordConfirmar.Focus();
                this.lblPasswordConfirmar.ForeColor = Color.Red;
                return false;
            }

            return true;

        }

        // Valida coincidencia de contraseñas, si las contraseñas coinciden retorna true y si no retorna false
        private bool ValidarConfirmacionPassword(string Password, string Confirmacion)
        {
            if (Password == Confirmacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
