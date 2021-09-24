
namespace Hotel.Presentacion.Huesped
{
    partial class frmNuevoEditarHuesped
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.txtNombre = new Hotel.Custom.RJTextBox();
            this.txtMail = new Hotel.Custom.RJTextBox();
            this.txtApellido = new Hotel.Custom.RJTextBox();
            this.txtPasaporte = new Hotel.Custom.RJTextBox();
            this.btnAceptar = new Hotel.Custom.RJButton();
            this.btnCancelar = new Hotel.Custom.RJButton();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(82, 196);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre  *";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(82, 133);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido  *";
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Location = new System.Drawing.Point(82, 73);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(140, 17);
            this.lblPasaporte.TabIndex = 2;
            this.lblPasaporte.Text = "Numero Pasaporte  *";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(82, 307);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 17);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail  *";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(82, 247);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(122, 17);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais Residencia  *";
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(232, 244);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(121, 24);
            this.cboPais.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Location = new System.Drawing.Point(232, 181);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(250, 32);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtMail
            // 
            this.txtMail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMail.BorderSize = 2;
            this.txtMail.Location = new System.Drawing.Point(232, 292);
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.Padding = new System.Windows.Forms.Padding(7);
            this.txtMail.PasswordChar = false;
            this.txtMail.Size = new System.Drawing.Size(250, 32);
            this.txtMail.TabIndex = 7;
            this.txtMail.UnderlinedStyle = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Location = new System.Drawing.Point(232, 118);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(250, 32);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.UnderlinedStyle = false;
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPasaporte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPasaporte.BorderSize = 2;
            this.txtPasaporte.Location = new System.Drawing.Point(232, 58);
            this.txtPasaporte.Multiline = false;
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Padding = new System.Windows.Forms.Padding(7);
            this.txtPasaporte.PasswordChar = false;
            this.txtPasaporte.Size = new System.Drawing.Size(250, 32);
            this.txtPasaporte.TabIndex = 10;
            this.txtPasaporte.UnderlinedStyle = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(107, 397);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 40);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(297, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevoEditarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 485);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPasaporte);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPasaporte);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmNuevoEditarHuesped";
            this.Load += new System.EventHandler(this.frmNuevoEditarHuesped_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboPais;
        private Custom.RJTextBox txtNombre;
        private Custom.RJTextBox txtMail;
        private Custom.RJTextBox txtApellido;
        private Custom.RJTextBox txtPasaporte;
        private Custom.RJButton btnAceptar;
        private Custom.RJButton btnCancelar;
    }
}