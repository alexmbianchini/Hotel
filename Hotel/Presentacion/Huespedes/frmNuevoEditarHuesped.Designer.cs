
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
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(86, 136);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre  *";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(88, 85);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(72, 19);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido  *";
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaporte.Location = new System.Drawing.Point(21, 36);
            this.lblPasaporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(139, 19);
            this.lblPasaporte.TabIndex = 2;
            this.lblPasaporte.Text = "Numero Pasaporte  *";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(111, 226);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 19);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail  *";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(45, 182);
            this.lblPais.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(115, 19);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais Residencia  *";
            // 
            // cboPais
            // 
            this.cboPais.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(175, 174);
            this.cboPais.Margin = new System.Windows.Forms.Padding(2);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(142, 27);
            this.cboPais.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderSize = 1;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 123);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.Size = new System.Drawing.Size(142, 32);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BorderColor = System.Drawing.Color.DimGray;
            this.txtMail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMail.BorderSize = 1;
            this.txtMail.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(175, 213);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMail.PasswordChar = false;
            this.txtMail.Size = new System.Drawing.Size(142, 32);
            this.txtMail.TabIndex = 7;
            this.txtMail.UnderlinedStyle = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderColor = System.Drawing.Color.DimGray;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtApellido.BorderSize = 1;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(175, 72);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.Size = new System.Drawing.Size(142, 32);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.UnderlinedStyle = false;
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.BackColor = System.Drawing.Color.White;
            this.txtPasaporte.BorderColor = System.Drawing.Color.DimGray;
            this.txtPasaporte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPasaporte.BorderSize = 1;
            this.txtPasaporte.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasaporte.Location = new System.Drawing.Point(175, 23);
            this.txtPasaporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasaporte.Multiline = false;
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPasaporte.PasswordChar = false;
            this.txtPasaporte.Size = new System.Drawing.Size(142, 32);
            this.txtPasaporte.TabIndex = 10;
            this.txtPasaporte.UnderlinedStyle = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(38, 280);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(122, 39);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(195, 280);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevoEditarHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(367, 357);
            this.ControlBox = false;
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNuevoEditarHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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