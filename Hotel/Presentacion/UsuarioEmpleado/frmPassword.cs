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

namespace Hotel.Presentacion.UsuarioEmpleado
{
    public partial class frmPassword : Form
    {
        Usuario oUsuarioSelected = new Usuario();
        UsuarioDao oUsuario = new UsuarioDao();

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
            this.oUsuarioSelected.Nombre = (oUsuario.RecuperarPorId(this.oUsuarioSelected.Id).Rows[0]["nombre"]).ToString();           
            this.lblUsuario.Text = "Usuario : " + this.oUsuarioSelected.Nombre;
 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                // Validar que la contraseña actual del usuario es correcta
                int _validarActual = this.oUsuario.validarPassword(this.oUsuarioSelected.Id, this.txtPasswordActual.Text);

                if (_validarActual == 0)
                {
                    MessageBox.Show("La contraseña actual es incorrecta");
                    this.txtPasswordActual.Focus();
                    this.txtPasswordActual.Clear();
                    return;
                }

                else
                {
                    // Validar que las dos Contraseñas  nuevas sean iguales
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

        // Valida coincidencia de contraseñas
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
