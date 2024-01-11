
namespace Presentacion_UI
{
    partial class frmActividad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTurnos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.comboProfesores = new System.Windows.Forms.ComboBox();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.numCodigo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaActividades = new System.Windows.Forms.DataGridView();
            this.precioMaximo1 = new Presentacion_UI.PrecioMaximo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTurnos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.numPrecio);
            this.groupBox1.Controls.Add(this.comboProfesores);
            this.groupBox1.Controls.Add(this.txtDeporte);
            this.groupBox1.Controls.Add(this.numCodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de las Actividades ";
            // 
            // comboTurnos
            // 
            this.comboTurnos.FormattingEnabled = true;
            this.comboTurnos.Location = new System.Drawing.Point(101, 104);
            this.comboTurnos.Name = "comboTurnos";
            this.comboTurnos.Size = new System.Drawing.Size(121, 21);
            this.comboTurnos.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Turno:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(228, 226);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(129, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 226);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(102, 146);
            this.numPrecio.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(54, 20);
            this.numPrecio.TabIndex = 8;
            // 
            // comboProfesores
            // 
            this.comboProfesores.FormattingEnabled = true;
            this.comboProfesores.Location = new System.Drawing.Point(101, 181);
            this.comboProfesores.Name = "comboProfesores";
            this.comboProfesores.Size = new System.Drawing.Size(121, 21);
            this.comboProfesores.TabIndex = 7;
            // 
            // txtDeporte
            // 
            this.txtDeporte.Location = new System.Drawing.Point(101, 60);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(121, 20);
            this.txtDeporte.TabIndex = 6;
            // 
            // numCodigo
            // 
            this.numCodigo.Enabled = false;
            this.numCodigo.Location = new System.Drawing.Point(101, 27);
            this.numCodigo.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(55, 20);
            this.numCodigo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Profesor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deporte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // grillaActividades
            // 
            this.grillaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaActividades.Location = new System.Drawing.Point(12, 279);
            this.grillaActividades.Name = "grillaActividades";
            this.grillaActividades.Size = new System.Drawing.Size(323, 150);
            this.grillaActividades.TabIndex = 1;
            this.grillaActividades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaActividades_CellContentClick);
            // 
            // precioMaximo1
            // 
            this.precioMaximo1.Location = new System.Drawing.Point(94, 435);
            this.precioMaximo1.Name = "precioMaximo1";
            this.precioMaximo1.Size = new System.Drawing.Size(140, 24);
            this.precioMaximo1.TabIndex = 2;
            // 
            // frmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 459);
            this.Controls.Add(this.precioMaximo1);
            this.Controls.Add(this.grillaActividades);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmActividad";
            this.Text = "frmActividad";
            this.Load += new System.EventHandler(this.frmActividad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.ComboBox comboProfesores;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.NumericUpDown numCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillaActividades;
        private System.Windows.Forms.ComboBox comboTurnos;
        private System.Windows.Forms.Label label5;
        private PrecioMaximo precioMaximo1;
    }
}