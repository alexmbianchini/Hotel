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
    public partial class frmLogin : Form
    {
        Usuario miUsuarioSelected = new Usuario();
        private UsuarioService miUsuario = new UsuarioService();
        internal UsuarioService MiUsuario { get => miUsuario; set => miUsuario = value; }
        internal Usuario MiUsuarioSelected { get => miUsuarioSelected; set => miUsuarioSelected = value; }

        public frmLogin()
        {
            InitializeComponent();
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario!");
                this.txtUsuario.Focus();
                return;
            }

            if (this.txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña!");
                this.txtPassword.Focus();
                return;
            }

            this.MiUsuarioSelected.Nombre = this.txtUsuario.Text;
            this.MiUsuarioSelected.Contrasena = this.txtPassword.Text;

            this.MiUsuarioSelected.Id = this.miUsuario.ValidarUsuario(MiUsuarioSelected.Nombre, MiUsuarioSelected.Contrasena);

            //if (this.txtUsuario.Text == this.user && this.txtContrasena.Text == this.pass)
            if (MiUsuarioSelected.Id != 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtPassword.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
