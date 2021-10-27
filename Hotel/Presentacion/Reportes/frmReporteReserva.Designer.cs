
using System;


namespace Hotel.Presentacion
{
    partial class frmReporteReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteReserva));
            this.rwReserva = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.SuspendLayout();
            // 
            // rwReserva
            // 
            this.rwReserva.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwReserva.LocalReport.ReportEmbeddedResource = "Hotel.Presentacion.Reportes.ReportReservas.rdlc";
            this.rwReserva.Location = new System.Drawing.Point(12, 138);
            this.rwReserva.Name = "rwReserva";
            this.rwReserva.ServerReport.BearerToken = null;
            this.rwReserva.Size = new System.Drawing.Size(768, 439);
            this.rwReserva.TabIndex = 0;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(236, 27);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(254, 25);
            this.dtpFechaDesde.TabIndex = 1;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(140, 33);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(90, 19);
            this.lblFechaDesde.TabIndex = 2;
            this.lblFechaDesde.Text = "Fecha Desde:";
            this.lblFechaDesde.Click += new System.EventHandler(this.lblFechaDesde_Click);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(143, 85);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(87, 19);
            this.lblFechaHasta.TabIndex = 4;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            this.lblFechaHasta.Click += new System.EventHandler(this.lblFechaHasta_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Location = new System.Drawing.Point(236, 79);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(254, 25);
            this.dtpFechaHasta.TabIndex = 3;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnConsultar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnConsultar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConsultar.BorderRadius = 18;
            this.btnConsultar.BorderSize = 0;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(561, 45);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 41);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmReporteReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(797, 589);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.rwReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReporteReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReporteReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rwReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Custom.RJButton btnConsultar;
    }
}