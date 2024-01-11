using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesor abrir = new frmProfesor();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActividad abrir = new frmActividad();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void socioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocio abrir = new frmSocio();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void asociarSocioYActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocioActividad abrir = new frmSocioActividad();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void informeDelGymToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInforme abrir = new frmInforme();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucursal abrir = new frmSucursal();
            abrir.MdiParent = this;
            abrir.Show();
        }

        private void informesChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformeChart abrir = new frmInformeChart();
            abrir.MdiParent = this;
            abrir.Show();
        }
    }
}
