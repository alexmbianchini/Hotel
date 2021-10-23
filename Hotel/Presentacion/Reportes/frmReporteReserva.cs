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
        public frmReporteReserva()
        {
            InitializeComponent();
        }

        private void frmReporteReserva_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ReportDataSource reservas = new ReportDataSource("DSReservas", );
        }
    }
}
