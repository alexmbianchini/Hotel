
namespace Hotel.Presentacion
{
    partial class frmNuevaReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevaReserva));
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.grpHuesped = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.grpVehiculo = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.grpHabitaciones = new System.Windows.Forms.GroupBox();
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.grpCochera = new System.Windows.Forms.GroupBox();
            this.txtPrecioCochera = new System.Windows.Forms.TextBox();
            this.lblPrecioCochera = new System.Windows.Forms.Label();
            this.txtNumeroCochera = new System.Windows.Forms.TextBox();
            this.lblNumeroCochera = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotalCochera = new System.Windows.Forms.Label();
            this.txtSubtotalCochera = new System.Windows.Forms.TextBox();
            this.btnCancelar = new Hotel.Custom.RJButton();
            this.btnAceptar = new Hotel.Custom.RJButton();
            this.btnQuitarHabitacion = new Hotel.Custom.RJButton();
            this.btnAgregarHabitacion = new Hotel.Custom.RJButton();
            this.btnConsultarHabitaciones = new Hotel.Custom.RJButton();
            this.btnQuitarVehiculo = new Hotel.Custom.RJButton();
            this.btnAgregarVehiculo = new Hotel.Custom.RJButton();
            this.btnAgregarHusped = new Hotel.Custom.RJButton();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumeroSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPisoSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcionSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpHuesped.SuspendLayout();
            this.grpVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.grpHabitaciones.SuspendLayout();
            this.grpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.grpCochera.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasaporte.Location = new System.Drawing.Point(100, 35);
            this.txtPasaporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(76, 25);
            this.txtPasaporte.TabIndex = 0;
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Location = new System.Drawing.Point(16, 39);
            this.lblPasaporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(70, 19);
            this.lblPasaporte.TabIndex = 1;
            this.lblPasaporte.Text = "Pasaporte";
            // 
            // grpHuesped
            // 
            this.grpHuesped.Controls.Add(this.btnAgregarHusped);
            this.grpHuesped.Controls.Add(this.btnConsultar);
            this.grpHuesped.Controls.Add(this.lblNombre);
            this.grpHuesped.Controls.Add(this.lblApellido);
            this.grpHuesped.Controls.Add(this.txtNombre);
            this.grpHuesped.Controls.Add(this.txtApellido);
            this.grpHuesped.Controls.Add(this.txtPasaporte);
            this.grpHuesped.Controls.Add(this.lblPasaporte);
            this.grpHuesped.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHuesped.Location = new System.Drawing.Point(36, 21);
            this.grpHuesped.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHuesped.Name = "grpHuesped";
            this.grpHuesped.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHuesped.Size = new System.Drawing.Size(354, 177);
            this.grpHuesped.TabIndex = 2;
            this.grpHuesped.TabStop = false;
            this.grpHuesped.Text = "Huesped";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 81);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 19);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 127);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 19);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 75);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 121);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(76, 25);
            this.txtApellido.TabIndex = 2;
            // 
            // grpVehiculo
            // 
            this.grpVehiculo.Controls.Add(this.txtMarca);
            this.grpVehiculo.Controls.Add(this.txtModelo);
            this.grpVehiculo.Controls.Add(this.btnQuitarVehiculo);
            this.grpVehiculo.Controls.Add(this.txtPatente);
            this.grpVehiculo.Controls.Add(this.lblMarca);
            this.grpVehiculo.Controls.Add(this.lblModelo);
            this.grpVehiculo.Controls.Add(this.lblPatente);
            this.grpVehiculo.Controls.Add(this.btnAgregarVehiculo);
            this.grpVehiculo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVehiculo.Location = new System.Drawing.Point(483, 21);
            this.grpVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpVehiculo.Name = "grpVehiculo";
            this.grpVehiculo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpVehiculo.Size = new System.Drawing.Size(367, 177);
            this.grpVehiculo.TabIndex = 3;
            this.grpVehiculo.TabStop = false;
            this.grpVehiculo.Text = "Vehículo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(112, 81);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(76, 25);
            this.txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(112, 127);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(76, 25);
            this.txtModelo.TabIndex = 5;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(112, 36);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(76, 25);
            this.txtPatente.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(44, 87);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 19);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(36, 133);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 19);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(36, 42);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(56, 19);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumero,
            this.clmPiso,
            this.clmTipoHabitacion,
            this.clmPrecio,
            this.clmDescripcion});
            this.dgvHabitaciones.Location = new System.Drawing.Point(18, 36);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersWidth = 51;
            this.dgvHabitaciones.RowTemplate.Height = 24;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(491, 360);
            this.dgvHabitaciones.TabIndex = 4;
            // 
            // grpHabitaciones
            // 
            this.grpHabitaciones.Controls.Add(this.dgvHabitaciones);
            this.grpHabitaciones.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHabitaciones.Location = new System.Drawing.Point(9, 217);
            this.grpHabitaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHabitaciones.Name = "grpHabitaciones";
            this.grpHabitaciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHabitaciones.Size = new System.Drawing.Size(535, 432);
            this.grpHabitaciones.TabIndex = 5;
            this.grpHabitaciones.TabStop = false;
            this.grpHabitaciones.Text = "Habitaciones Disponibles";
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.lblFechaHasta);
            this.grpReserva.Controls.Add(this.lblFechaDesde);
            this.grpReserva.Controls.Add(this.lblSubtotal);
            this.grpReserva.Controls.Add(this.txtSubtotal);
            this.grpReserva.Controls.Add(this.txtCantidadPersonas);
            this.grpReserva.Controls.Add(this.lblCantidadPersonas);
            this.grpReserva.Controls.Add(this.dgvReservas);
            this.grpReserva.Controls.Add(this.btnConsultarHabitaciones);
            this.grpReserva.Controls.Add(this.dtpFechaSalida);
            this.grpReserva.Controls.Add(this.dtpFechaIngreso);
            this.grpReserva.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReserva.Location = new System.Drawing.Point(692, 217);
            this.grpReserva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReserva.Size = new System.Drawing.Size(549, 384);
            this.grpReserva.TabIndex = 6;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Reserva";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(47, 87);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(87, 19);
            this.lblFechaHasta.TabIndex = 10;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(44, 36);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(90, 19);
            this.lblFechaDesde.TabIndex = 7;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(274, 346);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(151, 19);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal Habitaciones: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(436, 343);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(76, 25);
            this.txtSubtotal.TabIndex = 8;
            
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Location = new System.Drawing.Point(208, 137);
            this.txtCantidadPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(42, 25);
            this.txtCantidadPersonas.TabIndex = 7;
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(47, 140);
            this.lblCantidadPersonas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(145, 19);
            this.lblCantidadPersonas.TabIndex = 6;
            this.lblCantidadPersonas.Text = "Cantidad de Personas:";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumeroSeleccionado,
            this.clmPisoSeleccionado,
            this.clmTipoSeleccionado,
            this.clmPrecioSeleccionado,
            this.clmDescripcionSeleccionada});
            this.dgvReservas.Location = new System.Drawing.Point(25, 195);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(506, 125);
            this.dgvReservas.TabIndex = 3;
            
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(138, 83);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(193, 25);
            this.dtpFechaSalida.TabIndex = 1;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(138, 32);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(193, 25);
            this.dtpFechaIngreso.TabIndex = 0;
            // 
            // grpCochera
            // 
            this.grpCochera.Controls.Add(this.txtPrecioCochera);
            this.grpCochera.Controls.Add(this.lblPrecioCochera);
            this.grpCochera.Controls.Add(this.txtNumeroCochera);
            this.grpCochera.Controls.Add(this.lblNumeroCochera);
            this.grpCochera.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCochera.Location = new System.Drawing.Point(931, 21);
            this.grpCochera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCochera.Name = "grpCochera";
            this.grpCochera.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCochera.Size = new System.Drawing.Size(250, 177);
            this.grpCochera.TabIndex = 9;
            this.grpCochera.TabStop = false;
            this.grpCochera.Text = "Cochera Asignada";
            // 
            // txtPrecioCochera
            // 
            this.txtPrecioCochera.Location = new System.Drawing.Point(126, 107);
            this.txtPrecioCochera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioCochera.Name = "txtPrecioCochera";
            this.txtPrecioCochera.Size = new System.Drawing.Size(76, 25);
            this.txtPrecioCochera.TabIndex = 3;
            // 
            // lblPrecioCochera
            // 
            this.lblPrecioCochera.AutoSize = true;
            this.lblPrecioCochera.Location = new System.Drawing.Point(59, 113);
            this.lblPrecioCochera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioCochera.Name = "lblPrecioCochera";
            this.lblPrecioCochera.Size = new System.Drawing.Size(47, 19);
            this.lblPrecioCochera.TabIndex = 2;
            this.lblPrecioCochera.Text = "Precio";
            // 
            // txtNumeroCochera
            // 
            this.txtNumeroCochera.Location = new System.Drawing.Point(126, 59);
            this.txtNumeroCochera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeroCochera.Name = "txtNumeroCochera";
            this.txtNumeroCochera.Size = new System.Drawing.Size(76, 25);
            this.txtNumeroCochera.TabIndex = 1;
            // 
            // lblNumeroCochera
            // 
            this.lblNumeroCochera.AutoSize = true;
            this.lblNumeroCochera.Location = new System.Drawing.Point(46, 65);
            this.lblNumeroCochera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroCochera.Name = "lblNumeroCochera";
            this.lblNumeroCochera.Size = new System.Drawing.Size(60, 19);
            this.lblNumeroCochera.TabIndex = 0;
            this.lblNumeroCochera.Text = "Número";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1066, 665);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(1128, 659);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 25);
            this.txtTotal.TabIndex = 12;
            // 
            // lblSubtotalCochera
            // 
            this.lblSubtotalCochera.AutoSize = true;
            this.lblSubtotalCochera.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalCochera.Location = new System.Drawing.Point(998, 620);
            this.lblSubtotalCochera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotalCochera.Name = "lblSubtotalCochera";
            this.lblSubtotalCochera.Size = new System.Drawing.Size(119, 19);
            this.lblSubtotalCochera.TabIndex = 16;
            this.lblSubtotalCochera.Text = "Subtotal Cochera:";
            // 
            // txtSubtotalCochera
            // 
            this.txtSubtotalCochera.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotalCochera.Location = new System.Drawing.Point(1128, 614);
            this.txtSubtotalCochera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotalCochera.Name = "txtSubtotalCochera";
            this.txtSubtotalCochera.Size = new System.Drawing.Size(76, 25);
            this.txtSubtotalCochera.TabIndex = 17;
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
            this.btnCancelar.Location = new System.Drawing.Point(1078, 709);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 39);
            this.btnCancelar.TabIndex = 14;
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
            this.btnAceptar.Location = new System.Drawing.Point(891, 709);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 39);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnQuitarHabitacion
            // 
            this.btnQuitarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(150)))));
            this.btnQuitarHabitacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(150)))));
            this.btnQuitarHabitacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarHabitacion.BorderRadius = 20;
            this.btnQuitarHabitacion.BorderSize = 0;
            this.btnQuitarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarHabitacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarHabitacion.Location = new System.Drawing.Point(564, 463);
            this.btnQuitarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarHabitacion.Name = "btnQuitarHabitacion";
            this.btnQuitarHabitacion.Size = new System.Drawing.Size(98, 38);
            this.btnQuitarHabitacion.TabIndex = 8;
            this.btnQuitarHabitacion.Text = "<<<<<";
            this.btnQuitarHabitacion.TextColor = System.Drawing.Color.White;
            this.btnQuitarHabitacion.UseVisualStyleBackColor = false;
            this.btnQuitarHabitacion.Click += new System.EventHandler(this.btnQuitarHabitacion_Click);
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(150)))));
            this.btnAgregarHabitacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(150)))));
            this.btnAgregarHabitacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarHabitacion.BorderRadius = 20;
            this.btnAgregarHabitacion.BorderSize = 0;
            this.btnAgregarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabitacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(564, 373);
            this.btnAgregarHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(98, 39);
            this.btnAgregarHabitacion.TabIndex = 7;
            this.btnAgregarHabitacion.Text = ">>>>>";
            this.btnAgregarHabitacion.TextColor = System.Drawing.Color.White;
            this.btnAgregarHabitacion.UseVisualStyleBackColor = false;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // btnConsultarHabitaciones
            // 
            this.btnConsultarHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnConsultarHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnConsultarHabitaciones.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultarHabitaciones.BorderRadius = 20;
            this.btnConsultarHabitaciones.BorderSize = 0;
            this.btnConsultarHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnConsultarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnConsultarHabitaciones.Location = new System.Drawing.Point(391, 87);
            this.btnConsultarHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarHabitaciones.Name = "btnConsultarHabitaciones";
            this.btnConsultarHabitaciones.Size = new System.Drawing.Size(121, 37);
            this.btnConsultarHabitaciones.TabIndex = 2;
            this.btnConsultarHabitaciones.Text = "Consultar";
            this.btnConsultarHabitaciones.TextColor = System.Drawing.Color.White;
            this.btnConsultarHabitaciones.UseVisualStyleBackColor = false;
            this.btnConsultarHabitaciones.Click += new System.EventHandler(this.btnConsultarHabitaciones_Click);
            // 
            // btnQuitarVehiculo
            // 
            this.btnQuitarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnQuitarVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnQuitarVehiculo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarVehiculo.BorderRadius = 20;
            this.btnQuitarVehiculo.BorderSize = 0;
            this.btnQuitarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnQuitarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnQuitarVehiculo.Location = new System.Drawing.Point(234, 103);
            this.btnQuitarVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarVehiculo.Name = "btnQuitarVehiculo";
            this.btnQuitarVehiculo.Size = new System.Drawing.Size(118, 36);
            this.btnQuitarVehiculo.TabIndex = 15;
            this.btnQuitarVehiculo.Text = "Quitar Vehículo";
            this.btnQuitarVehiculo.TextColor = System.Drawing.Color.White;
            this.btnQuitarVehiculo.UseVisualStyleBackColor = false;
            this.btnQuitarVehiculo.Click += new System.EventHandler(this.btnQuitarVehiculo_Click);
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnAgregarVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnAgregarVehiculo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarVehiculo.BorderRadius = 20;
            this.btnAgregarVehiculo.BorderSize = 0;
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(234, 48);
            this.btnAgregarVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(118, 36);
            this.btnAgregarVehiculo.TabIndex = 0;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.TextColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // btnAgregarHusped
            // 
            this.btnAgregarHusped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnAgregarHusped.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnAgregarHusped.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarHusped.BorderRadius = 20;
            this.btnAgregarHusped.BorderSize = 0;
            this.btnAgregarHusped.FlatAppearance.BorderSize = 0;
            this.btnAgregarHusped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHusped.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHusped.Location = new System.Drawing.Point(216, 104);
            this.btnAgregarHusped.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarHusped.Name = "btnAgregarHusped";
            this.btnAgregarHusped.Size = new System.Drawing.Size(112, 37);
            this.btnAgregarHusped.TabIndex = 7;
            this.btnAgregarHusped.Text = "Agregar";
            this.btnAgregarHusped.TextColor = System.Drawing.Color.White;
            this.btnAgregarHusped.UseVisualStyleBackColor = false;
            this.btnAgregarHusped.Click += new System.EventHandler(this.btnAgregarHusped_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 20;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(216, 48);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(112, 36);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // clmNumero
            // 
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.MinimumWidth = 6;
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            this.clmNumero.Width = 80;
            // 
            // clmPiso
            // 
            this.clmPiso.HeaderText = "Piso ";
            this.clmPiso.MinimumWidth = 6;
            this.clmPiso.Name = "clmPiso";
            this.clmPiso.ReadOnly = true;
            this.clmPiso.Width = 65;
            // 
            // clmTipoHabitacion
            // 
            this.clmTipoHabitacion.HeaderText = "Tipo ";
            this.clmTipoHabitacion.MinimumWidth = 6;
            this.clmTipoHabitacion.Name = "clmTipoHabitacion";
            this.clmTipoHabitacion.ReadOnly = true;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.MinimumWidth = 6;
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            this.clmPrecio.Width = 125;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.MinimumWidth = 6;
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 125;
            // 
            // clmNumeroSeleccionado
            // 
            this.clmNumeroSeleccionado.HeaderText = "Número";
            this.clmNumeroSeleccionado.MinimumWidth = 6;
            this.clmNumeroSeleccionado.Name = "clmNumeroSeleccionado";
            this.clmNumeroSeleccionado.ReadOnly = true;
            this.clmNumeroSeleccionado.Width = 80;
            // 
            // clmPisoSeleccionado
            // 
            this.clmPisoSeleccionado.HeaderText = "Piso";
            this.clmPisoSeleccionado.MinimumWidth = 6;
            this.clmPisoSeleccionado.Name = "clmPisoSeleccionado";
            this.clmPisoSeleccionado.ReadOnly = true;
            this.clmPisoSeleccionado.Width = 65;
            // 
            // clmTipoSeleccionado
            // 
            this.clmTipoSeleccionado.HeaderText = "Tipo";
            this.clmTipoSeleccionado.MinimumWidth = 6;
            this.clmTipoSeleccionado.Name = "clmTipoSeleccionado";
            this.clmTipoSeleccionado.ReadOnly = true;
            // 
            // clmPrecioSeleccionado
            // 
            this.clmPrecioSeleccionado.HeaderText = "Precio";
            this.clmPrecioSeleccionado.MinimumWidth = 6;
            this.clmPrecioSeleccionado.Name = "clmPrecioSeleccionado";
            this.clmPrecioSeleccionado.ReadOnly = true;
            this.clmPrecioSeleccionado.Width = 125;
            // 
            // clmDescripcionSeleccionada
            // 
            this.clmDescripcionSeleccionada.HeaderText = "Descripción";
            this.clmDescripcionSeleccionada.MinimumWidth = 6;
            this.clmDescripcionSeleccionada.Name = "clmDescripcionSeleccionada";
            this.clmDescripcionSeleccionada.ReadOnly = true;
            this.clmDescripcionSeleccionada.Width = 125;
            // 
            // frmNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1252, 759);
            this.Controls.Add(this.txtSubtotalCochera);
            this.Controls.Add(this.lblSubtotalCochera);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpCochera);
            this.Controls.Add(this.btnQuitarHabitacion);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Controls.Add(this.grpReserva);
            this.Controls.Add(this.grpHabitaciones);
            this.Controls.Add(this.grpVehiculo);
            this.Controls.Add(this.grpHuesped);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmNuevaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.frmNuevaReserva_Load);
            this.grpHuesped.ResumeLayout(false);
            this.grpHuesped.PerformLayout();
            this.grpVehiculo.ResumeLayout(false);
            this.grpVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.grpHabitaciones.ResumeLayout(false);
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.grpCochera.ResumeLayout(false);
            this.grpCochera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.GroupBox grpHuesped;
        private Custom.RJButton btnAgregarHusped;
        private Custom.RJButton btnConsultar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox grpVehiculo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPatente;
        private Custom.RJButton btnAgregarVehiculo;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.GroupBox grpHabitaciones;
        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.DataGridView dgvReservas;
        private Custom.RJButton btnConsultarHabitaciones;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private Custom.RJButton btnAgregarHabitacion;
        private Custom.RJButton btnQuitarHabitacion;
        private System.Windows.Forms.GroupBox grpCochera;
        private System.Windows.Forms.TextBox txtPrecioCochera;
        private System.Windows.Forms.Label lblPrecioCochera;
        private System.Windows.Forms.TextBox txtNumeroCochera;
        private System.Windows.Forms.Label lblNumeroCochera;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private Custom.RJButton btnAceptar;
        private Custom.RJButton btnCancelar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private Custom.RJButton btnQuitarVehiculo;
        private System.Windows.Forms.Label lblSubtotalCochera;
        private System.Windows.Forms.TextBox txtSubtotalCochera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPisoSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcionSeleccionada;
    }
}