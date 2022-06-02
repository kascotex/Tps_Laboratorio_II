
namespace Heladeria
{
    partial class CtrlEmpleado
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.pictureBoxEmpleado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(77, 0);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(416, 50);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre, Apellido";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelId
            // 
            this.labelId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelId.Location = new System.Drawing.Point(500, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(130, 50);
            this.labelId.TabIndex = 1;
            this.labelId.Text = " ID: 0000";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxEmpleado
            // 
            this.pictureBoxEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmpleado.Name = "pictureBoxEmpleado";
            this.pictureBoxEmpleado.Size = new System.Drawing.Size(70, 50);
            this.pictureBoxEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpleado.TabIndex = 2;
            this.pictureBoxEmpleado.TabStop = false;
            // 
            // CtrlEmpleado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBoxEmpleado);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNombre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CtrlEmpleado";
            this.Size = new System.Drawing.Size(630, 50);
            this.Load += new System.EventHandler(this.CtrlEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.PictureBox pictureBoxEmpleado;
    }
}
