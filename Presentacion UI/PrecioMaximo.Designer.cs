
namespace Presentacion_UI
{
    partial class PrecioMaximo
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
            this.btnActividadPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActividadPrecio
            // 
            this.btnActividadPrecio.Location = new System.Drawing.Point(0, 0);
            this.btnActividadPrecio.Name = "btnActividadPrecio";
            this.btnActividadPrecio.Size = new System.Drawing.Size(139, 23);
            this.btnActividadPrecio.TabIndex = 0;
            this.btnActividadPrecio.Text = "Precio Actividad";
            this.btnActividadPrecio.UseVisualStyleBackColor = true;
            this.btnActividadPrecio.Click += new System.EventHandler(this.btnActividadPrecio_Click);
            // 
            // PrecioMaximo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnActividadPrecio);
            this.Name = "PrecioMaximo";
            this.Size = new System.Drawing.Size(140, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActividadPrecio;
    }
}
