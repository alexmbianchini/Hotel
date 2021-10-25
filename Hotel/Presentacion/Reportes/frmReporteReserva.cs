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
    public partial class frmReporteReserva : Form
    {
        //Objetos
        ReservaService oReserva = new ReservaService();
        public frmReporteReserva()
        {
            InitializeComponent();
        }

        private void frmReporteReserva_Load(object sender, EventArgs e)
        {

            this.rwReserva.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Tomamos los datos para cargar el DataSet
            var datos = oReserva.RecuperarDatosReservaReporte(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());
            
            // Limpiamos el Reporte
            this.rwReserva.LocalReport.DataSources.Clear();

            // Cargamos la Tabla con los datos que recuperamos
            var tablaReservas = new ReportDataSource("Reserva", datos);

            // Cargamos Reporte
            this.rwReserva.LocalReport.DataSources.Add(tablaReservas);

            // Armamos Parámetros en Estructuras
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("FechaEmision", fechaHoy);

            var parametros = new List<ReportParameter>();
            parametros.Add(paramFechaHoy);

            // Cargamos Parámetros en el Reporte
            this.rwReserva.LocalReport.SetParameters(parametros);

            this.rwReserva.RefreshReport();


        }
    }
}
