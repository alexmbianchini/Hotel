
namespace Hotel.Presentacion
{
    partial class frmConsultaReservas
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
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.clmNroReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumeroCochera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalleReserva = new System.Windows.Forms.DataGridView();
            this.clmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumeroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReserva = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new Hotel.Custom.RJButton();
            this.btnCancelarReserva = new Hotel.Custom.RJButton();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.btnLimpiar = new Hotel.Custom.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(154, 57);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(130, 22);
            this.txtPasaporte.TabIndex = 0;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(527, 55);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIngreso.TabIndex = 1;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(527, 139);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaSalida.TabIndex = 2;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(154, 132);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(130, 24);
            this.cboEstado.TabIndex = 3;
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Location = new System.Drawing.Point(58, 60);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(73, 17);
            this.lblPasaporte.TabIndex = 4;
            this.lblPasaporte.Text = "Pasaporte";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(79, 139);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(401, 144);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(90, 17);
            this.lblFechaSalida.TabIndex = 6;
            this.lblFechaSalida.Text = "Fecha Salida";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(401, 60);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(98, 17);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // dgvReserva
            // 
            this.dgvReserva.AllowUserToAddRows = false;
            this.dgvReserva.AllowUserToDeleteRows = false;
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNroReserva,
            this.clmPasaporte,
            this.clmNombre,
            this.clmApellido,
            this.clmFechaIngreso,
            this.clmFechaSalida,
            this.clmNumeroCochera,
            this.clmCantidadPersonas});
            this.dgvReserva.Location = new System.Drawing.Point(33, 255);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.ReadOnly = true;
            this.dgvReserva.RowHeadersWidth = 51;
            this.dgvReserva.RowTemplate.Height = 24;
            this.dgvReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReserva.Size = new System.Drawing.Size(1089, 217);
            this.dgvReserva.TabIndex = 12;
            this.dgvReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserva_CellClick);
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserva_CellContentClick);
            // 
            // clmNroReserva
            // 
            this.clmNroReserva.HeaderText = "N°";
            this.clmNroReserva.MinimumWidth = 6;
            this.clmNroReserva.Name = "clmNroReserva";
            this.clmNroReserva.ReadOnly = true;
            this.clmNroReserva.Width = 125;
            // 
            // clmPasaporte
            // 
            this.clmPasaporte.HeaderText = "Pasaporte";
            this.clmPasaporte.MinimumWidth = 6;
            this.clmPasaporte.Name = "clmPasaporte";
            this.clmPasaporte.ReadOnly = true;
            this.clmPasaporte.Width = 125;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre ";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 125;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "Apellido";
            this.clmApellido.MinimumWidth = 6;
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.ReadOnly = true;
            this.clmApellido.Width = 125;
            // 
            // clmFechaIngreso
            // 
            this.clmFechaIngreso.HeaderText = "Fecha Ingreso";
            this.clmFechaIngreso.MinimumWidth = 6;
            this.clmFechaIngreso.Name = "clmFechaIngreso";
            this.clmFechaIngreso.ReadOnly = true;
            this.clmFechaIngreso.Width = 125;
            // 
            // clmFechaSalida
            // 
            this.clmFechaSalida.HeaderText = "Fecha Salida";
            this.clmFechaSalida.MinimumWidth = 6;
            this.clmFechaSalida.Name = "clmFechaSalida";
            this.clmFechaSalida.ReadOnly = true;
            this.clmFechaSalida.Width = 125;
            // 
            // clmNumeroCochera
            // 
            this.clmNumeroCochera.HeaderText = "N° Cochera";
            this.clmNumeroCochera.MinimumWidth = 6;
            this.clmNumeroCochera.Name = "clmNumeroCochera";
            this.clmNumeroCochera.ReadOnly = true;
            this.clmNumeroCochera.Width = 125;
            // 
            // clmCantidadPersonas
            // 
            this.clmCantidadPersonas.HeaderText = "Cant. Pers.";
            this.clmCantidadPersonas.MinimumWidth = 6;
            this.clmCantidadPersonas.Name = "clmCantidadPersonas";
            this.clmCantidadPersonas.ReadOnly = true;
            this.clmCantidadPersonas.Width = 125;
            // 
            // dgvDetalleReserva
            // 
            this.dgvDetalleReserva.AllowUserToAddRows = false;
            this.dgvDetalleReserva.AllowUserToDeleteRows = false;
            this.dgvDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItem,
            this.clmNumeroHabitacion,
            this.clmTipoHabitacion,
            this.clmPrecioHabitacion});
            this.dgvDetalleReserva.Location = new System.Drawing.Point(33, 544);
            this.dgvDetalleReserva.Name = "dgvDetalleReserva";
            this.dgvDetalleReserva.ReadOnly = true;
            this.dgvDetalleReserva.RowHeadersWidth = 51;
            this.dgvDetalleReserva.RowTemplate.Height = 24;
            this.dgvDetalleReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleReserva.Size = new System.Drawing.Size(570, 217);
            this.dgvDetalleReserva.TabIndex = 13;
            this.dgvDetalleReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleReserva_CellClick);
            // 
            // clmItem
            // 
            this.clmItem.HeaderText = "N° Item";
            this.clmItem.MinimumWidth = 6;
            this.clmItem.Name = "clmItem";
            this.clmItem.ReadOnly = true;
            this.clmItem.Width = 125;
            // 
            // clmNumeroHabitacion
            // 
            this.clmNumeroHabitacion.HeaderText = "N° Habitacion";
            this.clmNumeroHabitacion.MinimumWidth = 6;
            this.clmNumeroHabitacion.Name = "clmNumeroHabitacion";
            this.clmNumeroHabitacion.ReadOnly = true;
            this.clmNumeroHabitacion.Width = 125;
            // 
            // clmTipoHabitacion
            // 
            this.clmTipoHabitacion.HeaderText = "Tipo";
            this.clmTipoHabitacion.MinimumWidth = 6;
            this.clmTipoHabitacion.Name = "clmTipoHabitacion";
            this.clmTipoHabitacion.ReadOnly = true;
            this.clmTipoHabitacion.Width = 125;
            // 
            // clmPrecioHabitacion
            // 
            this.clmPrecioHabitacion.HeaderText = "Precio";
            this.clmPrecioHabitacion.MinimumWidth = 6;
            this.clmPrecioHabitacion.Name = "clmPrecioHabitacion";
            this.clmPrecioHabitacion.ReadOnly = true;
            this.clmPrecioHabitacion.Width = 125;
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(30, 235);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(61, 17);
            this.lblReserva.TabIndex = 14;
            this.lblReserva.Text = "Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Detalle Reserva";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(808, 667);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarReserva.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancelarReserva.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarReserva.BorderRadius = 20;
            this.btnCancelarReserva.BorderSize = 0;
            this.btnCancelarReserva.FlatAppearance.BorderSize = 0;
            this.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReserva.ForeColor = System.Drawing.Color.White;
            this.btnCancelarReserva.Location = new System.Drawing.Point(808, 568);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarReserva.TabIndex = 10;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.TextColor = System.Drawing.Color.White;
            this.btnCancelarReserva.UseVisualStyleBackColor = false;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(853, 132);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 40);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(853, 48);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // frmConsultaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 798);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReserva);
            this.Controls.Add(this.dgvDetalleReserva);
            this.Controls.Add(this.dgvReserva);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblFechaSalida);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPasaporte);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtPasaporte);
            this.Name = "frmConsultaReservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.frmConsultaReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.Label lblFechaIngreso;
        private Custom.RJButton btnLimpiar;
        private Custom.RJButton btnConsultar;
        private Custom.RJButton btnCancelarReserva;
        private Custom.RJButton btnSalir;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.DataGridView dgvDetalleReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioHabitacion;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroCochera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadPersonas;
    }
}