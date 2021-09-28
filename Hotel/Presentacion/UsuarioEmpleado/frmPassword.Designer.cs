
namespace Hotel.Presentacion.UsuarioEmpleado
{
    partial class frmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassword));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new Hotel.Custom.RJButton();
            this.btnAceptar = new Hotel.Custom.RJButton();
            this.lblPasswordActual = new System.Windows.Forms.Label();
            this.lblPasswordNueva = new System.Windows.Forms.Label();
            this.lblPasswordConfirmacion = new System.Windows.Forms.Label();
            this.txtPasswordActual = new System.Windows.Forms.TextBox();
            this.txtPasswordNueva = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmar = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirmar = new System.Windows.Forms.Label();
            this.btnConfirmarSacar = new Hotel.Custom.RJButton();
            this.btnActualSacar = new Hotel.Custom.RJButton();
            this.btnActualPoner = new Hotel.Custom.RJButton();
            this.btnNuevaSacar = new Hotel.Custom.RJButton();
            this.btnNuevaPoner = new Hotel.Custom.RJButton();
            this.btnConfirmarPoner = new Hotel.Custom.RJButton();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(59, 37);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
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
            this.btnCancelar.Location = new System.Drawing.Point(184, 299);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(35, 299);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 42);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPasswordActual
            // 
            this.lblPasswordActual.AutoSize = true;
            this.lblPasswordActual.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordActual.Location = new System.Drawing.Point(59, 81);
            this.lblPasswordActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordActual.Name = "lblPasswordActual";
            this.lblPasswordActual.Size = new System.Drawing.Size(136, 19);
            this.lblPasswordActual.TabIndex = 4;
            this.lblPasswordActual.Text = "Contraseña Actual  *";
            // 
            // lblPasswordNueva
            // 
            this.lblPasswordNueva.AutoSize = true;
            this.lblPasswordNueva.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNueva.Location = new System.Drawing.Point(59, 149);
            this.lblPasswordNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordNueva.Name = "lblPasswordNueva";
            this.lblPasswordNueva.Size = new System.Drawing.Size(137, 19);
            this.lblPasswordNueva.TabIndex = 5;
            this.lblPasswordNueva.Text = "Contraseña Nueva  *";
            // 
            // lblPasswordConfirmacion
            // 
            this.lblPasswordConfirmacion.AutoSize = true;
            this.lblPasswordConfirmacion.Location = new System.Drawing.Point(60, 236);
            this.lblPasswordConfirmacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordConfirmacion.Name = "lblPasswordConfirmacion";
            this.lblPasswordConfirmacion.Size = new System.Drawing.Size(153, 13);
            this.lblPasswordConfirmacion.TabIndex = 6;
            this.lblPasswordConfirmacion.Text = "Confirmar Contraseña Nueva  *";
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordActual.Location = new System.Drawing.Point(63, 102);
            this.txtPasswordActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.PasswordChar = '*';
            this.txtPasswordActual.Size = new System.Drawing.Size(150, 25);
            this.txtPasswordActual.TabIndex = 7;
            // 
            // txtPasswordNueva
            // 
            this.txtPasswordNueva.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNueva.Location = new System.Drawing.Point(61, 170);
            this.txtPasswordNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordNueva.Name = "txtPasswordNueva";
            this.txtPasswordNueva.PasswordChar = '*';
            this.txtPasswordNueva.Size = new System.Drawing.Size(152, 25);
            this.txtPasswordNueva.TabIndex = 8;
            // 
            // txtPasswordConfirmar
            // 
            this.txtPasswordConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirmar.Location = new System.Drawing.Point(61, 236);
            this.txtPasswordConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordConfirmar.Name = "txtPasswordConfirmar";
            this.txtPasswordConfirmar.PasswordChar = '*';
            this.txtPasswordConfirmar.Size = new System.Drawing.Size(152, 25);
            this.txtPasswordConfirmar.TabIndex = 9;
            // 
            // lblPasswordConfirmar
            // 
            this.lblPasswordConfirmar.AutoSize = true;
            this.lblPasswordConfirmar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfirmar.Location = new System.Drawing.Point(59, 215);
            this.lblPasswordConfirmar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordConfirmar.Name = "lblPasswordConfirmar";
            this.lblPasswordConfirmar.Size = new System.Drawing.Size(203, 19);
            this.lblPasswordConfirmar.TabIndex = 10;
            this.lblPasswordConfirmar.Text = "Confirmar Contraseña Nueva  *";
            // 
            // btnConfirmarSacar
            // 
            this.btnConfirmarSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarSacar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConfirmarSacar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarSacar.BackgroundImage")));
            this.btnConfirmarSacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmarSacar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmarSacar.BorderRadius = 19;
            this.btnConfirmarSacar.BorderSize = 0;
            this.btnConfirmarSacar.FlatAppearance.BorderSize = 0;
            this.btnConfirmarSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarSacar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarSacar.Location = new System.Drawing.Point(218, 239);
            this.btnConfirmarSacar.Name = "btnConfirmarSacar";
            this.btnConfirmarSacar.Size = new System.Drawing.Size(31, 19);
            this.btnConfirmarSacar.TabIndex = 15;
            this.btnConfirmarSacar.TextColor = System.Drawing.Color.White;
            this.btnConfirmarSacar.UseVisualStyleBackColor = false;
            this.btnConfirmarSacar.Click += new System.EventHandler(this.btnConfirmarSacar_Click);
            // 
            // btnActualSacar
            // 
            this.btnActualSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualSacar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnActualSacar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualSacar.BackgroundImage")));
            this.btnActualSacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualSacar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualSacar.BorderRadius = 19;
            this.btnActualSacar.BorderSize = 0;
            this.btnActualSacar.FlatAppearance.BorderSize = 0;
            this.btnActualSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualSacar.ForeColor = System.Drawing.Color.White;
            this.btnActualSacar.Location = new System.Drawing.Point(218, 106);
            this.btnActualSacar.Name = "btnActualSacar";
            this.btnActualSacar.Size = new System.Drawing.Size(31, 19);
            this.btnActualSacar.TabIndex = 11;
            this.btnActualSacar.TextColor = System.Drawing.Color.White;
            this.btnActualSacar.UseVisualStyleBackColor = false;
            this.btnActualSacar.Click += new System.EventHandler(this.btnActualSacar_Click);
            // 
            // btnActualPoner
            // 
            this.btnActualPoner.BackColor = System.Drawing.Color.Transparent;
            this.btnActualPoner.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnActualPoner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualPoner.BackgroundImage")));
            this.btnActualPoner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualPoner.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualPoner.BorderRadius = 19;
            this.btnActualPoner.BorderSize = 0;
            this.btnActualPoner.FlatAppearance.BorderSize = 0;
            this.btnActualPoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualPoner.ForeColor = System.Drawing.Color.White;
            this.btnActualPoner.Location = new System.Drawing.Point(218, 106);
            this.btnActualPoner.Name = "btnActualPoner";
            this.btnActualPoner.Size = new System.Drawing.Size(31, 19);
            this.btnActualPoner.TabIndex = 13;
            this.btnActualPoner.TextColor = System.Drawing.Color.White;
            this.btnActualPoner.UseVisualStyleBackColor = false;
            this.btnActualPoner.Click += new System.EventHandler(this.btnActualPoner_Click);
            // 
            // btnNuevaSacar
            // 
            this.btnNuevaSacar.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaSacar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNuevaSacar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaSacar.BackgroundImage")));
            this.btnNuevaSacar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevaSacar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevaSacar.BorderRadius = 19;
            this.btnNuevaSacar.BorderSize = 0;
            this.btnNuevaSacar.FlatAppearance.BorderSize = 0;
            this.btnNuevaSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaSacar.ForeColor = System.Drawing.Color.White;
            this.btnNuevaSacar.Location = new System.Drawing.Point(218, 173);
            this.btnNuevaSacar.Name = "btnNuevaSacar";
            this.btnNuevaSacar.Size = new System.Drawing.Size(31, 19);
            this.btnNuevaSacar.TabIndex = 12;
            this.btnNuevaSacar.TextColor = System.Drawing.Color.White;
            this.btnNuevaSacar.UseVisualStyleBackColor = false;
            this.btnNuevaSacar.Click += new System.EventHandler(this.btnNuevaSacar_Click);
            // 
            // btnNuevaPoner
            // 
            this.btnNuevaPoner.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaPoner.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNuevaPoner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevaPoner.BackgroundImage")));
            this.btnNuevaPoner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevaPoner.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevaPoner.BorderRadius = 19;
            this.btnNuevaPoner.BorderSize = 0;
            this.btnNuevaPoner.FlatAppearance.BorderSize = 0;
            this.btnNuevaPoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaPoner.ForeColor = System.Drawing.Color.White;
            this.btnNuevaPoner.Location = new System.Drawing.Point(218, 174);
            this.btnNuevaPoner.Name = "btnNuevaPoner";
            this.btnNuevaPoner.Size = new System.Drawing.Size(31, 19);
            this.btnNuevaPoner.TabIndex = 14;
            this.btnNuevaPoner.TextColor = System.Drawing.Color.White;
            this.btnNuevaPoner.UseVisualStyleBackColor = false;
            this.btnNuevaPoner.Click += new System.EventHandler(this.btnNuevaPoner_Click);
            // 
            // btnConfirmarPoner
            // 
            this.btnConfirmarPoner.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarPoner.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnConfirmarPoner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmarPoner.BackgroundImage")));
            this.btnConfirmarPoner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmarPoner.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirmarPoner.BorderRadius = 19;
            this.btnConfirmarPoner.BorderSize = 0;
            this.btnConfirmarPoner.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPoner.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPoner.Location = new System.Drawing.Point(218, 240);
            this.btnConfirmarPoner.Name = "btnConfirmarPoner";
            this.btnConfirmarPoner.Size = new System.Drawing.Size(31, 19);
            this.btnConfirmarPoner.TabIndex = 16;
            this.btnConfirmarPoner.TextColor = System.Drawing.Color.White;
            this.btnConfirmarPoner.UseVisualStyleBackColor = false;
            this.btnConfirmarPoner.Click += new System.EventHandler(this.btnConfirmarPoner_Click);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(334, 376);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirmarSacar);
            this.Controls.Add(this.btnActualSacar);
            this.Controls.Add(this.lblPasswordConfirmar);
            this.Controls.Add(this.txtPasswordConfirmar);
            this.Controls.Add(this.txtPasswordNueva);
            this.Controls.Add(this.txtPasswordActual);
            this.Controls.Add(this.lblPasswordConfirmacion);
            this.Controls.Add(this.lblPasswordNueva);
            this.Controls.Add(this.lblPasswordActual);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnActualPoner);
            this.Controls.Add(this.btnNuevaSacar);
            this.Controls.Add(this.btnNuevaPoner);
            this.Controls.Add(this.btnConfirmarPoner);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambio de Contraseña";
            this.Load += new System.EventHandler(this.frmPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private Custom.RJButton btnCancelar;
        private Custom.RJButton btnAceptar;
        private System.Windows.Forms.Label lblPasswordActual;
        private System.Windows.Forms.Label lblPasswordNueva;
        private System.Windows.Forms.Label lblPasswordConfirmacion;
        private System.Windows.Forms.TextBox txtPasswordActual;
        private System.Windows.Forms.TextBox txtPasswordNueva;
        private System.Windows.Forms.TextBox txtPasswordConfirmar;
        private System.Windows.Forms.Label lblPasswordConfirmar;
        private Custom.RJButton btnActualSacar;
        private Custom.RJButton btnNuevaSacar;
        private Custom.RJButton btnActualPoner;
        private Custom.RJButton btnNuevaPoner;
        private Custom.RJButton btnConfirmarSacar;
        private Custom.RJButton btnConfirmarPoner;
    }
}