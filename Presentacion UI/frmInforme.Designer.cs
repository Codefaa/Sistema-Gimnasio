
namespace Presentacion_UI
{
    partial class frmInforme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.btnContadorActividades = new System.Windows.Forms.Button();
            this.btnContadorProfesores = new System.Windows.Forms.Button();
            this.btnContadorSocio = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grillaSocios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscador:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Ingrese el nombre del socio";
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(327, 14);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(89, 29);
            this.btnBuscador.TabIndex = 2;
            this.btnBuscador.Text = "Buscar socio";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // btnContadorActividades
            // 
            this.btnContadorActividades.Location = new System.Drawing.Point(339, 233);
            this.btnContadorActividades.Name = "btnContadorActividades";
            this.btnContadorActividades.Size = new System.Drawing.Size(138, 23);
            this.btnContadorActividades.TabIndex = 3;
            this.btnContadorActividades.Text = "Contador de actividades";
            this.btnContadorActividades.UseVisualStyleBackColor = true;
            this.btnContadorActividades.Click += new System.EventHandler(this.btnContadorActividades_Click);
            // 
            // btnContadorProfesores
            // 
            this.btnContadorProfesores.Location = new System.Drawing.Point(178, 233);
            this.btnContadorProfesores.Name = "btnContadorProfesores";
            this.btnContadorProfesores.Size = new System.Drawing.Size(138, 23);
            this.btnContadorProfesores.TabIndex = 4;
            this.btnContadorProfesores.Text = "Contador de profesores";
            this.btnContadorProfesores.UseVisualStyleBackColor = true;
            this.btnContadorProfesores.Click += new System.EventHandler(this.btnContadorProfesores_Click);
            // 
            // btnContadorSocio
            // 
            this.btnContadorSocio.Location = new System.Drawing.Point(14, 233);
            this.btnContadorSocio.Name = "btnContadorSocio";
            this.btnContadorSocio.Size = new System.Drawing.Size(138, 23);
            this.btnContadorSocio.TabIndex = 5;
            this.btnContadorSocio.Text = "Contador de socios";
            this.btnContadorSocio.UseVisualStyleBackColor = true;
            this.btnContadorSocio.Click += new System.EventHandler(this.btnContadorSocio_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(452, 272);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.btnBuscador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informes";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(422, 14);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 29);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar lista";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grillaSocios
            // 
            this.grillaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSocios.Location = new System.Drawing.Point(13, 77);
            this.grillaSocios.Name = "grillaSocios";
            this.grillaSocios.Size = new System.Drawing.Size(514, 150);
            this.grillaSocios.TabIndex = 8;
            // 
            // frmInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 307);
            this.Controls.Add(this.grillaSocios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnContadorActividades);
            this.Controls.Add(this.btnContadorProfesores);
            this.Controls.Add(this.btnContadorSocio);
            this.Name = "frmInforme";
            this.Text = "frmInforme";
            this.Load += new System.EventHandler(this.frmInforme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button btnContadorActividades;
        private System.Windows.Forms.Button btnContadorProfesores;
        private System.Windows.Forms.Button btnContadorSocio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaSocios;
        private System.Windows.Forms.Button btnActualizar;
    }
}