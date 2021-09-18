using Hotel.Negocio;
using Hotel.Presentacion.UsuarioEmpleado;
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
    public partial class frmPrincipal : Form
    {
        Empleado oEmpleadoSelected = new Empleado();

        
        frmLogin fLog = new frmLogin();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            fLog.ShowDialog();


            if (fLog.MiUsuarioSelected.Id == 0)
            {
                this.Close();
            }
            else
            {
                this.Text += " - Usuario: " + fLog.MiUsuarioSelected.Nombre;

                
            }


            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario fru = new frmUsuario();
            fru.ShowDialog();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            frmHabitacion frh = new frmHabitacion();
            frh.ShowDialog();
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            frmPassword frmP = new frmPassword(fLog.MiUsuarioSelected.Id);
            frmP.ShowDialog();
        }
    }
}
