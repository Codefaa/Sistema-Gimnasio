
namespace Presentacion_UI
{
    partial class frmSocioActividad
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
            this.btnAsociar = new System.Windows.Forms.Button();
            this.btnDesasociar = new System.Windows.Forms.Button();
            this.comboActividades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboSocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaAsociacion = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCuota = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAsociacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsociar);
            this.groupBox1.Controls.Add(this.btnDesasociar);
            this.groupBox1.Controls.Add(this.comboActividades);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboSocios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asociar socio a Actividades";
            // 
            // btnAsociar
            // 
            this.btnAsociar.Location = new System.Drawing.Point(288, 71);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(75, 23);
            this.btnAsociar.TabIndex = 5;
            this.btnAsociar.Text = "Asociar";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // btnDesasociar
            // 
            this.btnDesasociar.Location = new System.Drawing.Point(367, 71);
            this.btnDesasociar.Name = "btnDesasociar";
            this.btnDesasociar.Size = new System.Drawing.Size(75, 23);
            this.btnDesasociar.TabIndex = 2;
            this.btnDesasociar.Text = "Desasociar";
            this.btnDesasociar.UseVisualStyleBackColor = true;
            this.btnDesasociar.Click += new System.EventHandler(this.btnDesasociar_Click);
            // 
            // comboActividades
            // 
            this.comboActividades.FormattingEnabled = true;
            this.comboActividades.Location = new System.Drawing.Point(94, 56);
            this.comboActividades.Name = "comboActividades";
            this.comboActividades.Size = new System.Drawing.Size(121, 21);
            this.comboActividades.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Actividades:";
            // 
            // comboSocios
            // 
            this.comboSocios.FormattingEnabled = true;
            this.comboSocios.Location = new System.Drawing.Point(94, 29);
            this.comboSocios.Name = "comboSocios";
            this.comboSocios.Size = new System.Drawing.Size(121, 21);
            this.comboSocios.TabIndex = 1;
            this.comboSocios.SelectedIndexChanged += new System.EventHandler(this.comboSocios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Socios:";
            // 
            // grillaAsociacion
            // 
            this.grillaAsociacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAsociacion.Location = new System.Drawing.Point(12, 118);
            this.grillaAsociacion.Name = "grillaAsociacion";
            this.grillaAsociacion.Size = new System.Drawing.Size(448, 150);
            this.grillaAsociacion.TabIndex = 1;
            this.grillaAsociacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaAsociacion_CellContentClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(379, 274);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCuota
            // 
            this.btnCuota.Location = new System.Drawing.Point(106, 274);
            this.btnCuota.Name = "btnCuota";
            this.btnCuota.Size = new System.Drawing.Size(214, 23);
            this.btnCuota.TabIndex = 3;
            this.btnCuota.Text = "Calcular cuota";
            this.btnCuota.UseVisualStyleBackColor = true;
            this.btnCuota.Click += new System.EventHandler(this.btnCuota_Click);
            // 
            // frmSocioActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 302);
            this.Controls.Add(this.btnCuota);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grillaAsociacion);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSocioActividad";
            this.Text = "frmSocioActividad";
            this.Load += new System.EventHandler(this.frmSocioActividad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAsociacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDesasociar;
        private System.Windows.Forms.ComboBox comboSocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.ComboBox comboActividades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grillaAsociacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCuota;
    }
}