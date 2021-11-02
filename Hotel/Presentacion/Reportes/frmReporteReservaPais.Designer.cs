
namespace Hotel.Presentacion
{
    partial class frmReporteReservaPais
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
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.rwPaises = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnConsultar = new Hotel.Custom.RJButton();
            this.SuspendLayout();
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.Location = new System.Drawing.Point(175, 70);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(87, 19);
            this.lblFechaHasta.TabIndex = 9;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Location = new System.Drawing.Point(268, 64);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(254, 25);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.Location = new System.Drawing.Point(172, 18);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(90, 19);
            this.lblFechaDesde.TabIndex = 7;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(268, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(254, 25);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // rwPaises
            // 
            this.rwPaises.LocalReport.ReportEmbeddedResource = "Hotel.Reportes.ReporteReservasXPais.rdlc";
            this.rwPaises.Location = new System.Drawing.Point(2, 109);
            this.rwPaises.Name = "rwPaises";
            this.rwPaises.ServerReport.BearerToken = null;
            this.rwPaises.Size = new System.Drawing.Size(822, 449);
            this.rwPaises.TabIndex = 11;
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
            this.btnConsultar.Location = new System.Drawing.Point(593, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 41);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextColor = System.Drawing.Color.White;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmReporteReservaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(209)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.rwPaises);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmReporteReservaPais";
            this.Text = "frmReporteReservaPais";
            this.Load += new System.EventHandler(this.frmReporteReservaPais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.RJButton btnConsultar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Microsoft.Reporting.WinForms.ReportViewer rwPaises;
    }
}