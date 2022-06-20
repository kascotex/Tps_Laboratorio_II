
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
            this.buttonExportarClientes = new System.Windows.Forms.Button();
            this.buttonImportarClientes = new System.Windows.Forms.Button();
            this.listboxPedidos = new System.Windows.Forms.ListBox();
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
            // buttonExportarClientes
            // 
            this.buttonExportarClientes.Location = new System.Drawing.Point(319, 67);
            this.buttonExportarClientes.Name = "buttonExportarClientes";
            this.buttonExportarClientes.Size = new System.Drawing.Size(150, 100);
            this.buttonExportarClientes.TabIndex = 9;
            this.buttonExportarClientes.Text = "Exportar\r\nla lista de\r\nSabores";
            this.buttonExportarClientes.UseVisualStyleBackColor = true;
            this.buttonExportarClientes.Click += new System.EventHandler(this.ButtonExportarClientes_Click);
            // 
            // buttonImportarClientes
            // 
            this.buttonImportarClientes.Location = new System.Drawing.Point(518, 67);
            this.buttonImportarClientes.Name = "buttonImportarClientes";
            this.buttonImportarClientes.Size = new System.Drawing.Size(150, 100);
            this.buttonImportarClientes.TabIndex = 10;
            this.buttonImportarClientes.Text = "Importar\r\nla lista de\r\nSabores";
            this.buttonImportarClientes.UseVisualStyleBackColor = true;
            this.buttonImportarClientes.Click += new System.EventHandler(this.ButtonImportarClientes_Click);
            
            this.listboxPedidos.Location = new System.Drawing.Point(318, 200);
            this.listboxPedidos.Name = "listboxPedidos";
            this.listboxPedidos.Size= new System.Drawing.Size(650, 300);
            this.listboxPedidos.TabIndex = 11;
            // 
            // FormHerramientas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.buttonImportarClientes);
            this.Controls.Add(this.buttonExportarClientes);
            this.Controls.Add(this.ctrlOpciones);
            this.Controls.Add(this.listboxPedidos);
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
        private System.Windows.Forms.Button buttonExportarClientes;
        private System.Windows.Forms.Button buttonImportarClientes;
        private System.Windows.Forms.ListBox listboxPedidos;
    }
}

