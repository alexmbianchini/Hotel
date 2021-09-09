
namespace Hotel.Presentacion.UsuarioEmpleado
{
    partial class frmUsuarioEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPasswordActual = new System.Windows.Forms.TextBox();
            this.txtPasswordNueva = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmar = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirmar = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPasswordActual = new System.Windows.Forms.Label();
            this.lblPasswordNueva = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumeroDocumento);
            this.groupBox1.Controls.Add(this.lblTipoDocumento);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cboPuesto);
            this.groupBox1.Controls.Add(this.cboTipoDocumento);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblPuesto);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(32, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 22);
            this.txtApellido.TabIndex = 12;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(32, 278);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(173, 22);
            this.txtNumeroDocumento.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // cboPuesto
            // 
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(32, 340);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(121, 24);
            this.cboPuesto.TabIndex = 9;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(32, 213);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(121, 24);
            this.cboTipoDocumento.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido  *";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(29, 320);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(65, 17);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto  *";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre  *";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.txtPasswordActual);
            this.groupBox2.Controls.Add(this.txtPasswordNueva);
            this.groupBox2.Controls.Add(this.txtPasswordConfirmar);
            this.groupBox2.Controls.Add(this.lblPasswordConfirmar);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Controls.Add(this.lblPasswordActual);
            this.groupBox2.Controls.Add(this.lblPasswordNueva);
            this.groupBox2.Location = new System.Drawing.Point(414, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(44, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 22);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Location = new System.Drawing.Point(44, 144);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.Size = new System.Drawing.Size(173, 22);
            this.txtPasswordActual.TabIndex = 14;
            // 
            // txtPasswordNueva
            // 
            this.txtPasswordNueva.Location = new System.Drawing.Point(44, 215);
            this.txtPasswordNueva.Name = "txtPasswordNueva";
            this.txtPasswordNueva.Size = new System.Drawing.Size(173, 22);
            this.txtPasswordNueva.TabIndex = 15;
            // 
            // txtPasswordConfirmar
            // 
            this.txtPasswordConfirmar.Location = new System.Drawing.Point(44, 278);
            this.txtPasswordConfirmar.Name = "txtPasswordConfirmar";
            this.txtPasswordConfirmar.Size = new System.Drawing.Size(173, 22);
            this.txtPasswordConfirmar.TabIndex = 16;
            // 
            // lblPasswordConfirmar
            // 
            this.lblPasswordConfirmar.AutoSize = true;
            this.lblPasswordConfirmar.Location = new System.Drawing.Point(41, 258);
            this.lblPasswordConfirmar.Name = "lblPasswordConfirmar";
            this.lblPasswordConfirmar.Size = new System.Drawing.Size(204, 17);
            this.lblPasswordConfirmar.TabIndex = 4;
            this.lblPasswordConfirmar.Text = "Confirmar Nueva Contraseña  *";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(41, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 17);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario  *";
            // 
            // lblPasswordActual
            // 
            this.lblPasswordActual.AutoSize = true;
            this.lblPasswordActual.Location = new System.Drawing.Point(41, 124);
            this.lblPasswordActual.Name = "lblPasswordActual";
            this.lblPasswordActual.Size = new System.Drawing.Size(137, 17);
            this.lblPasswordActual.TabIndex = 2;
            this.lblPasswordActual.Text = "Contraseña Actual  *";
            // 
            // lblPasswordNueva
            // 
            this.lblPasswordNueva.AutoSize = true;
            this.lblPasswordNueva.Location = new System.Drawing.Point(41, 193);
            this.lblPasswordNueva.Name = "lblPasswordNueva";
            this.lblPasswordNueva.Size = new System.Drawing.Size(139, 17);
            this.lblPasswordNueva.TabIndex = 1;
            this.lblPasswordNueva.Text = "Nueva Contraseña  *";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(161, 435);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 36);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(563, 435);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(29, 193);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(125, 17);
            this.lblTipoDocumento.TabIndex = 13;
            this.lblTipoDocumento.Text = "Tipo Documento  *";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(29, 258);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(147, 17);
            this.lblNumeroDocumento.TabIndex = 14;
            this.lblNumeroDocumento.Text = "Número Documento  *";
            // 
            // frmUsuarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsuarioEditar";
            this.Text = "Editar Empleado";
            this.Load += new System.EventHandler(this.frmUsuarioEditar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblPasswordNueva;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPasswordActual;
        private System.Windows.Forms.Label lblPasswordConfirmar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPasswordActual;
        private System.Windows.Forms.TextBox txtPasswordNueva;
        private System.Windows.Forms.TextBox txtPasswordConfirmar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
    }
}