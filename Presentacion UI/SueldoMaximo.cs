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
    public partial class SueldoMaximo : UserControl
    {
        public SueldoMaximo()
        {
            InitializeComponent();

            BEunProfesor = new BEProfesor();
            BLLunProfesor = new BLLProfesor();
        }

        BEProfesor BEunProfesor;
        BLLProfesor BLLunProfesor;
        public void SueldoMayor()
        {
            string nombre = string.Empty;
            int maximo = 0;

            List<BEProfesor> listaProfesores = new List<BEProfesor>();
            listaProfesores = BLLunProfesor.ListarTodo();

            foreach (BEProfesor item in listaProfesores)
            {
                if (item.Sueldo > maximo)
                {
                    nombre = item.Nombre;
                    maximo = item.Sueldo;   
                }
            }

            MessageBox.Show($"El profesor con mayor sueldo es {nombre} con un sueldo de ${maximo}");
        }
        private void btnSocioSueldo_Click(object sender, EventArgs e)
        {
            SueldoMayor();
        }
    }
}
