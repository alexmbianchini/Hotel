
namespace Hotel.Presentacion
{
    partial class frmHabitacion
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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblPrecioMin = new System.Windows.Forms.Label();
            this.lblPrecioMax = new System.Windows.Forms.Label();
            this.txtPrecioMax = new Hotel.Custom.RJTextBox();
            this.txtPrecioMin = new Hotel.Custom.RJTextBox();
            this.txtPiso = new Hotel.Custom.RJTextBox();
            this.txtNumero = new Hotel.Custom.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumero,
            this.clmEstado,
            this.clmPiso,
            this.clmTipoHabitacion,
            this.clmPrecio,
            this.clmDescripcion});
            this.dgvHabitaciones.Location = new System.Drawing.Point(2, 266);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersWidth = 51;
            this.dgvHabitaciones.RowTemplate.Height = 24;
            this.dgvHabitaciones.Size = new System.Drawing.Size(496, 201);
            this.dgvHabitaciones.TabIndex = 0;
            // 
            // clmNumero
            // 
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.MinimumWidth = 6;
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            this.clmNumero.Width = 80;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.MinimumWidth = 6;
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            this.clmEstado.Width = 125;
            // 
            // clmPiso
            // 
            this.clmPiso.HeaderText = "Piso";
            this.clmPiso.MinimumWidth = 6;
            this.clmPiso.Name = "clmPiso";
            this.clmPiso.ReadOnly = true;
            this.clmPiso.Width = 50;
            // 
            // clmTipoHabitacion
            // 
            this.clmTipoHabitacion.HeaderText = "Tipo";
            this.clmTipoHabitacion.MinimumWidth = 6;
            this.clmTipoHabitacion.Name = "clmTipoHabitacion";
            this.clmTipoHabitacion.ReadOnly = true;
            this.clmTipoHabitacion.Width = 125;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.MinimumWidth = 6;
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            this.clmPrecio.Width = 80;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.MinimumWidth = 6;
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 300;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(391, 196);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(536, 411);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(536, 368);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 19);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(536, 324);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 19);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(536, 277);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 19);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(496, 196);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(67, 29);
            this.btConsultar.TabIndex = 6;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(68, 38);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(68, 130);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(68, 88);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 9;
            this.lblPiso.Text = "Piso";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(128, 122);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(92, 21);
            this.cboTipo.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(68, 176);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(128, 168);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(92, 21);
            this.cboEstado.TabIndex = 15;
            // 
            // lblPrecioMin
            // 
            this.lblPrecioMin.AutoSize = true;
            this.lblPrecioMin.Location = new System.Drawing.Point(319, 38);
            this.lblPrecioMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMin.Name = "lblPrecioMin";
            this.lblPrecioMin.Size = new System.Drawing.Size(75, 13);
            this.lblPrecioMin.TabIndex = 18;
            this.lblPrecioMin.Text = "Precio Mínimo";
            // 
            // lblPrecioMax
            // 
            this.lblPrecioMax.AutoSize = true;
            this.lblPrecioMax.Location = new System.Drawing.Point(319, 88);
            this.lblPrecioMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMax.Name = "lblPrecioMax";
            this.lblPrecioMax.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioMax.TabIndex = 19;
            this.lblPrecioMax.Text = "Precio Máximo";
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.BorderColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecioMax.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMax.BorderSize = 2;
            this.txtPrecioMax.Location = new System.Drawing.Point(406, 73);
            this.txtPrecioMax.Multiline = false;
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrecioMax.PasswordChar = false;
            this.txtPrecioMax.Size = new System.Drawing.Size(92, 28);
            this.txtPrecioMax.TabIndex = 21;
            this.txtPrecioMax.UnderlinedStyle = false;
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.BorderColor = System.Drawing.SystemColors.WindowText;
            this.txtPrecioMin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMin.BorderSize = 2;
            this.txtPrecioMin.Location = new System.Drawing.Point(406, 23);
            this.txtPrecioMin.Multiline = false;
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrecioMin.PasswordChar = false;
            this.txtPrecioMin.Size = new System.Drawing.Size(92, 28);
            this.txtPrecioMin.TabIndex = 20;
            this.txtPrecioMin.UnderlinedStyle = false;
            // 
            // txtPiso
            // 
            this.txtPiso.BorderColor = System.Drawing.SystemColors.WindowText;
            this.txtPiso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPiso.BorderSize = 2;
            this.txtPiso.Location = new System.Drawing.Point(128, 73);
            this.txtPiso.Multiline = false;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Padding = new System.Windows.Forms.Padding(7);
            this.txtPiso.PasswordChar = false;
            this.txtPiso.Size = new System.Drawing.Size(92, 28);
            this.txtPiso.TabIndex = 17;
            this.txtPiso.UnderlinedStyle = false;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderColor = System.Drawing.SystemColors.WindowText;
            this.txtNumero.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumero.BorderSize = 2;
            this.txtNumero.Location = new System.Drawing.Point(128, 23);
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.Size = new System.Drawing.Size(92, 28);
            this.txtNumero.TabIndex = 16;
            this.txtNumero.UnderlinedStyle = false;
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 465);
            this.Controls.Add(this.txtPrecioMax);
            this.Controls.Add(this.txtPrecioMin);
            this.Controls.Add(this.lblPrecioMax);
            this.Controls.Add(this.lblPrecioMin);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvHabitaciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHabitacion";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private Custom.RJTextBox txtNumero;
        private Custom.RJTextBox txtPiso;
        private System.Windows.Forms.Label lblPrecioMin;
        private System.Windows.Forms.Label lblPrecioMax;
        private Custom.RJTextBox txtPrecioMin;
        private Custom.RJTextBox txtPrecioMax;
    }
}