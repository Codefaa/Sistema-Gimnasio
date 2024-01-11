using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidad_BE;
using Negocio_BLL;

namespace Presentacion_UI
{
    public partial class frmInforme : Form
    {
        public frmInforme()
        {
            InitializeComponent();

            BEunSocio = new BESocio();
            BLLunSocio = new BLLSocio();
        }

        BESocio BEunSocio;
        BLLSocio BLLunSocio;
        void MostrarGrilla()
        {
            grillaSocios.DataSource = null;
            grillaSocios.DataSource = BLLunSocio.ListarTodo();
        }
        private void btnBuscador_Click(object sender, EventArgs e)
        {
            BEunSocio.Nombre = txtNombre.Text;
            grillaSocios.DataSource = BLLunSocio.BuscarSocio(BEunSocio);
        }

        private void frmInforme_Load(object sender, EventArgs e)
        {
            MostrarGrilla();
        }

        private void btnContadorSocio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad de socios: " + BLLunSocio.ContadorSocios());
        }

        private void btnContadorProfesores_Click(object sender, EventArgs e)
        {
            BLLProfesor BLLunProfesor = new BLLProfesor();

            MessageBox.Show("Cantidad de profesores: " + BLLunProfesor.ContadorProfesores());
        }

        private void btnContadorActividades_Click(object sender, EventArgs e)
        {
            BLLActividad BLLunaActividad = new BLLActividad();

            MessageBox.Show("Cantidad de actividades: " + BLLunaActividad.ContadorActividades());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarGrilla();
        }

    }
}
