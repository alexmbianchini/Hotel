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

namespace Hotel.Presentacion.Reportes
{
    public partial class frmReporteCochera : Form
    {
        ReservaService oReserva = new ReservaService();


        public frmReporteCochera()
        {
            InitializeComponent();
        }

        private void frmReporteCochera_Load(object sender, EventArgs e)
        {

            this.repCochera.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var datos = oReserva.RecuperarDatosReservaCochera(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());

            float total = 0;

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                if (!String.IsNullOrEmpty(datos.Rows[i]["precio_unitario_cochera"].ToString()))
                {
                    total += Convert.ToSingle(datos.Rows[i]["cantidad_dias"]) * Convert.ToSingle(datos.Rows[i]["precio_unitario_cochera"]);
                }
            }

            this.repCochera.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DSCocheras", datos);

            this.repCochera.LocalReport.DataSources.Add(ds);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");


            var paramTotal = new ReportParameter("ParamTotal", total.ToString());
            var paramFechaHoy = new ReportParameter("ParamFecha", fechaHoy);
            var paramFechaDesde = new ReportParameter("ParamDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy"));
            var paramFechaHasta = new ReportParameter("ParamHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy"));


            var parametros = new List<ReportParameter>();

            parametros.Add(paramFechaHoy);
            parametros.Add(paramFechaDesde);
            parametros.Add(paramFechaHasta);
            parametros.Add(paramTotal);

            this.repCochera.LocalReport.SetParameters(parametros);

            this.repCochera.RefreshReport();
        }
    }
}
