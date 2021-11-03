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
    public partial class frmReporteReservaxHabit : Form
    {
        ReservaService oReserva = new ReservaService();
        public frmReporteReservaxHabit()
        {
            InitializeComponent();
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lblFechaDesde.ForeColor = Color.Black;
            lblFechaHasta.ForeColor = Color.Black;

            if (oReserva.ValidarFechaDesdeMenorFechaHasta(dtpFechaDesde.Value, dtpFechaHasta.Value))
            {
                var datos = oReserva.RecuperarDatosReservaCocheraXNroHabit(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());

                this.rwIngresoHabit.LocalReport.DataSources.Clear();

                var tablaResHabit = new ReportDataSource("DSReservasHabit", datos);

                this.rwIngresoHabit.LocalReport.DataSources.Add(tablaResHabit);

                var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                var paramFechaHoy = new ReportParameter("fechaHoy", fechaHoy);
                var fechaDesde = dtpFechaDesde.Value.ToString();
                var fechaHasta = dtpFechaHasta.Value.ToString();
                var paramFechaDesde = new ReportParameter("fechaDesde", fechaDesde);
                var paramFechaHasta = new ReportParameter("fechaHasta", fechaHasta);

                var parametros = new List<ReportParameter>();
                parametros.Add(paramFechaHoy);
                parametros.Add(paramFechaDesde);
                parametros.Add(paramFechaHasta);

                this.rwIngresoHabit.LocalReport.SetParameters(parametros);

                this.rwIngresoHabit.RefreshReport();
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

        private void frmReporteReservaxHabit_Load(object sender, EventArgs e)
        {
            this.rwIngresoHabit.RefreshReport();
        }
    }
}
