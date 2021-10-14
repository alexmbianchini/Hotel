using Hotel.Servicios;
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
    public partial class frmConsultaReservas : Form
    {
        ReservaService oReserva = new ReservaService();
        int numeroReserva = 0;
        public frmConsultaReservas()
        {
            InitializeComponent();
        }

        private void frmConsultaReservas_Load(object sender, EventArgs e)
        {
            CargarGrilla(dgvReserva, oReserva.RecuperarReservadas());
        }


        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_reserva"],
                                tabla.Rows[i]["pasaporte"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["fecha_hora_ingreso_estimada"],
                                tabla.Rows[i]["fecha_hora_salida_estimada"],
                                tabla.Rows[i]["numero_cochera"],
                                tabla.Rows[i]["cantidad_personas"]);
            }

        }

        private void dgvDetalleReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDetalle(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_detalle"],
                                tabla.Rows[i]["numero_habitacion"],
                                tabla.Rows[i]["tipo"],
                                tabla.Rows[i]["precio_unitario_habitacion"]);
            }

        }

        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numeroReserva = Convert.ToInt32(dgvReserva.CurrentRow.Cells[0].Value);

            CargarDetalle(dgvDetalleReserva, oReserva.RecueperarDetallesReservaEspecifica(numeroReserva));
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea Cancelar la reserva seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (oReserva.Cancelar(numeroReserva))
                {
                    MessageBox.Show("Reserva Cancelada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Cancelar la Reserva", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            CargarGrilla(dgvReserva, oReserva.RecuperarReservadas());
            dgvDetalleReserva.Rows.Clear();
  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

