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

            if (oReserva.ValidarFechaDesdeMenorFechaHasta(dtpFechaDesde.Value, dtpFechaHasta.Value))
            {
                // Tomamos los datos para cargar el DataSet
                var datos = oReserva.RecuperarDatosReservaReporte(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());
                float total = 0;
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    total += Convert.ToSingle(datos.Rows[i]["cantidad_dias"]) * Convert.ToSingle(datos.Rows[i]["precio_unitario_habitacion"]);
                }

                // Limpiamos el Reporte
                this.rwReserva.LocalReport.DataSources.Clear();

                // Cargamos la Tabla con los datos que recuperamos
                var tablaReservas = new ReportDataSource("DSReservas", datos);

                // Cargamos Reporte
                this.rwReserva.LocalReport.DataSources.Add(tablaReservas);

                // Armamos Parámetros en Estructuras
                var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                var paramFechaHoy = new ReportParameter("FechaEmision", fechaHoy);
                var paramTotal = new ReportParameter("ParamTotal", total.ToString());

                var parametros = new List<ReportParameter>();
                parametros.Add(paramFechaHoy);
                parametros.Add(paramTotal);

                // Cargamos Parámetros en el Reporte
                this.rwReserva.LocalReport.SetParameters(parametros);

                this.rwReserva.RefreshReport();
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

        private void lblFechaHasta_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
