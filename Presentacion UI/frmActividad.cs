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
using System.Text.RegularExpressions;

namespace Presentacion_UI
{
    public partial class frmActividad : Form
    {
        public frmActividad()
        {
            InitializeComponent();

            BEunaActividad = new BEActividad();
            BLLunaActividad = new BLLActividad();

            BLLunProfesor = new BLLProfesor();
        }

        BEActividad BEunaActividad;
        BLLActividad BLLunaActividad;

        BLLProfesor BLLunProfesor;
        enum Turnos
        {
            Manana,
            Tarde,
            Noche,
            Libre,
        }
        void MostrarGrilla()
        {
            grillaActividades.DataSource = null;
            grillaActividades.DataSource = BLLunaActividad.ListarTodo();
        }
        void CargarComboProfesores()
        {
            comboProfesores.DataSource = null;
            comboProfesores.DataSource = BLLunProfesor.ListarTodo();

            comboProfesores.ValueMember = "Codigo";
            comboProfesores.DisplayMember = "Nombre";
            comboProfesores.Refresh();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta1 = Regex.IsMatch(txtDeporte.Text, "^([A-Z]{1}[a-z]+)");
                bool respuesta2 = Regex.IsMatch(numPrecio.Value.ToString(), "^([1-9]+)");

                if (respuesta1 == false || respuesta2 == false)
                {
                    MessageBox.Show("ERROR");
                }
                else
                {
                    BEunaActividad.Deporte = txtDeporte.Text;
                    BEunaActividad.Precio = Convert.ToInt32(numPrecio.Value);
                    BEunaActividad.Turno = comboTurnos.SelectedItem.ToString();
                    BEunaActividad.unProfesor = (BEProfesor)comboProfesores.SelectedItem;

                    BLLunaActividad.Guardar(BEunaActividad);

                    MostrarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(BLLunaActividad.Baja(BEunaActividad) == false)
                {
                    MessageBox.Show("ERROR - Esta actividad esta asociada a un Socio");
                }
                else
                {
                    MostrarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BEunaActividad.Codigo = Convert.ToInt32(numCodigo.Value);
                BEunaActividad.Deporte = txtDeporte.Text;
                BEunaActividad.Precio = Convert.ToInt32(numPrecio.Value);
                BEunaActividad.Turno = comboTurnos.SelectedItem.ToString();
                BEunaActividad.unProfesor = (BEProfesor)comboProfesores.SelectedItem;

                BLLunaActividad.Guardar(BEunaActividad);

                MostrarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmActividad_Load(object sender, EventArgs e)
        {
            comboTurnos.DataSource = Enum.GetValues(typeof(Turnos));

            CargarComboProfesores();
            MostrarGrilla();
        }

        private void grillaActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEunaActividad = (BEActividad)grillaActividades.CurrentRow.DataBoundItem;

            numCodigo.Value = BEunaActividad.Codigo;
            txtDeporte.Text = BEunaActividad.Deporte;
            numPrecio.Value = BEunaActividad.Precio;
            comboTurnos.Text = BEunaActividad.Turno;
            comboProfesores.Text = BEunaActividad.unProfesor.Nombre;
        }
    }
}
