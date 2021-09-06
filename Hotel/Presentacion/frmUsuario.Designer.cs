
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.cboNombreEmpleado = new System.Windows.Forms.ComboBox();
            this.cboIdEmpleado = new System.Windows.Forms.ComboBox();
            this.cboNombreUsuario = new System.Windows.Forms.ComboBox();
            this.clmIdUusario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdUusario,
            this.clmNombreUsuario,
            this.clmIdEmpleado,
            this.clmNombreEmpleado,
            this.clmApellidoEmpleado,
            this.clmPuesto,
            this.clmFechaIngreso});
            this.dgvUsuarios.Location = new System.Drawing.Point(-4, 230);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(617, 219);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(645, 260);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(644, 361);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 27);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(644, 411);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 27);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(644, 309);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 27);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(423, 182);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 27);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(601, 182);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(77, 27);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(64, 50);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(74, 17);
            this.lblIdUsuario.TabIndex = 7;
            this.lblIdUsuario.Text = "ID Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = " Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID Empleado";
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(467, 48);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(62, 17);
            this.lblApellidoEmpleado.TabIndex = 10;
            this.lblApellidoEmpleado.Text = "Apellido ";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(467, 94);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(52, 17);
            this.lblPuesto.TabIndex = 11;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(420, 138);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(98, 17);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(571, 133);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(121, 22);
            this.dtpFechaIngreso.TabIndex = 13;
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(169, 48);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(121, 24);
            this.cboUsuario.TabIndex = 14;
            // 
            // cboPuesto
            // 
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(571, 91);
            this.cboPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(121, 24);
            this.cboPuesto.TabIndex = 15;
            // 
            // cboNombreEmpleado
            // 
            this.cboNombreEmpleado.FormattingEnabled = true;
            this.cboNombreEmpleado.Location = new System.Drawing.Point(571, 48);
            this.cboNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNombreEmpleado.Name = "cboNombreEmpleado";
            this.cboNombreEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cboNombreEmpleado.TabIndex = 16;
            // 
            // cboIdEmpleado
            // 
            this.cboIdEmpleado.FormattingEnabled = true;
            this.cboIdEmpleado.Location = new System.Drawing.Point(169, 135);
            this.cboIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboIdEmpleado.Name = "cboIdEmpleado";
            this.cboIdEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cboIdEmpleado.TabIndex = 17;
            // 
            // cboNombreUsuario
            // 
            this.cboNombreUsuario.FormattingEnabled = true;
            this.cboNombreUsuario.Location = new System.Drawing.Point(169, 91);
            this.cboNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNombreUsuario.Name = "cboNombreUsuario";
            this.cboNombreUsuario.Size = new System.Drawing.Size(121, 24);
            this.cboNombreUsuario.TabIndex = 18;
            // 
            // clmIdUusario
            // 
            this.clmIdUusario.HeaderText = "ID";
            this.clmIdUusario.MinimumWidth = 6;
            this.clmIdUusario.Name = "clmIdUusario";
            this.clmIdUusario.Width = 30;
            // 
            // clmNombreUsuario
            // 
            this.clmNombreUsuario.HeaderText = "Usuario";
            this.clmNombreUsuario.MinimumWidth = 6;
            this.clmNombreUsuario.Name = "clmNombreUsuario";
            this.clmNombreUsuario.Width = 80;
            // 
            // clmIdEmpleado
            // 
            this.clmIdEmpleado.HeaderText = "ID Empleado";
            this.clmIdEmpleado.MinimumWidth = 6;
            this.clmIdEmpleado.Name = "clmIdEmpleado";
            this.clmIdEmpleado.Width = 80;
            // 
            // clmNombreEmpleado
            // 
            this.clmNombreEmpleado.HeaderText = "Nombre";
            this.clmNombreEmpleado.MinimumWidth = 6;
            this.clmNombreEmpleado.Name = "clmNombreEmpleado";
            // 
            // clmApellidoEmpleado
            // 
            this.clmApellidoEmpleado.HeaderText = "Apellido";
            this.clmApellidoEmpleado.MinimumWidth = 6;
            this.clmApellidoEmpleado.Name = "clmApellidoEmpleado";
            // 
            // clmPuesto
            // 
            this.clmPuesto.HeaderText = "Puesto";
            this.clmPuesto.MinimumWidth = 6;
            this.clmPuesto.Name = "clmPuesto";
            this.clmPuesto.Width = 80;
            // 
            // clmFechaIngreso
            // 
            this.clmFechaIngreso.HeaderText = "Fecha Ingreso";
            this.clmFechaIngreso.MinimumWidth = 6;
            this.clmFechaIngreso.Name = "clmFechaIngreso";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboNombreUsuario);
            this.Controls.Add(this.cboIdEmpleado);
            this.Controls.Add(this.cboNombreEmpleado);
            this.Controls.Add(this.cboPuesto);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.ComboBox cboNombreEmpleado;
        private System.Windows.Forms.ComboBox cboIdEmpleado;
        private System.Windows.Forms.ComboBox cboNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdUusario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaIngreso;
    }
}