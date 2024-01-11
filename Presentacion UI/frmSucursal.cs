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
using System.Xml.Linq;

namespace Presentacion_UI
{
    public partial class frmSucursal : Form
    {
        public frmSucursal()
        {
            InitializeComponent();

            BEunaSucursal = new BESucursal();
            BLLunaSucursal = new BLLSucursal();

        }
        BESucursal BEunaSucursal;
        BLLSucursal BLLunaSucursal;
        void MostrarGrilla()
        {
            grillaSucursales.DataSource = null;
            grillaSucursales.DataSource = BLLunaSucursal.LeerXML();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                BEunaSucursal.CodigoSucursal = Convert.ToInt32(txtCodigo.Text.Trim());
                BEunaSucursal.NombreSucursal = txtNombre.Text.Trim();
                BEunaSucursal.DireccionSucursal = txtDireccion.Text.Trim();
                BEunaSucursal.TelefonoSucursal = txtTelefono.Text.Trim();

                BLLunaSucursal.AgregarXML(BEunaSucursal);

                MostrarGrilla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                BLLunaSucursal.BorrarXML(BEunaSucursal);

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
                BEunaSucursal.CodigoSucursal = Convert.ToInt32(txtCodigo.Text.Trim());
                BEunaSucursal.NombreSucursal = txtNombre.Text.Trim();
                BEunaSucursal.DireccionSucursal = txtDireccion.Text.Trim();
                BEunaSucursal.TelefonoSucursal = txtTelefono.Text.Trim();

                BLLunaSucursal.ModificarXML(BEunaSucursal);

                MostrarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BuscardDireccion(txtBuscarDireccion.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void BuscardDireccion(string direccion)
        {
            grillaSucursales.DataSource = null;
            grillaSucursales.DataSource = BLLunaSucursal.BuscarXML(direccion);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BEunaSucursal = (BESucursal)grillaSucursales.CurrentRow.DataBoundItem;

            txtCodigo.Text = BEunaSucursal.CodigoSucursal.ToString();
            txtNombre.Text = BEunaSucursal.NombreSucursal;
            txtDireccion.Text = BEunaSucursal.DireccionSucursal;
            txtTelefono.Text = BEunaSucursal.TelefonoSucursal;
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            MostrarGrilla();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarGrilla();
        }
    }
}
