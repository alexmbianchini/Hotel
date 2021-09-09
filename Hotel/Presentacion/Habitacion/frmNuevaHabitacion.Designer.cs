
namespace Hotel.Presentacion
{
    partial class frmNuevaHabitacion
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
            this.lblPisoHabitacion = new System.Windows.Forms.Label();
            this.lblTipoHabitacion = new System.Windows.Forms.Label();
            this.lblDescripcionHabitacion = new System.Windows.Forms.Label();
            this.cboPisoHabitacion = new System.Windows.Forms.ComboBox();
            this.cboTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtDescripcionHabitacion = new System.Windows.Forms.TextBox();
            this.btnAceptarHabitacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioHabitacion = new System.Windows.Forms.Label();
            this.txtPrecioHabitacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPisoHabitacion
            // 
            this.lblPisoHabitacion.AutoSize = true;
            this.lblPisoHabitacion.Location = new System.Drawing.Point(74, 73);
            this.lblPisoHabitacion.Name = "lblPisoHabitacion";
            this.lblPisoHabitacion.Size = new System.Drawing.Size(48, 17);
            this.lblPisoHabitacion.TabIndex = 0;
            this.lblPisoHabitacion.Text = "Piso  *";
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Location = new System.Drawing.Point(73, 131);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(49, 17);
            this.lblTipoHabitacion.TabIndex = 1;
            this.lblTipoHabitacion.Text = "Tipo  *";
            // 
            // lblDescripcionHabitacion
            // 
            this.lblDescripcionHabitacion.AutoSize = true;
            this.lblDescripcionHabitacion.Location = new System.Drawing.Point(74, 250);
            this.lblDescripcionHabitacion.Name = "lblDescripcionHabitacion";
            this.lblDescripcionHabitacion.Size = new System.Drawing.Size(82, 17);
            this.lblDescripcionHabitacion.TabIndex = 2;
            this.lblDescripcionHabitacion.Text = "Descripción";
            // 
            // cboPisoHabitacion
            // 
            this.cboPisoHabitacion.FormattingEnabled = true;
            this.cboPisoHabitacion.Location = new System.Drawing.Point(167, 73);
            this.cboPisoHabitacion.Name = "cboPisoHabitacion";
            this.cboPisoHabitacion.Size = new System.Drawing.Size(121, 24);
            this.cboPisoHabitacion.TabIndex = 3;
            // 
            // cboTipoHabitacion
            // 
            this.cboTipoHabitacion.FormattingEnabled = true;
            this.cboTipoHabitacion.Location = new System.Drawing.Point(167, 128);
            this.cboTipoHabitacion.Name = "cboTipoHabitacion";
            this.cboTipoHabitacion.Size = new System.Drawing.Size(121, 24);
            this.cboTipoHabitacion.TabIndex = 4;
            // 
            // txtDescripcionHabitacion
            // 
            this.txtDescripcionHabitacion.Location = new System.Drawing.Point(76, 270);
            this.txtDescripcionHabitacion.Multiline = true;
            this.txtDescripcionHabitacion.Name = "txtDescripcionHabitacion";
            this.txtDescripcionHabitacion.Size = new System.Drawing.Size(260, 74);
            this.txtDescripcionHabitacion.TabIndex = 5;
            // 
            // btnAceptarHabitacion
            // 
            this.btnAceptarHabitacion.Location = new System.Drawing.Point(89, 367);
            this.btnAceptarHabitacion.Name = "btnAceptarHabitacion";
            this.btnAceptarHabitacion.Size = new System.Drawing.Size(90, 45);
            this.btnAceptarHabitacion.TabIndex = 6;
            this.btnAceptarHabitacion.Text = "Aceptar";
            this.btnAceptarHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioHabitacion
            // 
            this.lblPrecioHabitacion.AutoSize = true;
            this.lblPrecioHabitacion.Location = new System.Drawing.Point(74, 185);
            this.lblPrecioHabitacion.Name = "lblPrecioHabitacion";
            this.lblPrecioHabitacion.Size = new System.Drawing.Size(61, 17);
            this.lblPrecioHabitacion.TabIndex = 8;
            this.lblPrecioHabitacion.Text = "Precio  *";
            // 
            // txtPrecioHabitacion
            // 
            this.txtPrecioHabitacion.Location = new System.Drawing.Point(167, 182);
            this.txtPrecioHabitacion.Name = "txtPrecioHabitacion";
            this.txtPrecioHabitacion.Size = new System.Drawing.Size(121, 22);
            this.txtPrecioHabitacion.TabIndex = 9;
            // 
            // frmNuevaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 462);
            this.Controls.Add(this.txtPrecioHabitacion);
            this.Controls.Add(this.lblPrecioHabitacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarHabitacion);
            this.Controls.Add(this.txtDescripcionHabitacion);
            this.Controls.Add(this.cboTipoHabitacion);
            this.Controls.Add(this.cboPisoHabitacion);
            this.Controls.Add(this.lblDescripcionHabitacion);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblPisoHabitacion);
            this.Name = "frmNuevaHabitacion";
            this.Text = "Gestión Habitación";
            this.Load += new System.EventHandler(this.frmNuevaHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPisoHabitacion;
        private System.Windows.Forms.Label lblTipoHabitacion;
        private System.Windows.Forms.Label lblDescripcionHabitacion;
        private System.Windows.Forms.ComboBox cboPisoHabitacion;
        private System.Windows.Forms.ComboBox cboTipoHabitacion;
        private System.Windows.Forms.TextBox txtDescripcionHabitacion;
        private System.Windows.Forms.Button btnAceptarHabitacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioHabitacion;
        private System.Windows.Forms.TextBox txtPrecioHabitacion;
    }
}