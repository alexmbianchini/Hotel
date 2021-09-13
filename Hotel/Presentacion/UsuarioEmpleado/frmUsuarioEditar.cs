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
   
    public partial class frmUsuarioEditar : Form
    {
        // Instanciar objetos necesarios
        TipoDocumento oTipoDoc = new TipoDocumento();
        Puesto oPuesto = new Puesto();
        Usuario oUsuario = new Usuario();
        Empleado oEmpleado = new Empleado();


        // Variables a utilizar
        int IdUsuario;
        int IdEmpleado;


        // Nos permite pasarle parámetros a este formulario desde otro
        public frmUsuarioEditar(int IdUsuario, int IdEmpleado)
        {
            InitializeComponent();
            this.IdUsuario = IdUsuario;
            this.IdEmpleado = IdEmpleado;

        }
        public frmUsuarioEditar()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmUsuarioEditar_Load(object sender, EventArgs e)
        {

            // Cargar los campos con los atributos de los objetos seleccionados
            CargarCampos();
            
        }


        // Método para cargar los campos
        private void CargarCampos()
        {
            DataTable tablaUsuario = new DataTable();
            DataTable tablaEmpleado = new DataTable();
            tablaEmpleado = oEmpleado.RecuperarPorId(IdEmpleado);
            tablaUsuario = oUsuario.RecuperarPorId(IdUsuario);

            txtNombre.Text = tablaEmpleado.Rows[0]["nombre"].ToString();
            txtApellido.Text = tablaEmpleado.Rows[0]["apellido"].ToString();
            this.CargarCombo(cboTipoDocumento, oTipoDoc.RecuperarTodos(), "descripcion", "tipo_doc", (int)tablaEmpleado.Rows[0]["tipo_doc"]);
            this.CargarCombo(cboPuesto, oPuesto.RecuperarTodos(), "descripcion", "cod_puesto", (int)tablaEmpleado.Rows[0]["puesto"]);
            txtNumeroDocumento.Text = tablaEmpleado.Rows[0]["nro_doc"].ToString();

            txtUsuario.Text = tablaUsuario.Rows[0]["nombre"].ToString();
        }


        // Función que nos permite cargar los comboBox
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor, int campoIndice)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = campoIndice - 1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        // Valida que los campos tengan datos ingresados/seleccionados

        private void ValidarCampos()
        {
            if (string.IsNullOrEmpty(this.txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre");
                this.txtNombre.Focus();
                this.lblNombre.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un Apellido");
                this.txtApellido.Focus();
                this.lblApellido.ForeColor = Color.Red;
                return;
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de Documento");
                this.cboTipoDocumento.Focus();
                this.lblTipoDocumento.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtNumeroDocumento.Text))
            {
                MessageBox.Show("Debe seleccionar un Número de Documento");
                this.txtNumeroDocumento.Focus();
                this.lblNumeroDocumento.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario");
                this.txtUsuario.Focus();
                this.lblUsuario.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtPasswordActual.Text))
            {
                MessageBox.Show("Debe ingresar una Contraseña");
                this.txtPasswordActual.Focus();
                this.lblPasswordActual.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtPasswordNueva.Text))
            {
                MessageBox.Show("Debe confirmar la Contraseña");
                this.txtPasswordNueva.Focus();
                this.lblPasswordNueva.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtPasswordConfirmar.Text))
            {
                MessageBox.Show("Debe confirmar la Contraseña");
                this.txtPasswordConfirmar.Focus();
                this.lblPasswordConfirmar.ForeColor = Color.Red;
                return;
            }

            if (cboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Puesto");
                this.cboPuesto.Focus();
                this.lblPuesto.ForeColor = Color.Red;
                return;
            }
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Valida que los campos esté cargados 
            ValidarCampos();


            // Validar que la contraseña actual del usuario es correcta
            int _validarActual = this.oUsuario.validarPassword(this.IdUsuario, this.txtPasswordActual.Text);

            if (_validarActual == 0)
            {
                MessageBox.Show("La contraseña actual es incorrecta");
                this.txtPasswordActual.Focus();
                this.txtPasswordActual.Clear();
                return;
            }


            // Validar que las dos Contraseñas  nuevas sean iguales
            bool _validacion = this.ValidarConfirmacionPassword(this.txtPasswordNueva.Text, this.txtPasswordConfirmar.Text);

            if (_validacion == false)
            {
                MessageBox.Show("Las Contraseñas no coinciden");
                this.txtPasswordConfirmar.Focus();
                this.txtPasswordConfirmar.Clear();
                return;
            }


            // Validar que no exista un empleado con es tipo y número de documento
            string _nroDoc = this.oEmpleado.validarEmpleadoExistente(this.txtNumeroDocumento.Text, this.cboTipoDocumento.SelectedValue.ToString());

            if (_nroDoc == string.Empty)
            {
                MessageBox.Show("Ya existe un Empleado con ese Tipo y Número de Documento");
                this.txtNumeroDocumento.Clear();
                this.cboTipoDocumento.SelectedIndex = -1;
                this.cboTipoDocumento.Focus();
                return;
            }


            // Validar que si ya existe el usuario
            string _usuario = this.oUsuario.ValidarUsuarioExistente(this.txtUsuario.Text);

            if (_usuario == string.Empty)
            {
                MessageBox.Show("El nombre de usuario ya existe, por favor ingrese otro");
                this.txtUsuario.Clear();
                this.txtUsuario.Focus();
                return;
            }


            // Asignar Valores a los atributos de los objetos
            this.oEmpleado.IdEmpleado = IdEmpleado;
            this.oEmpleado.Nombre = this.txtNombre.Text;
            this.oEmpleado.Apellido = this.txtApellido.Text;
            this.oEmpleado.TipoDoc = Convert.ToInt32(this.cboTipoDocumento.SelectedValue);
            this.oEmpleado.NroDoc = Convert.ToInt32(this.txtNumeroDocumento.Text);
            this.oEmpleado.Puesto = Convert.ToInt32(this.cboPuesto.SelectedValue);

            this.oUsuario.Id = IdUsuario;
            this.oUsuario.Nombre = _usuario;
            this.oUsuario.Contrasena = this.txtPasswordNueva.Text;
            this.oUsuario.IdEmpleado = IdEmpleado;


            // Modificar datos en la base de datos y verificar que se inserten con éxito
            if (oEmpleado.Modificar(oEmpleado) && oUsuario.Modificar(oUsuario))
            {
                MessageBox.Show("Datos Agregados Con Éxito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un Error al insertar los datos");
            }
        }


        // Botón para cancelar la acción
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

}
