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
    public partial class frmReporteRoomService : Form
    {
        DetalleServicioCuentaService oDetalle = new DetalleServicioCuentaService();
        ComboBoxService oComboBox = new ComboBoxService();
        MenuService oMenu = new MenuService();
        public frmReporteRoomService()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmReporteRoomService_Load(object sender, EventArgs e)
        {
            oComboBox.CargarCombo(cboProducto, oMenu.RecuperarTodos(), "descripcion", "codigo_producto");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int producto = cboProducto.SelectedIndex + 1;

            
            var datos = oDetalle.RecuperarDatosInforme(dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString(), producto);

            if (datos.Rows.Count < 1)
            {
                cboProducto.SelectedIndex = -1;
            }

            int total = 0;

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                total += Convert.ToInt32(datos.Rows[i]["precio_unitario"]);
            }

            this.repRoomService.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DSRoomService", datos);

            this.repRoomService.LocalReport.DataSources.Add(ds);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");


            var paramTotal = new ReportParameter("ParamTotal", total.ToString());
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            var paramFechaDesde = new ReportParameter("ParamFechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy"));
            var paramFechaHasta = new ReportParameter("ParamFechaHasta", dtpFechaHasta.Value.ToString("dd/MM/yyyy"));


            var parametros = new List<ReportParameter>();

            parametros.Add(paramFechaHoy);
            parametros.Add(paramFechaDesde);
            parametros.Add(paramFechaHasta);
            parametros.Add(paramTotal);

            this.repRoomService.LocalReport.SetParameters(parametros);

            this.repRoomService.RefreshReport();

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
