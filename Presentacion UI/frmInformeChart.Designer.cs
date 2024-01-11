
namespace Presentacion_UI
{
    partial class frmInformeChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartProfesores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartActividad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sueldoMaximo1 = new Presentacion_UI.SueldoMaximo();
            this.precioMaximo1 = new Presentacion_UI.PrecioMaximo();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sueldoMaximo1);
            this.groupBox2.Controls.Add(this.chartProfesores);
            this.groupBox2.Controls.Add(this.chart3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 367);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de los profesores";
            // 
            // chartProfesores
            // 
            chartArea1.Name = "ChartArea1";
            this.chartProfesores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProfesores.Legends.Add(legend1);
            this.chartProfesores.Location = new System.Drawing.Point(19, 15);
            this.chartProfesores.Name = "chartProfesores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProfesores.Series.Add(series1);
            this.chartProfesores.Size = new System.Drawing.Size(300, 300);
            this.chartProfesores.TabIndex = 2;
            this.chartProfesores.Text = "chart2";
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(15, 19);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(300, 300);
            this.chart3.TabIndex = 1;
            this.chart3.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precioMaximo1);
            this.groupBox1.Controls.Add(this.chartActividad);
            this.groupBox1.Location = new System.Drawing.Point(371, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 367);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de las Actividades";
            // 
            // chartActividad
            // 
            chartArea3.Name = "ChartArea1";
            this.chartActividad.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartActividad.Legends.Add(legend3);
            this.chartActividad.Location = new System.Drawing.Point(15, 19);
            this.chartActividad.Name = "chartActividad";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartActividad.Series.Add(series3);
            this.chartActividad.Size = new System.Drawing.Size(300, 300);
            this.chartActividad.TabIndex = 1;
            this.chartActividad.Text = "chart1";
            // 
            // sueldoMaximo1
            // 
            this.sueldoMaximo1.Location = new System.Drawing.Point(81, 326);
            this.sueldoMaximo1.Name = "sueldoMaximo1";
            this.sueldoMaximo1.Size = new System.Drawing.Size(139, 23);
            this.sueldoMaximo1.TabIndex = 3;
            // 
            // precioMaximo1
            // 
            this.precioMaximo1.Location = new System.Drawing.Point(98, 326);
            this.precioMaximo1.Name = "precioMaximo1";
            this.precioMaximo1.Size = new System.Drawing.Size(140, 24);
            this.precioMaximo1.TabIndex = 2;
            // 
            // frmInformeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmInformeChart";
            this.Text = "frmInformeChart";
            this.Load += new System.EventHandler(this.frmInformeChart_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartActividad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProfesores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private SueldoMaximo sueldoMaximo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActividad;
        private PrecioMaximo precioMaximo1;
    }
}