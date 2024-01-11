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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion_UI
{
    public partial class frmInformeChart : Form
    {
        public frmInformeChart()
        {
            InitializeComponent();


            BLLunaActividad = new BLLActividad();


            BLLunProfesor = new BLLProfesor();
        }


        BLLProfesor BLLunProfesor;
         

        BLLActividad BLLunaActividad;
        void MostrarChartActividad()
        {
            Dictionary<string, double> listaActividades = new Dictionary<string, double>();

            foreach (BEActividad item in BLLunaActividad.ListarTodo())
            {
                BEActividad unaActividad = new BEActividad();
                unaActividad = item;
                listaActividades.Add(unaActividad.Deporte, unaActividad.Precio);
            }

            chartActividad.Titles.Clear();
            chartActividad.ChartAreas.Clear();
            chartActividad.Series.Clear();

            Title titulo = new Title("Grafico del precio de las actividades");
            titulo.Font = new Font("Tahoma", 20, FontStyle.Bold);
            chartActividad.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chartActividad.ChartAreas.Add(area);

            Series serie = new Series("Precio");
            serie.ChartType = SeriesChartType.Pie;
            serie.Points.DataBindXY(listaActividades.Keys, listaActividades.Values);

            chartActividad.Series.Add(serie);
        }

        void MostrarChartProfesores()
        {
            Dictionary<string, double> listaProfesores = new Dictionary<string, double>();

            foreach (BEProfesor item in BLLunProfesor.ListarTodo())
            {
                BEProfesor unProfesor = new BEProfesor();
                unProfesor = item;
                listaProfesores.Add(unProfesor.Nombre, unProfesor.Sueldo);
            }

            chartProfesores.Titles.Clear();
            chartProfesores.ChartAreas.Clear();
            chartProfesores.Series.Clear();

            Title titulo = new Title("Grafico del sueldo de los profesores");
            titulo.Font = new Font("Tahoma", 20, FontStyle.Bold);
            chartProfesores.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.Area3DStyle.Enable3D = true;
            chartProfesores.ChartAreas.Add(area);

            Series serie = new Series("Sueldo");
            serie.ChartType = SeriesChartType.Column;
            serie.Points.DataBindXY(listaProfesores.Keys, listaProfesores.Values);
            chartProfesores.Series.Add(serie);
        }
        private void frmInformeChart_Load(object sender, EventArgs e)
        {
            MostrarChartActividad();

            MostrarChartProfesores();
        }
    }
}
