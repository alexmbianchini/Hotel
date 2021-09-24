
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHabitacion));
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.btnLimpiar = new Hotel.Custom.RJButton();
            this.btnNuevo = new Hotel.Custom.RJButton();
            this.btnEditar = new Hotel.Custom.RJButton();
            this.btnEliminar = new Hotel.Custom.RJButton();
            this.btnSalir = new Hotel.Custom.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabitaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumero,
            this.clmEstado,
            this.clmPiso,
            this.clmTipoHabitacion,
            this.clmPrecio,
            this.clmDescripcion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabitaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHabitaciones.Location = new System.Drawing.Point(11, 238);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHabitaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHabitaciones.RowTemplate.Height = 24;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(496, 201);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellClick);
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
            this.clmEstado.Width = 90;
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
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(68, 38);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(60, 19);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Número";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(93, 129);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 19);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(94, 84);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(34, 19);
            this.lblPiso.TabIndex = 9;
            this.lblPiso.Text = "Piso";
            // 
            // cboTipo
            // 
            this.cboTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(153, 122);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(92, 27);
            this.cboTipo.TabIndex = 12;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(374, 38);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 19);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(457, 30);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(92, 27);
            this.cboEstado.TabIndex = 15;
            // 
            // lblPrecioMin
            // 
            this.lblPrecioMin.AutoSize = true;
            this.lblPrecioMin.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMin.Location = new System.Drawing.Point(326, 85);
            this.lblPrecioMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMin.Name = "lblPrecioMin";
            this.lblPrecioMin.Size = new System.Drawing.Size(98, 19);
            this.lblPrecioMin.TabIndex = 18;
            this.lblPrecioMin.Text = "Precio Mínimo";
            // 
            // lblPrecioMax
            // 
            this.lblPrecioMax.AutoSize = true;
            this.lblPrecioMax.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMax.Location = new System.Drawing.Point(325, 129);
            this.lblPrecioMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioMax.Name = "lblPrecioMax";
            this.lblPrecioMax.Size = new System.Drawing.Size(101, 19);
            this.lblPrecioMax.TabIndex = 19;
            this.lblPrecioMax.Text = "Precio Máximo";
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.BackColor = System.Drawing.Color.White;
            this.txtPrecioMax.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrecioMax.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMax.BorderSize = 1;
            this.txtPrecioMax.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecioMax.Location = new System.Drawing.Point(457, 117);
            this.txtPrecioMax.Multiline = false;
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrecioMax.PasswordChar = false;
            this.txtPrecioMax.Size = new System.Drawing.Size(92, 31);
            this.txtPrecioMax.TabIndex = 21;
            this.txtPrecioMax.UnderlinedStyle = false;
            this.txtPrecioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMax_KeyPress);
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.BackColor = System.Drawing.Color.White;
            this.txtPrecioMin.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrecioMin.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMin.BorderSize = 1;
            this.txtPrecioMin.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrecioMin.Location = new System.Drawing.Point(457, 72);
            this.txtPrecioMin.Multiline = false;
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrecioMin.PasswordChar = false;
            this.txtPrecioMin.Size = new System.Drawing.Size(92, 31);
            this.txtPrecioMin.TabIndex = 20;
            this.txtPrecioMin.UnderlinedStyle = false;
            this.txtPrecioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMin_KeyPress);
            // 
            // txtPiso
            // 
            this.txtPiso.BackColor = System.Drawing.Color.White;
            this.txtPiso.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPiso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPiso.BorderSize = 1;
            this.txtPiso.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPiso.Location = new System.Drawing.Point(153, 73);
            this.txtPiso.Multiline = false;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Padding = new System.Windows.Forms.Padding(7);
            this.txtPiso.PasswordChar = false;
            this.txtPiso.Size = new System.Drawing.Size(92, 31);
            this.txtPiso.TabIndex = 17;
            this.txtPiso.UnderlinedStyle = false;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNumero.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumero.BorderSize = 1;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumero.Location = new System.Drawing.Point(153, 26);
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumero.PasswordChar = false;
            this.txtNumero.Size = new System.Drawing.Size(92, 31);
            this.txtNumero.TabIndex = 16;
            this.txtNumero.UnderlinedStyle = false;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
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
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(363, 171);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 40);
            this.btnConsultar.TabIndex = 22;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnLimpiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpiar.BorderRadius = 20;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(163, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 40);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNuevo.BorderRadius = 20;
            this.btnNuevo.BorderSize = 0;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(523, 252);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(107, 40);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(523, 298);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 40);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(523, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 40);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSalir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(523, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 40);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(646, 465);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
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
            this.Controls.Add(this.dgvHabitaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.frmHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private Custom.RJTextBox txtNumero;
        private Custom.RJTextBox txtPiso;
        private System.Windows.Forms.Label lblPrecioMin;
        private System.Windows.Forms.Label lblPrecioMax;
        private Custom.RJTextBox txtPrecioMin;
        private Custom.RJTextBox txtPrecioMax;
        private Custom.RJButton btnConsultar;
        private Custom.RJButton btnLimpiar;
        private Custom.RJButton btnNuevo;
        private Custom.RJButton btnEditar;
        private Custom.RJButton btnEliminar;
        private Custom.RJButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
    }
}