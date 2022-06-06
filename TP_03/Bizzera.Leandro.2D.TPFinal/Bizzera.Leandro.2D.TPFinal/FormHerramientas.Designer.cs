
namespace Heladeria
{
    partial class FormHerramientas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHerramientas));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctrlOpciones = new Heladeria.CtrlOpciones();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.buttonCargarClientes = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // ctrlOpciones
            // 
            this.ctrlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.ctrlOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctrlOpciones.Location = new System.Drawing.Point(0, 0);
            this.ctrlOpciones.Name = "ctrlOpciones";
            this.ctrlOpciones.Size = new System.Drawing.Size(140, 600);
            this.ctrlOpciones.TabIndex = 8;
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(319, 67);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(167, 83);
            this.buttonGuardarClientes.TabIndex = 9;
            this.buttonGuardarClientes.Text = "Guardar \r\nClientes";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            this.buttonGuardarClientes.Click += new System.EventHandler(this.ButtonGuardarClientes_Click);
            // 
            // buttonCargarClientes
            // 
            this.buttonCargarClientes.Location = new System.Drawing.Point(518, 67);
            this.buttonCargarClientes.Name = "buttonCargarClientes";
            this.buttonCargarClientes.Size = new System.Drawing.Size(167, 83);
            this.buttonCargarClientes.TabIndex = 10;
            this.buttonCargarClientes.Text = "Cargar \r\nClientes";
            this.buttonCargarClientes.UseVisualStyleBackColor = true;
            this.buttonCargarClientes.Click += new System.EventHandler(this.ButtonCargarClientes_Click);
            // 
            // FormHerramientas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.buttonCargarClientes);
            this.Controls.Add(this.buttonGuardarClientes);
            this.Controls.Add(this.ctrlOpciones);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramientas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHerramientas_FormClosing);
            this.Load += new System.EventHandler(this.FormHerramientas_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private CtrlOpciones ctrlOpciones;
        private System.Windows.Forms.Button buttonGuardarClientes;
        private System.Windows.Forms.Button buttonCargarClientes;
    }
}

