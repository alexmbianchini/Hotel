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

namespace Hotel.Presentacion
{
    public partial class frmUsuarioNuevo : Form
    {
        // Instanciar objetos necesarios
        Usuario oUsuario = new Usuario();
        Empleado oEmpleado = new Empleado();
        TipoDocumento oTipoDoc = new TipoDocumento();
        Puesto oPuesto = new Puesto();

        public frmUsuarioNuevo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarioNuevoEditar_Load(object sender, EventArgs e)
        {
            //Cargar Combos del Fomrulario
            this.CargarCombo(cboTipoDoc, oTipoDoc.RecuperarTodos(), "descripcion", "tipo_doc");
            this.CargarCombo(cboPuesto, oPuesto.RecuperarTodos(), "descripcion", "cod_puesto");


        }
        


        // Valida que los campos tengan datos
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

            if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de Documento");
                this.cboTipoDoc.Focus();
                this.lblTipoDoc.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtNumeroDoc.Text))
            {
                MessageBox.Show("Debe seleccionar un Número de Documento");
                this.txtNumeroDoc.Focus();
                this.lblNumeroDoc.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario");
                this.txtUsuario.Focus();
                this.lblUsuario.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar una Contraseña");
                this.txtPassword.Focus();
                this.lblPassword.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(this.txtConfirmarPassword.Text))
            {
                MessageBox.Show("Debe confirmar la Contraseña");
                this.txtConfirmarPassword.Focus();
                this.lblConfirmarPassword.ForeColor = Color.Red;
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


        // Función que nos permite cargar los comboBox
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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

        // Genera los ID de las tablas
        private int GenerarId(DataTable tabla)
        {
            int id = tabla.Rows.Count + 1;

            return id;
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // Validar que todos los campos tengan datos 
            ValidarCampos();


            // Validar que las dos Contraseñas sean iguales
            bool _validacion = this.ValidarConfirmacionPassword(this.txtPassword.Text, this.txtConfirmarPassword.Text);

            if (_validacion == false)
            {
                MessageBox.Show("Las Contraseñas no coinciden");
                this.txtConfirmarPassword.Focus();
                this.txtConfirmarPassword.Clear();
                return;
            }

            // Validar que no exista un empleado con es tipo y número de documento
            string _nroDoc = this.oEmpleado.validarEmpleadoExistente(this.txtNumeroDoc.Text, this.cboTipoDoc.SelectedValue.ToString());

            if (_nroDoc == string.Empty)
            {
                MessageBox.Show("Ya existe un Empleado con ese Tipo y Número de Documento");
                this.txtNumeroDoc.Clear();
                this.cboTipoDoc.SelectedIndex = -1;
                this.cboTipoDoc.Focus();
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



            // Generar los id's de Usuario y Empleado
            int _idUsuario = this.GenerarId(this.oUsuario.RecuperarIds());
            int _idEmpleado = this.GenerarId(this.oEmpleado.RecuperarIds());


            // Asignar valores a los atributos de los objetos
            this.oEmpleado.IdEmpleado = _idEmpleado;
            this.oEmpleado.Nombre = this.txtNombre.Text;
            this.oEmpleado.Apellido = this.txtApellido.Text;
            this.oEmpleado.TipoDoc = Convert.ToInt32(this.cboTipoDoc.SelectedValue);
            this.oEmpleado.NroDoc = Convert.ToInt32(this.txtNumeroDoc.Text);
            this.oEmpleado.FechaIngresoTrabajo = DateTime.Today;
            this.oEmpleado.Puesto = Convert.ToInt32(this.cboPuesto.SelectedValue);

            this.oUsuario.Id = _idUsuario;
            this.oUsuario.Nombre = _usuario;
            this.oUsuario.Contrasena = this.txtPassword.Text;
            this.oUsuario.IdEmpleado = _idEmpleado;


            // Insertar datos en la base de datos y verificar que se inserten con éxito
            if (oEmpleado.Crear(oEmpleado) && oUsuario.Crear(oUsuario))
            {
                MessageBox.Show("Datos Agregados Con Éxito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un Error al insertar los datos");
            }


        }



        //Boton para cancelar la accion
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la Acción?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
    
}
