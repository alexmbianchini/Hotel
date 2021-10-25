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
    public partial class frmIngresoPorTipoHabit : Form
    {
        // Objetos a utilizar
        ReservaService oReserva = new ReservaService();

        public frmIngresoPorTipoHabit()
        {
            InitializeComponent();
        }

        private void frmIngresoPorTipoHabit_Load(object sender, EventArgs e)
        {

            this.rwTipoHabit.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (oReserva.ValidarFechaDesdeMenorFechaHasta(dtpFechaDesde.Value, dtpFechaHasta.Value))
            {
                // Tomamos los datos para cargar el DataSet
                var datos = oReserva.RecuperarDatosTipoHabitacionReservada(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString());

                // Limpiamos el Reporte
                this.rwTipoHabit.LocalReport.DataSources.Clear();

                // Cargamos la Tabla con los datos que recuperamos
                var tablaTipoHMasReservada = new ReportDataSource("DSIngresosTipoHabit", datos);

                // Cargamos Reporte
                this.rwTipoHabit.LocalReport.DataSources.Add(tablaTipoHMasReservada);

                // Armamos Parámetros en Estructuras
                var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
                var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);

                var parametros = new List<ReportParameter>();
                parametros.Add(paramFechaHoy);

                // Cargamos Parámetros en el Reporte
                this.rwTipoHabit.LocalReport.SetParameters(parametros);

                this.rwTipoHabit.RefreshReport();
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
