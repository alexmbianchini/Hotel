
namespace Hotel.Presentacion
{
    partial class frmVehiculo
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
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.clmPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new Hotel.Custom.RJButton();
            this.btnSalir = new Hotel.Custom.RJButton();
            this.btnEliminar = new Hotel.Custom.RJButton();
            this.btnEditar = new Hotel.Custom.RJButton();
            this.btnNuevo = new Hotel.Custom.RJButton();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.btnLimpiar = new Hotel.Custom.RJButton();
            this.txtPasaporte = new Hotel.Custom.RJTextBox();
            this.txtMarca = new Hotel.Custom.RJTextBox();
            this.txtPatente = new Hotel.Custom.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(55, 35);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(56, 19);
            this.lblPatente.TabIndex = 3;
            this.lblPatente.Text = "Patente";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(63, 81);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaporte.Location = new System.Drawing.Point(41, 129);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(70, 19);
            this.lblPasaporte.TabIndex = 5;
            this.lblPasaporte.Text = "Pasaporte";
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPatente,
            this.clmMarca,
            this.clmModelo,
            this.clmPasaporte,
            this.clmNombre,
            this.clmApellido,
            this.clmIdVehiculo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehiculo.Location = new System.Drawing.Point(12, 183);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculo.Size = new System.Drawing.Size(499, 217);
            this.dgvVehiculo.TabIndex = 6;
            this.dgvVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellClick);
            this.dgvVehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellContentClick);
            // 
            // clmPatente
            // 
            this.clmPatente.HeaderText = "Patente";
            this.clmPatente.MinimumWidth = 6;
            this.clmPatente.Name = "clmPatente";
            this.clmPatente.ReadOnly = true;
            this.clmPatente.Width = 80;
            // 
            // clmMarca
            // 
            this.clmMarca.HeaderText = "Marca";
            this.clmMarca.MinimumWidth = 6;
            this.clmMarca.Name = "clmMarca";
            this.clmMarca.ReadOnly = true;
            this.clmMarca.Width = 80;
            // 
            // clmModelo
            // 
            this.clmModelo.HeaderText = "Modelo";
            this.clmModelo.MinimumWidth = 6;
            this.clmModelo.Name = "clmModelo";
            this.clmModelo.ReadOnly = true;
            this.clmModelo.Width = 80;
            // 
            // clmPasaporte
            // 
            this.clmPasaporte.HeaderText = "Pasaporte";
            this.clmPasaporte.MinimumWidth = 6;
            this.clmPasaporte.Name = "clmPasaporte";
            this.clmPasaporte.ReadOnly = true;
            this.clmPasaporte.Width = 95;
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
            // clmIdVehiculo
            // 
            this.clmIdVehiculo.HeaderText = "Id";
            this.clmIdVehiculo.MinimumWidth = 6;
            this.clmIdVehiculo.Name = "clmIdVehiculo";
            this.clmIdVehiculo.ReadOnly = true;
            this.clmIdVehiculo.Visible = false;
            this.clmIdVehiculo.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(150)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(150)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(540, 168);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 40);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(540, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 40);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(540, 305);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 40);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(540, 259);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 40);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(540, 213);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 40);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextColor = System.Drawing.Color.White;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnConsultar.Location = new System.Drawing.Point(382, 97);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 40);
            this.btnConsultar.TabIndex = 8;
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
            this.btnLimpiar.Location = new System.Drawing.Point(382, 35);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 40);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.BackColor = System.Drawing.Color.White;
            this.txtPasaporte.BorderColor = System.Drawing.Color.Black;
            this.txtPasaporte.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPasaporte.BorderSize = 1;
            this.txtPasaporte.Location = new System.Drawing.Point(150, 120);
            this.txtPasaporte.Multiline = false;
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPasaporte.PasswordChar = false;
            this.txtPasaporte.Size = new System.Drawing.Size(151, 28);
            this.txtPasaporte.TabIndex = 2;
            this.txtPasaporte.UnderlinedStyle = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.BorderColor = System.Drawing.Color.Black;
            this.txtMarca.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMarca.BorderSize = 1;
            this.txtMarca.Location = new System.Drawing.Point(150, 72);
            this.txtMarca.Multiline = false;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtMarca.PasswordChar = false;
            this.txtMarca.Size = new System.Drawing.Size(151, 28);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.UnderlinedStyle = false;
            // 
            // txtPatente
            // 
            this.txtPatente.BackColor = System.Drawing.Color.White;
            this.txtPatente.BorderColor = System.Drawing.Color.Black;
            this.txtPatente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPatente.BorderSize = 1;
            this.txtPatente.Location = new System.Drawing.Point(150, 26);
            this.txtPatente.Multiline = false;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPatente.PasswordChar = false;
            this.txtPatente.Size = new System.Drawing.Size(151, 28);
            this.txtPatente.TabIndex = 0;
            this.txtPatente.UnderlinedStyle = false;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(677, 427);
            this.ControlBox = false;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.lblPasaporte);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.txtPasaporte);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPatente);
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmVehiculo";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.RJTextBox txtPatente;
        private Custom.RJTextBox txtMarca;
        private Custom.RJTextBox txtPasaporte;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private Custom.RJButton btnLimpiar;
        private Custom.RJButton btnConsultar;
        private Custom.RJButton btnNuevo;
        private Custom.RJButton btnEditar;
        private Custom.RJButton btnEliminar;
        private Custom.RJButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdVehiculo;
        private Custom.RJButton btnAgregar;
    }
}