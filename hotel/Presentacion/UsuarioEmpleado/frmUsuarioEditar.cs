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
   
    public partial class frmUsuarioEditar : Form
    {
        // Instanciar objetos necesarios
        TipoDocumentoDao oTipoDoc = new TipoDocumentoDao();
        PuestoDao oPuesto = new PuestoDao();
        UsuarioDao oUsuario = new UsuarioDao();
        EmpleadoDao oEmpleado = new EmpleadoDao();
        Usuario oUsuarioSelected = new Usuario();
        Empleado oEmpleadoSelected = new Empleado();


        // Variables a utilizar
        int IdUsuario;
        int IdEmpleado;
        string nroDocActual;
        string nombreUsuario;


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


        private void frmUsuarioEditar_Load(object sender, EventArgs e)
        {

            // Cargar los campos con los atributos de los objetos seleccionados
            this.CargarCampos();

            // Guardado de valor paraa futuras comparaciones
            nroDocActual = this.txtNumeroDocumento.Text;
            nombreUsuario = this.txtUsuario.Text;
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // Valida que los campos esté cargados 
            this.ValidarCampos();


            // Validar que no exista un empleado con es tipo y número de documento
            string _nroDoc = this.oEmpleado.validarEmpleadoExistente(this.txtNumeroDocumento.Text, this.cboTipoDocumento.SelectedValue.ToString());

            

            if (_nroDoc == string.Empty && this.txtNumeroDocumento.Text != nroDocActual) 
            {
                MessageBox.Show("Ya existe un Empleado con ese Tipo y Número de Documento");
                this.txtNumeroDocumento.Clear();
                this.cboTipoDocumento.SelectedIndex = -1;
                this.cboTipoDocumento.Focus();
                return;
            }


            // Validar si ya existe el usuario
            string _usuario = this.oUsuario.ValidarUsuarioExistente(this.txtUsuario.Text);

            if (_usuario == string.Empty && nombreUsuario != this.txtUsuario.Text)
            {
                MessageBox.Show("El nombre de usuario ya existe, por favor ingrese otro");
                this.txtUsuario.Clear();
                this.txtUsuario.Focus();
                return;
            }


            // Asignar Valores a los atributos de los objetos
            this.oEmpleadoSelected.IdEmpleado = IdEmpleado;
            this.oEmpleadoSelected.Nombre = this.txtNombre.Text;
            this.oEmpleadoSelected.Apellido = this.txtApellido.Text;
            this.oEmpleadoSelected.TipoDoc = Convert.ToInt32(this.cboTipoDocumento.SelectedValue);
            this.oEmpleadoSelected.NroDoc = Convert.ToInt32(this.txtNumeroDocumento.Text);
            this.oEmpleadoSelected.Puesto = Convert.ToInt32(this.cboPuesto.SelectedValue);

            this.oUsuarioSelected.Id = IdUsuario;
            this.oUsuarioSelected.Nombre = this.txtUsuario.Text;

 


            // Modificar datos en la base de datos y verificar que se inserten con éxito
            if (oEmpleado.Modificar(oEmpleadoSelected) && oUsuario.Modificar(oUsuarioSelected))
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

            

            if (cboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Puesto");
                this.cboPuesto.Focus();
                this.lblPuesto.ForeColor = Color.Red;
                return;
            }
        }







    }

}
