
namespace Hotel.Presentacion
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.cboApellidoEmpleado = new System.Windows.Forms.ComboBox();
            this.cboNombreUsuario = new System.Windows.Forms.ComboBox();
            this.cboNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.cboNroDoc = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.btnLimpiar = new Hotel.Custom.RJButton();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.btnNuevo = new Hotel.Custom.RJButton();
            this.btnEditar = new Hotel.Custom.RJButton();
            this.btnEliminar = new Hotel.Custom.RJButton();
            this.btnSalir = new Hotel.Custom.RJButton();
            this.clmIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdUsuario,
            this.clmNombreUsuario,
            this.clmIdEmpleado,
            this.clmTipoDoc,
            this.clmNroDoc,
            this.clmNombreEmpleado,
            this.clmApellidoEmpleado,
            this.clmPuesto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.Location = new System.Drawing.Point(31, 270);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(654, 235);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(135, 43);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(77, 23);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = " Usuario";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(451, 41);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(167, 23);
            this.lblApellidoEmpleado.TabIndex = 10;
            this.lblApellidoEmpleado.Text = "Apellido Empleado";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(545, 124);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(65, 23);
            this.lblPuesto.TabIndex = 11;
            this.lblPuesto.Text = "Puesto";
            // 
            // cboPuesto
            // 
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(635, 124);
            this.cboPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(121, 24);
            this.cboPuesto.TabIndex = 15;
            // 
            // cboApellidoEmpleado
            // 
            this.cboApellidoEmpleado.FormattingEnabled = true;
            this.cboApellidoEmpleado.Location = new System.Drawing.Point(635, 41);
            this.cboApellidoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboApellidoEmpleado.Name = "cboApellidoEmpleado";
            this.cboApellidoEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cboApellidoEmpleado.TabIndex = 16;
            // 
            // cboNombreUsuario
            // 
            this.cboNombreUsuario.FormattingEnabled = true;
            this.cboNombreUsuario.Location = new System.Drawing.Point(247, 41);
            this.cboNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNombreUsuario.Name = "cboNombreUsuario";
            this.cboNombreUsuario.Size = new System.Drawing.Size(121, 24);
            this.cboNombreUsuario.TabIndex = 18;
            // 
            // cboNombreEmpleado
            // 
            this.cboNombreEmpleado.FormattingEnabled = true;
            this.cboNombreEmpleado.Location = new System.Drawing.Point(635, 84);
            this.cboNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNombreEmpleado.Name = "cboNombreEmpleado";
            this.cboNombreEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cboNombreEmpleado.TabIndex = 20;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(448, 82);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(165, 23);
            this.lblNombreEmpleado.TabIndex = 19;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // cboNroDoc
            // 
            this.cboNroDoc.FormattingEnabled = true;
            this.cboNroDoc.Location = new System.Drawing.Point(247, 124);
            this.cboNroDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNroDoc.Name = "cboNroDoc";
            this.cboNroDoc.Size = new System.Drawing.Size(121, 24);
            this.cboNroDoc.TabIndex = 24;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.Location = new System.Drawing.Point(68, 127);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(142, 23);
            this.lblNroDoc.TabIndex = 23;
            this.lblNroDoc.Text = "Nro Documento";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(247, 84);
            this.cboTipoDoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(121, 24);
            this.cboTipoDoc.TabIndex = 22;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(65, 82);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(148, 23);
            this.lblTipoDoc.TabIndex = 21;
            this.lblTipoDoc.Text = "Tipo Documento";
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
            this.btnLimpiar.Location = new System.Drawing.Point(217, 187);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 49);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
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
            this.btnConsultar.Location = new System.Drawing.Point(503, 187);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(168, 49);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
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
            this.btnNuevo.Location = new System.Drawing.Point(733, 270);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 50);
            this.btnNuevo.TabIndex = 27;
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
            this.btnEditar.Location = new System.Drawing.Point(733, 327);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 50);
            this.btnEditar.TabIndex = 28;
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
            this.btnEliminar.Location = new System.Drawing.Point(733, 385);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 50);
            this.btnEliminar.TabIndex = 29;
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
            this.btnSalir.Location = new System.Drawing.Point(733, 443);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 50);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // clmIdUsuario
            // 
            this.clmIdUsuario.HeaderText = "ID";
            this.clmIdUsuario.MinimumWidth = 6;
            this.clmIdUsuario.Name = "clmIdUsuario";
            this.clmIdUsuario.ReadOnly = true;
            this.clmIdUsuario.Width = 30;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.HeaderText = "Usuario";
            this.clmNombreUsuario.MinimumWidth = 6;
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.ReadOnly = true;
            this.clmNombreUsuario.Width = 80;
            // 
            // clmIdEmpleado
            // 
            this.clmIdEmpleado.HeaderText = "ID Empleado";
            this.clmIdEmpleado.MinimumWidth = 6;
            this.clmIdEmpleado.Name = "clmIdEmpleado";
            this.clmIdEmpleado.ReadOnly = true;
            this.clmIdEmpleado.Width = 80;
            // 
            // clmTipoDoc
            // 
            this.clmTipoDoc.HeaderText = "Tipo Documento";
            this.clmTipoDoc.MinimumWidth = 6;
            this.clmTipoDoc.Name = "clmTipoDoc";
            this.clmTipoDoc.ReadOnly = true;
            this.clmTipoDoc.Width = 80;
            // 
            // clmNroDoc
            // 
            this.clmNroDoc.HeaderText = "Nro Documento";
            this.clmNroDoc.MinimumWidth = 6;
            this.clmNroDoc.Name = "clmNroDoc";
            this.clmNroDoc.ReadOnly = true;
            this.clmNroDoc.Width = 80;
            // 
            // clmNombreEmpleado
            // 
            this.clmNombreEmpleado.HeaderText = "Nombre";
            this.clmNombreEmpleado.MinimumWidth = 6;
            this.clmNombreEmpleado.Name = "clmNombreEmpleado";
            this.clmNombreEmpleado.ReadOnly = true;
            this.clmNombreEmpleado.Width = 80;
            // 
            // clmApellidoEmpleado
            // 
            this.clmApellidoEmpleado.HeaderText = "Apellido";
            this.clmApellidoEmpleado.MinimumWidth = 6;
            this.clmApellidoEmpleado.Name = "clmApellidoEmpleado";
            this.clmApellidoEmpleado.ReadOnly = true;
            this.clmApellidoEmpleado.Width = 90;
            // 
            // clmPuesto
            // 
            this.clmPuesto.HeaderText = "Puesto";
            this.clmPuesto.MinimumWidth = 6;
            this.clmPuesto.Name = "clmPuesto";
            this.clmPuesto.ReadOnly = true;
            this.clmPuesto.Width = 80;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(188)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(889, 538);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cboNroDoc);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.cboNombreEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.cboNombreUsuario);
            this.Controls.Add(this.cboApellidoEmpleado);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.ComboBox cboApellidoEmpleado;
        private System.Windows.Forms.ComboBox cboNombreUsuario;
        private System.Windows.Forms.ComboBox cboNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.ComboBox cboNroDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private Custom.RJButton btnLimpiar;
        private Custom.RJButton btnConsultar;
        private Custom.RJButton btnNuevo;
        private Custom.RJButton btnEditar;
        private Custom.RJButton btnEliminar;
        private Custom.RJButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPuesto;
    }
}