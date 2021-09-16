
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
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(61, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario: ";
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
            this.btnCancelar.Location = new System.Drawing.Point(277, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(50, 419);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 40);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPasswordActual
            // 
            this.lblPasswordActual.AutoSize = true;
            this.lblPasswordActual.Location = new System.Drawing.Point(63, 128);
            this.lblPasswordActual.Name = "lblPasswordActual";
            this.lblPasswordActual.Size = new System.Drawing.Size(137, 17);
            this.lblPasswordActual.TabIndex = 4;
            this.lblPasswordActual.Text = "Contraseña Actual  *";
            // 
            // lblPasswordNueva
            // 
            this.lblPasswordNueva.AutoSize = true;
            this.lblPasswordNueva.Location = new System.Drawing.Point(61, 212);
            this.lblPasswordNueva.Name = "lblPasswordNueva";
            this.lblPasswordNueva.Size = new System.Drawing.Size(139, 17);
            this.lblPasswordNueva.TabIndex = 5;
            this.lblPasswordNueva.Text = "Contraseña Nueva  *";
            // 
            // lblPasswordConfirmacion
            // 
            this.lblPasswordConfirmacion.AutoSize = true;
            this.lblPasswordConfirmacion.Location = new System.Drawing.Point(63, 312);
            this.lblPasswordConfirmacion.Name = "lblPasswordConfirmacion";
            this.lblPasswordConfirmacion.Size = new System.Drawing.Size(204, 17);
            this.lblPasswordConfirmacion.TabIndex = 6;
            this.lblPasswordConfirmacion.Text = "Confirmar Contraseña Nueva  *";
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Location = new System.Drawing.Point(66, 148);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.Size = new System.Drawing.Size(199, 22);
            this.txtPasswordActual.TabIndex = 7;
            // 
            // txtPasswordNueva
            // 
            this.txtPasswordNueva.Location = new System.Drawing.Point(64, 232);
            this.txtPasswordNueva.Name = "txtPasswordNueva";
            this.txtPasswordNueva.Size = new System.Drawing.Size(201, 22);
            this.txtPasswordNueva.TabIndex = 8;
            // 
            // txtPasswordConfirmar
            // 
            this.txtPasswordConfirmar.Location = new System.Drawing.Point(64, 312);
            this.txtPasswordConfirmar.Name = "txtPasswordConfirmar";
            this.txtPasswordConfirmar.Size = new System.Drawing.Size(201, 22);
            this.txtPasswordConfirmar.TabIndex = 9;
            // 
            // lblPasswordConfirmar
            // 
            this.lblPasswordConfirmar.AutoSize = true;
            this.lblPasswordConfirmar.Location = new System.Drawing.Point(61, 292);
            this.lblPasswordConfirmar.Name = "lblPasswordConfirmar";
            this.lblPasswordConfirmar.Size = new System.Drawing.Size(204, 17);
            this.lblPasswordConfirmar.TabIndex = 10;
            this.lblPasswordConfirmar.Text = "Confirmar Contraseña Nueva  *";
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 497);
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
            this.Name = "frmPassword";
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
    }
}