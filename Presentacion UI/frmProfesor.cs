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
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();

            BEunProfesor = new BEProfesor();
            BLLunProfesor = new BLLProfesor();
        }

        BEProfesor BEunProfesor;
        BLLProfesor BLLunProfesor;
        void MostrarGrilla()
        {
            grillaProfesores.DataSource = null;
            grillaProfesores.DataSource = BLLunProfesor.ListarTodo();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool respuesta = Regex.IsMatch(txtNombre.Text, "^([A-Z]{1}[a-z]+)");
                bool respuesta2 = Regex.IsMatch(txtApellido.Text, "^([A-Z]{1}[a-z]+)");
                bool respuesta3 = Regex.IsMatch(numSueldo.Text, "^([1-9]+)");

                if (respuesta == false || respuesta2 == false || respuesta3 == false)
                {
                    MessageBox.Show("Escribio mal");
                }
                else
                {
                    BEunProfesor.Nombre = txtNombre.Text;
                    BEunProfesor.Apellido = txtApellido.Text;
                    BEunProfesor.FechaNac = dateFechaNac.Value;
                    txtEdad.Text = BEunProfesor.CalcularEdad().ToString();
                    BEunProfesor.Sueldo = Convert.ToInt32(numSueldo.Value);

                    BLLunProfesor.Guardar(BEunProfesor);

                    MostrarGrilla();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(BLLunProfesor.Baja(BEunProfesor) == false)
                {
                    MessageBox.Show("ERROR - El profesor esta asociado a una actividad");
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
                BEunProfesor.Codigo = Convert.ToInt32(numCodigo.Value);
                BEunProfesor.Nombre = txtNombre.Text;
                BEunProfesor.Apellido = txtApellido.Text;
                BEunProfesor.FechaNac = dateFechaNac.Value;
                txtEdad.Text = BEunProfesor.CalcularEdad().ToString();
                BEunProfesor.Sueldo = Convert.ToInt32(numSueldo.Value);

                BLLunProfesor.Guardar(BEunProfesor);

                MostrarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            MostrarGrilla();
        }

        private void grillaProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEunProfesor = (BEProfesor)grillaProfesores.CurrentRow.DataBoundItem;

            numCodigo.Value = BEunProfesor.Codigo;
            txtNombre.Text = BEunProfesor.Nombre;
            txtApellido.Text = BEunProfesor.Apellido;
            dateFechaNac.Value = BEunProfesor.FechaNac;
            txtEdad.Text = BEunProfesor.CalcularEdad().ToString();
            numSueldo.Value = BEunProfesor.Sueldo;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            BESocio unSocio = new BESocio();

            MessageBox.Show(BLLunProfesor.ImprimirPersona(unSocio, BEunProfesor));
        }
    }
}
