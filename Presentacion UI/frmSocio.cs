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
    public partial class frmSocio : Form
    {
        public frmSocio()
        {
            InitializeComponent();

            BEunSocio = new BESocio();
            BLLunSocio = new BLLSocio();
        }

        BESocio BEunSocio;
        BLLSocio BLLunSocio;
        enum pago
        {
            Credito,
            Debito,
            Efectivo,
        }
        void MostrarGrilla()
        {
            grillaSocios.DataSource = null;
            grillaSocios.DataSource = BLLunSocio.ListarTodo();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEunSocio.Nombre = txtNombre.Text;
                BEunSocio.Apellido = txtApellido.Text;
                BEunSocio.FechaNac = dateFechaNac.Value;
                BEunSocio.Pago = comboPagos.Text;

                BLLunSocio.Guardar(BEunSocio);

                MostrarGrilla();
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
                BEunSocio.Codigo = Convert.ToInt32(numCodigo.Value);

                BLLunSocio.Baja(BEunSocio);

                MostrarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                BEunSocio.Codigo = Convert.ToInt32(numCodigo.Value);
                BEunSocio.Nombre = txtNombre.Text;
                BEunSocio.Apellido = txtApellido.Text;
                BEunSocio.FechaNac = dateFechaNac.Value;
                BEunSocio.Pago = comboPagos.Text;

                BLLunSocio.Guardar(BEunSocio);

                MostrarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            comboPagos.DataSource = Enum.GetValues(typeof(pago));

            MostrarGrilla();
        }

        private void grillaSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEunSocio = (BESocio)grillaSocios.CurrentRow.DataBoundItem;

            numCodigo.Value = BEunSocio.Codigo;
            txtNombre.Text = BEunSocio.Nombre;
            txtApellido.Text = BEunSocio.Apellido;
            dateFechaNac.Value = BEunSocio.FechaNac;
            comboPagos.Text = BEunSocio.Pago;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            BEProfesor unProfesor = new BEProfesor();

            MessageBox.Show(BLLunSocio.ImprimirPersona(BEunSocio, unProfesor));
        }
    }
}
