using Hotel.Servicios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Presentacion
{
    public partial class frmReporteReservaPais : Form
    {
        ReservaService oReserva = new ReservaService();
        public frmReporteReservaPais()
        {
            InitializeComponent();
        }

        private void frmReporteReservaPais_Load(object sender, EventArgs e)
        {

            this.rwPaises.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(oReserva.ValidarFechaDesdeMenorFechaHasta(dtpFechaDesde.Value, dtpFechaHasta.Value))
            {
                var datos = oReserva.RecuperarParaReportePaises(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());

                this.rwPaises.LocalReport.DataSources.Clear();

                var tablaResPaises = new ReportDataSource("DSPaises", datos);

                this.rwPaises.LocalReport.DataSources.Add(tablaResPaises);

                var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                var paramFechaHoy = new ReportParameter("fechaEmision", fechaHoy);
                
                var parametros = new List<ReportParameter>();
                parametros.Add(paramFechaHoy);

                this.rwPaises.LocalReport.SetParameters(parametros);

                this.rwPaises.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe ingresar un rango de fechas válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaDesde.Focus();
                lblFechaDesde.ForeColor = Color.Red;
                lblFechaHasta.ForeColor = Color.Red;
                dtpFechaDesde.Value = DateTime.Today;
                dtpFechaHasta.Value = DateTime.Today;
            }
        }
    }
}
