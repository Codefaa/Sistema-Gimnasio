
namespace Presentacion_UI
{
    partial class SueldoMaximo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSocioSueldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSocioSueldo
            // 
            this.btnSocioSueldo.Location = new System.Drawing.Point(0, 0);
            this.btnSocioSueldo.Name = "btnSocioSueldo";
            this.btnSocioSueldo.Size = new System.Drawing.Size(138, 23);
            this.btnSocioSueldo.TabIndex = 0;
            this.btnSocioSueldo.Text = "Sueldo Profesor";
            this.btnSocioSueldo.UseVisualStyleBackColor = true;
            this.btnSocioSueldo.Click += new System.EventHandler(this.btnSocioSueldo_Click);
            // 
            // SueldoMaximo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSocioSueldo);
            this.Name = "SueldoMaximo";
            this.Size = new System.Drawing.Size(139, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSocioSueldo;
    }
}
