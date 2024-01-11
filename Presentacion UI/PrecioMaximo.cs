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
    public partial class PrecioMaximo : UserControl
    {
        public PrecioMaximo()
        {
            InitializeComponent();

            BEunaActividad = new BEActividad();
            BLLunaActividad = new BLLActividad();
        }

        BEActividad BEunaActividad;
        BLLActividad BLLunaActividad;
        public void PrecioMayor()
        {
            string deporte = string.Empty;
            int maximo = 0;

            List<BEActividad> listaActividades = new List<BEActividad>();
            listaActividades = BLLunaActividad.ListarTodo();

            foreach (BEActividad item in listaActividades)
            {
                if (item.Precio > maximo)
                {
                    deporte = item.Deporte;
                    maximo = item.Precio;
                }
            }

            MessageBox.Show($"La actividad mas cara es {deporte} con un precio de ${maximo}");
        }
        private void btnActividadPrecio_Click(object sender, EventArgs e)
        {
            PrecioMayor();
        }
    }
}
