
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioEditar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
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
            this.btnAceptar = new Hotel.Custom.RJButton();
            this.btnCancelar = new Hotel.Custom.RJButton();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(371, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(48, 246);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(196, 23);
            this.lblNumeroDocumento.TabIndex = 14;
            this.lblNumeroDocumento.Text = "Número Documento  *";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(48, 181);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(166, 23);
            this.lblTipoDocumento.TabIndex = 13;
            this.lblTipoDocumento.Text = "Tipo Documento  *";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(51, 138);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 29);
            this.txtApellido.TabIndex = 12;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(51, 272);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(173, 29);
            this.txtNumeroDocumento.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 29);
            this.txtNombre.TabIndex = 10;
            // 
            // cboPuesto
            // 
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(51, 334);
            this.cboPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(173, 29);
            this.cboPuesto.TabIndex = 9;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(51, 207);
            this.cboTipoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(173, 29);
            this.cboTipoDocumento.TabIndex = 8;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(48, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 23);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido  *";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(48, 308);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(83, 23);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "Puesto  *";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 23);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(413, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(371, 395);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(55, 89);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 29);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Location = new System.Drawing.Point(55, 162);
            this.txtPasswordActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.PasswordChar = '*';
            this.txtPasswordActual.Size = new System.Drawing.Size(173, 29);
            this.txtPasswordActual.TabIndex = 14;
            // 
            // txtPasswordNueva
            // 
            this.txtPasswordNueva.Location = new System.Drawing.Point(55, 238);
            this.txtPasswordNueva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordNueva.Name = "txtPasswordNueva";
            this.txtPasswordNueva.PasswordChar = '*';
            this.txtPasswordNueva.Size = new System.Drawing.Size(173, 29);
            this.txtPasswordNueva.TabIndex = 15;
            // 
            // txtPasswordConfirmar
            // 
            this.txtPasswordConfirmar.Location = new System.Drawing.Point(55, 309);
            this.txtPasswordConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordConfirmar.Name = "txtPasswordConfirmar";
            this.txtPasswordConfirmar.PasswordChar = '*';
            this.txtPasswordConfirmar.Size = new System.Drawing.Size(173, 29);
            this.txtPasswordConfirmar.TabIndex = 16;
            // 
            // lblPasswordConfirmar
            // 
            this.lblPasswordConfirmar.AutoSize = true;
            this.lblPasswordConfirmar.Location = new System.Drawing.Point(52, 283);
            this.lblPasswordConfirmar.Name = "lblPasswordConfirmar";
            this.lblPasswordConfirmar.Size = new System.Drawing.Size(260, 23);
            this.lblPasswordConfirmar.TabIndex = 4;
            this.lblPasswordConfirmar.Text = "Confirmar Nueva Contraseña  *";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(52, 63);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(90, 23);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario  *";
            // 
            // lblPasswordActual
            // 
            this.lblPasswordActual.AutoSize = true;
            this.lblPasswordActual.Location = new System.Drawing.Point(52, 137);
            this.lblPasswordActual.Name = "lblPasswordActual";
            this.lblPasswordActual.Size = new System.Drawing.Size(174, 23);
            this.lblPasswordActual.TabIndex = 2;
            this.lblPasswordActual.Text = "Contraseña Actual  *";
            // 
            // lblPasswordNueva
            // 
            this.lblPasswordNueva.AutoSize = true;
            this.lblPasswordNueva.Location = new System.Drawing.Point(52, 206);
            this.lblPasswordNueva.Name = "lblPasswordNueva";
            this.lblPasswordNueva.Size = new System.Drawing.Size(175, 23);
            this.lblPasswordNueva.TabIndex = 1;
            this.lblPasswordNueva.Text = "Nueva Contraseña  *";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(155, 434);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(200, 49);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(448, 434);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 49);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmUsuarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(188)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuarioEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private Custom.RJButton btnAceptar;
        private Custom.RJButton btnCancelar;
    }
}