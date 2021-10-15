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
using System.Text.RegularExpressions;

namespace Hotel.Presentacion
{
    public partial class frmUsuarioNuevo : Form
    {
        // Instanciar objetos necesarios
        UsuarioService oUsuario = new UsuarioService();
        EmpleadoService oEmpleado = new EmpleadoService();
        TipoDocumentoService oTipoDoc = new TipoDocumentoService();
        PuestoService oPuesto = new PuestoService();
        Usuario oUsuarioSelected = new Usuario();
        Empleado oEmpleadoSelected = new Empleado();
        ComboBoxService oComboBox = new ComboBoxService();

        public frmUsuarioNuevo()
        {
            InitializeComponent();
        }


        private void frmUsuarioNuevoEditar_Load(object sender, EventArgs e)
        {
            //Cargar Combos del Fomrulario
            oComboBox.CargarCombo(cboTipoDoc, oTipoDoc.RecuperarTodos(), "descripcion", "tipo_doc");
            oComboBox.CargarCombo(cboPuesto, oPuesto.RecuperarTodos(), "descripcion", "cod_puesto");


        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // Validar que todos los campos tengan datos 
            if (this.ValidarCampos())
            {

                // Validar que no exista un empleado con es tipo y número de documento
                string _nroDoc = this.oEmpleado.ValidarEmpleadoExistente(this.txtNumeroDoc.Text, this.cboTipoDoc.SelectedValue.ToString());

                if (_nroDoc == string.Empty)
                {
                    MessageBox.Show("Ya existe un Empleado con ese Tipo y Número de Documento");
                    this.txtNumeroDoc.Clear();
                    this.cboTipoDoc.SelectedIndex = -1;
                    this.cboTipoDoc.Focus();
                    return;
                }

                else
                {
                    // Validar que si ya existe el usuario
                    string _usuario = this.oUsuario.ValidarUsuarioExistente(this.txtUsuario.Text);

                    if (_usuario == string.Empty)
                    {
                        MessageBox.Show("El nombre de usuario ya existe, por favor ingrese otro");
                        this.txtUsuario.Clear();
                        this.txtUsuario.Focus();
                        return;
                    }

                    else
                    {
                        // Validar que las dos Contraseñas sean iguales
                        bool _validacion = oUsuario.ValidarConfirmacionPassword(this.txtPassword.Text, this.txtConfirmarPassword.Text);

                        if (_validacion == false)
                        {
                            MessageBox.Show("Las Contraseñas no coinciden");
                            this.txtConfirmarPassword.Focus();
                            this.txtConfirmarPassword.Clear();
                            return;
                        }
                        else
                        {
                            // Validar seguirdad de la contraseña, chequeando de que contenga, números, letras, caracteres especiales y una longitud de 8 caracteres como mínimo
                            if (oUsuario.PasswordSegura(this.txtPassword.Text))
                            {

                                // Generar los id's de Usuario y Empleado
                                int _idUsuario = this.GenerarId(this.oUsuario.RecuperarIds());
                                int _idEmpleado = this.GenerarId(this.oEmpleado.RecuperarIds());


                                // Asignar valores a los atributos de los objetos
                                this.oEmpleadoSelected.IdEmpleado = _idEmpleado;
                                this.oEmpleadoSelected.Nombre = this.txtNombre.Text;
                                this.oEmpleadoSelected.Apellido = this.txtApellido.Text;
                                this.oEmpleadoSelected.TipoDoc = Convert.ToInt32(this.cboTipoDoc.SelectedValue);
                                this.oEmpleadoSelected.NroDoc = Convert.ToInt32(this.txtNumeroDoc.Text);
                                this.oEmpleadoSelected.FechaIngresoTrabajo = DateTime.Today;
                                this.oEmpleadoSelected.Puesto = Convert.ToInt32(this.cboPuesto.SelectedValue);

                                this.oUsuarioSelected.Id = _idUsuario;
                                this.oUsuarioSelected.Nombre = _usuario;
                                this.oUsuarioSelected.Password = this.txtPassword.Text;
                                this.oUsuarioSelected.IdEmpleado = _idEmpleado;


                                // Insertar datos en la base de datos y verificar que se inserten con éxito
                                if (oEmpleado.Crear(oEmpleadoSelected) && oUsuario.Crear(oUsuarioSelected))
                                {
                                    MessageBox.Show("Nuevo Usuario Agregado");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un Error al insertar los datos");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las Contraseñas debe contener números, letras, caracteres y un mínimo de 8 dígitos");
                                this.txtConfirmarPassword.Focus();
                                this.txtConfirmarPassword.Clear();
                                return;
                            }
                        }
                    }
                }
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



        // Valida que los campos tengan datos
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

            if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de Documento");
                this.cboTipoDoc.Focus();
                this.lblTipoDoc.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNumeroDoc.Text))
            {
                MessageBox.Show("Debe seleccionar un Número de Documento");
                this.txtNumeroDoc.Focus();
                this.lblNumeroDoc.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario");
                this.txtUsuario.Focus();
                this.lblUsuario.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar una Contraseña");
                this.txtPassword.Focus();
                this.lblPassword.ForeColor = Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(this.txtConfirmarPassword.Text))
            {
                MessageBox.Show("Debe confirmar la Contraseña");
                this.txtConfirmarPassword.Focus();
                this.lblConfirmarPassword.ForeColor = Color.Red;
                return false;
            }

            if (cboPuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Puesto");
                this.cboPuesto.Focus();
                this.lblPuesto.ForeColor = Color.Red;
                return false;
            }

            return true;
        }


        // Genera los ID de las tablas
        private int GenerarId(DataTable tabla)
        {
            int id = tabla.Rows.Count + 1;

            return id;
        }



        private void btnPasswordSacar_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btnPasswordPoner.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnConfirmarSacar_Click(object sender, EventArgs e)
        {
            if (txtConfirmarPassword.PasswordChar == '*')
            {
                btnConfirmarPoner.BringToFront();
                txtConfirmarPassword.PasswordChar = '\0';
            }
        }

        private void btnConfirmarPoner_Click(object sender, EventArgs e)
        {
            if (txtConfirmarPassword.PasswordChar == '\0')
            {
                btnConfirmarSacar.BringToFront();
                txtConfirmarPassword.PasswordChar = '*';
            }
        }

        private void btnPasswordPoner_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnPasswordSacar.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
    
}
