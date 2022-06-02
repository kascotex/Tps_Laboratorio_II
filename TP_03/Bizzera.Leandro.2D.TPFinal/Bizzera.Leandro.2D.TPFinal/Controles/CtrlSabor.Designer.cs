
namespace Heladeria
{
    partial class CtrlSabor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlSabor));
            this.labelSabor = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSabor
            // 
            this.labelSabor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSabor.ForeColor = System.Drawing.Color.Black;
            this.labelSabor.Location = new System.Drawing.Point(0, 0);
            this.labelSabor.Name = "labelSabor";
            this.labelSabor.Size = new System.Drawing.Size(240, 70);
            this.labelSabor.TabIndex = 0;
            this.labelSabor.Text = "Sabor Del Helado";
            this.labelSabor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(215, 0);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(25, 25);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.Text = "X";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // CtrlSabor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelSabor);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CtrlSabor";
            this.Size = new System.Drawing.Size(240, 70);
            this.Load += new System.EventHandler(this.CtrlSabor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSabor;
        private System.Windows.Forms.Button buttonEliminar;
    }
}
