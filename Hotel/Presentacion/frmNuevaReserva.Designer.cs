
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
            this.txtPasaporte = new System.Windows.Forms.TextBox();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.grpHuesped = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpVehiculo = new System.Windows.Forms.GroupBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpHabitaciones = new System.Windows.Forms.GroupBox();
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmNumeroSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPisoSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecioSeleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcionSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.grpCochera = new System.Windows.Forms.GroupBox();
            this.lblNumeroCochera = new System.Windows.Forms.Label();
            this.txtNumeroCochera = new System.Windows.Forms.TextBox();
            this.lblPrecioCochera = new System.Windows.Forms.Label();
            this.txtPrecioCochera = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnQuitarHabitacion = new Hotel.Custom.RJButton();
            this.btnAgregarHabitacion = new Hotel.Custom.RJButton();
            this.btnConsultarHabitaciones = new Hotel.Custom.RJButton();
            this.btnAgregarVehiculo = new Hotel.Custom.RJButton();
            this.btn = new Hotel.Custom.RJButton();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.btnAceptar = new Hotel.Custom.RJButton();
            this.btnCancelar = new Hotel.Custom.RJButton();
            this.grpHuesped.SuspendLayout();
            this.grpVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpHabitaciones.SuspendLayout();
            this.grpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grpCochera.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(125, 52);
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(100, 22);
            this.txtPasaporte.TabIndex = 0;
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Location = new System.Drawing.Point(32, 52);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(73, 17);
            this.lblPasaporte.TabIndex = 1;
            this.lblPasaporte.Text = "Pasaporte";
            // 
            // grpHuesped
            // 
            this.grpHuesped.Controls.Add(this.btn);
            this.grpHuesped.Controls.Add(this.btnConsultar);
            this.grpHuesped.Controls.Add(this.lblNombre);
            this.grpHuesped.Controls.Add(this.lblApellido);
            this.grpHuesped.Controls.Add(this.txtNombre);
            this.grpHuesped.Controls.Add(this.txtApellido);
            this.grpHuesped.Controls.Add(this.txtPasaporte);
            this.grpHuesped.Controls.Add(this.lblPasaporte);
            this.grpHuesped.Location = new System.Drawing.Point(12, 26);
            this.grpHuesped.Name = "grpHuesped";
            this.grpHuesped.Size = new System.Drawing.Size(472, 218);
            this.grpHuesped.TabIndex = 2;
            this.grpHuesped.TabStop = false;
            this.grpHuesped.Text = "Huesped";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(125, 162);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(32, 165);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // grpVehiculo
            // 
            this.grpVehiculo.Controls.Add(this.txtMarca);
            this.grpVehiculo.Controls.Add(this.txtModelo);
            this.grpVehiculo.Controls.Add(this.txtPatente);
            this.grpVehiculo.Controls.Add(this.lblMarca);
            this.grpVehiculo.Controls.Add(this.lblModelo);
            this.grpVehiculo.Controls.Add(this.lblPatente);
            this.grpVehiculo.Controls.Add(this.btnAgregarVehiculo);
            this.grpVehiculo.Location = new System.Drawing.Point(570, 26);
            this.grpVehiculo.Name = "grpVehiculo";
            this.grpVehiculo.Size = new System.Drawing.Size(464, 218);
            this.grpVehiculo.TabIndex = 3;
            this.grpVehiculo.TabStop = false;
            this.grpVehiculo.Text = "Vehículo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(242, 52);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(57, 17);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(242, 142);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 2;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(37, 142);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(311, 47);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 22);
            this.txtPatente.TabIndex = 4;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(325, 137);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(89, 142);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 22);
            this.txtMarca.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumero,
            this.clmPiso,
            this.clmTipoHabitacion,
            this.clmPrecio,
            this.clmDescripcion});
            this.dataGridView1.Location = new System.Drawing.Point(23, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 443);
            this.dataGridView1.TabIndex = 4;
            // 
            // clmNumero
            // 
            this.clmNumero.HeaderText = "Número";
            this.clmNumero.MinimumWidth = 6;
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.Width = 125;
            // 
            // clmPiso
            // 
            this.clmPiso.HeaderText = "Piso ";
            this.clmPiso.MinimumWidth = 6;
            this.clmPiso.Name = "clmPiso";
            this.clmPiso.Width = 125;
            // 
            // clmTipoHabitacion
            // 
            this.clmTipoHabitacion.HeaderText = "Tipo ";
            this.clmTipoHabitacion.MinimumWidth = 6;
            this.clmTipoHabitacion.Name = "clmTipoHabitacion";
            this.clmTipoHabitacion.Width = 125;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.MinimumWidth = 6;
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.Width = 125;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripción";
            this.clmDescripcion.MinimumWidth = 6;
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.Width = 125;
            // 
            // grpHabitaciones
            // 
            this.grpHabitaciones.Controls.Add(this.dataGridView1);
            this.grpHabitaciones.Location = new System.Drawing.Point(12, 267);
            this.grpHabitaciones.Name = "grpHabitaciones";
            this.grpHabitaciones.Size = new System.Drawing.Size(713, 538);
            this.grpHabitaciones.TabIndex = 5;
            this.grpHabitaciones.TabStop = false;
            this.grpHabitaciones.Text = "Habitaciones Disponibles";
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.lblSubtotal);
            this.grpReserva.Controls.Add(this.txtSubtotal);
            this.grpReserva.Controls.Add(this.txtCantidadPersonas);
            this.grpReserva.Controls.Add(this.lblCantidadPersonas);
            this.grpReserva.Controls.Add(this.dataGridView2);
            this.grpReserva.Controls.Add(this.btnConsultarHabitaciones);
            this.grpReserva.Controls.Add(this.dtpFechaSalida);
            this.grpReserva.Controls.Add(this.dtpFechaIngreso);
            this.grpReserva.Location = new System.Drawing.Point(923, 250);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(713, 504);
            this.grpReserva.TabIndex = 6;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Reserva";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(61, 76);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIngreso.TabIndex = 0;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(409, 76);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaSalida.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumeroSeleccionado,
            this.clmPisoSeleccionado,
            this.clmTipoSeleccionado,
            this.clmPrecioSeleccionado,
            this.clmDescripcionSeleccionada});
            this.dataGridView2.Location = new System.Drawing.Point(6, 303);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(674, 110);
            this.dataGridView2.TabIndex = 3;
            // 
            // clmNumeroSeleccionado
            // 
            this.clmNumeroSeleccionado.HeaderText = "Número";
            this.clmNumeroSeleccionado.MinimumWidth = 6;
            this.clmNumeroSeleccionado.Name = "clmNumeroSeleccionado";
            this.clmNumeroSeleccionado.Width = 125;
            // 
            // clmPisoSeleccionado
            // 
            this.clmPisoSeleccionado.HeaderText = "Piso";
            this.clmPisoSeleccionado.MinimumWidth = 6;
            this.clmPisoSeleccionado.Name = "clmPisoSeleccionado";
            this.clmPisoSeleccionado.Width = 125;
            // 
            // clmTipoSeleccionado
            // 
            this.clmTipoSeleccionado.HeaderText = "Tipo";
            this.clmTipoSeleccionado.MinimumWidth = 6;
            this.clmTipoSeleccionado.Name = "clmTipoSeleccionado";
            this.clmTipoSeleccionado.Width = 125;
            // 
            // clmPrecioSeleccionado
            // 
            this.clmPrecioSeleccionado.HeaderText = "Precio";
            this.clmPrecioSeleccionado.MinimumWidth = 6;
            this.clmPrecioSeleccionado.Name = "clmPrecioSeleccionado";
            this.clmPrecioSeleccionado.Width = 125;
            // 
            // clmDescripcionSeleccionada
            // 
            this.clmDescripcionSeleccionada.HeaderText = "Despcripción";
            this.clmDescripcionSeleccionada.MinimumWidth = 6;
            this.clmDescripcionSeleccionada.Name = "clmDescripcionSeleccionada";
            this.clmDescripcionSeleccionada.Width = 125;
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.Location = new System.Drawing.Point(77, 229);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(152, 17);
            this.lblCantidadPersonas.TabIndex = 6;
            this.lblCantidadPersonas.Text = "Cantidad de Personas:";
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Location = new System.Drawing.Point(235, 226);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadPersonas.TabIndex = 7;
            // 
            // grpCochera
            // 
            this.grpCochera.Controls.Add(this.txtPrecioCochera);
            this.grpCochera.Controls.Add(this.lblPrecioCochera);
            this.grpCochera.Controls.Add(this.txtNumeroCochera);
            this.grpCochera.Controls.Add(this.lblNumeroCochera);
            this.grpCochera.Location = new System.Drawing.Point(1221, 39);
            this.grpCochera.Name = "grpCochera";
            this.grpCochera.Size = new System.Drawing.Size(359, 192);
            this.grpCochera.TabIndex = 9;
            this.grpCochera.TabStop = false;
            this.grpCochera.Text = "Cochera Asignada";
            this.grpCochera.Enter += new System.EventHandler(this.grpCochera_Enter);
            // 
            // lblNumeroCochera
            // 
            this.lblNumeroCochera.AutoSize = true;
            this.lblNumeroCochera.Location = new System.Drawing.Point(40, 49);
            this.lblNumeroCochera.Name = "lblNumeroCochera";
            this.lblNumeroCochera.Size = new System.Drawing.Size(58, 17);
            this.lblNumeroCochera.TabIndex = 0;
            this.lblNumeroCochera.Text = "Número";
            // 
            // txtNumeroCochera
            // 
            this.txtNumeroCochera.Location = new System.Drawing.Point(139, 49);
            this.txtNumeroCochera.Name = "txtNumeroCochera";
            this.txtNumeroCochera.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroCochera.TabIndex = 1;
            // 
            // lblPrecioCochera
            // 
            this.lblPrecioCochera.AutoSize = true;
            this.lblPrecioCochera.Location = new System.Drawing.Point(50, 124);
            this.lblPrecioCochera.Name = "lblPrecioCochera";
            this.lblPrecioCochera.Size = new System.Drawing.Size(48, 17);
            this.lblPrecioCochera.TabIndex = 2;
            this.lblPrecioCochera.Text = "Precio";
            // 
            // txtPrecioCochera
            // 
            this.txtPrecioCochera.Location = new System.Drawing.Point(139, 119);
            this.txtPrecioCochera.Name = "txtPrecioCochera";
            this.txtPrecioCochera.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioCochera.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1441, 807);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 17);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(581, 463);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1495, 804);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 12;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(507, 466);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 17);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // btnQuitarHabitacion
            // 
            this.btnQuitarHabitacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarHabitacion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnQuitarHabitacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuitarHabitacion.BorderRadius = 20;
            this.btnQuitarHabitacion.BorderSize = 0;
            this.btnQuitarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnQuitarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnQuitarHabitacion.Location = new System.Drawing.Point(745, 618);
            this.btnQuitarHabitacion.Name = "btnQuitarHabitacion";
            this.btnQuitarHabitacion.Size = new System.Drawing.Size(150, 40);
            this.btnQuitarHabitacion.TabIndex = 8;
            this.btnQuitarHabitacion.Text = "<<<<<";
            this.btnQuitarHabitacion.TextColor = System.Drawing.Color.White;
            this.btnQuitarHabitacion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarHabitacion.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarHabitacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarHabitacion.BorderRadius = 20;
            this.btnAgregarHabitacion.BorderSize = 0;
            this.btnAgregarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(745, 466);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarHabitacion.TabIndex = 7;
            this.btnAgregarHabitacion.Text = ">>>>>";
            this.btnAgregarHabitacion.TextColor = System.Drawing.Color.White;
            this.btnAgregarHabitacion.UseVisualStyleBackColor = false;
            // 
            // btnConsultarHabitaciones
            // 
            this.btnConsultarHabitaciones.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultarHabitaciones.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConsultarHabitaciones.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultarHabitaciones.BorderRadius = 20;
            this.btnConsultarHabitaciones.BorderSize = 0;
            this.btnConsultarHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnConsultarHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnConsultarHabitaciones.Location = new System.Drawing.Point(272, 121);
            this.btnConsultarHabitaciones.Name = "btnConsultarHabitaciones";
            this.btnConsultarHabitaciones.Size = new System.Drawing.Size(150, 40);
            this.btnConsultarHabitaciones.TabIndex = 2;
            this.btnConsultarHabitaciones.Text = "Consultar";
            this.btnConsultarHabitaciones.TextColor = System.Drawing.Color.White;
            this.btnConsultarHabitaciones.UseVisualStyleBackColor = false;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarVehiculo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregarVehiculo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarVehiculo.BorderRadius = 20;
            this.btnAgregarVehiculo.BorderSize = 0;
            this.btnAgregarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnAgregarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(17, 43);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(150, 40);
            this.btnAgregarVehiculo.TabIndex = 0;
            this.btnAgregarVehiculo.Text = "Agregar";
            this.btnAgregarVehiculo.TextColor = System.Drawing.Color.White;
            this.btnAgregarVehiculo.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn.BorderRadius = 20;
            this.btn.BorderSize = 0;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(280, 142);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(150, 40);
            this.btn.TabIndex = 7;
            this.btn.Text = "Agregar";
            this.btn.TextColor = System.Drawing.Color.White;
            this.btn.UseVisualStyleBackColor = false;
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
            this.btnConsultar.Location = new System.Drawing.Point(280, 62);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 40);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
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
            this.btnAceptar.Location = new System.Drawing.Point(945, 804);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 40);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(1169, 804);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1670, 950);
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
            this.Name = "frmNuevaReserva";
            this.Text = "Nueva Reserva";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpHuesped.ResumeLayout(false);
            this.grpHuesped.PerformLayout();
            this.grpVehiculo.ResumeLayout(false);
            this.grpVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpHabitaciones.ResumeLayout(false);
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grpCochera.ResumeLayout(false);
            this.grpCochera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasaporte;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.GroupBox grpHuesped;
        private Custom.RJButton btn;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.GroupBox grpHabitaciones;
        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumeroSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPisoSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecioSeleccionado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcionSeleccionada;
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
    }
}