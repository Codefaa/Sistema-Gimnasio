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
    public partial class frmSocioActividad : Form
    {
        public frmSocioActividad()
        {
            InitializeComponent();

            BEunSocio = new BESocio();
            BEunaActividad = new BEActividad();

            BLLunSocio = new BLLSocio();
            BLLunaActividad = new BLLActividad();
        }

        BESocio BEunSocio;
        BEActividad BEunaActividad;

        BLLSocio BLLunSocio;
        BLLActividad BLLunaActividad;

        void CargarComboSocios()
        {
            comboSocios.DataSource = null;
            comboSocios.DataSource = BLLunSocio.ListarTodo();

            comboSocios.ValueMember = "Codigo";
            comboSocios.DisplayMember = "Nombre";
            comboSocios.Refresh();
        }

        void CargarComboActividades()
        {
            comboActividades.DataSource = null;
            comboActividades.DataSource = BLLunaActividad.ListarTodo();

            comboActividades.ValueMember = "Codigo";
            comboActividades.DisplayMember = "Deporte";
            comboActividades.Refresh();
        }

        void MostrarGrilla()
        {
            BEunSocio = (BESocio)comboSocios.SelectedItem;

            BEunSocio.listaActividades = BLLunSocio.ActividadSocio(BEunSocio);

            grillaAsociacion.DataSource = BEunSocio.listaActividades;
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            try
            {
                BEunSocio = (BESocio)comboSocios.SelectedItem;
                BEunaActividad = (BEActividad)comboActividades.SelectedItem;

                if (BEunSocio.listaActividades != null)
                {
                    foreach (BEActividad item in BEunSocio.listaActividades)
                    {
                        if(BEunaActividad.Codigo == item.Codigo)
                        {
                            MessageBox.Show("La actividad ya esta asociada al socio");
                            break;
                        }
                        else
                        {
                            BLLunSocio.AgregarActividad(BEunSocio, BEunaActividad);

                            BLLunSocio.ListarTodo();

                            break;
                        }
                    }
                }
                else
                {
                    BLLunSocio.AgregarActividad(BEunSocio, BEunaActividad);

                    BLLunSocio.ListarTodo();
                }

                MostrarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesasociar_Click(object sender, EventArgs e)
        {
            try
            {
                if(BEunSocio.Codigo != 0 && BEunaActividad.Codigo != 0)
                {
                    BLLunSocio.QuitarActividad(BEunSocio, BEunaActividad);
                }
                else
                {
                    MessageBox.Show("ERROR - Seleccione una actividad de la grilla");
                }

                MostrarGrilla();
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSocioActividad_Load(object sender, EventArgs e)
        {
            CargarComboSocios();
            CargarComboActividades();
        }

        private void comboSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarGrilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grillaAsociacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEunaActividad = (BEActividad)grillaAsociacion.CurrentRow.DataBoundItem;
        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            int cuota = BLLunSocio.CalcularCuota(BEunSocio);
            double cuota_total = 0;

            if(BEunSocio.Pago == "Debito")
            {
                cuota_total = (cuota * 0.20) + cuota;
                MessageBox.Show($"El socio {BEunSocio.Nombre} tiene que pagar un total de: ${cuota_total}. Pago echo en debito, aumenta un 20%");
            }
            else if(BEunSocio.Pago == "Credito")
            {
                cuota_total = (cuota * 0.15) + cuota;
                MessageBox.Show($"El socio {BEunSocio.Nombre} tiene que pagar un total de: ${cuota_total}. Pago echo en credito, aumenta un 15%");
            }
            else
            {
                MessageBox.Show($"El socio {BEunSocio.Nombre} tiene que pagar un total de: ${cuota}. Pago echo en efectivo");
            }
        }
    }
}