
namespace Heladeria
{
    partial class FormVentas
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.ctrlOpciones = new Heladeria.CtrlOpciones();
            this.ctrlEnvases = new Heladeria.CtrlEnvases();
            this.groupBoxSabores = new System.Windows.Forms.GroupBox();
            this.buttonMenta = new System.Windows.Forms.Button();
            this.buttonCremaDelCielo = new System.Windows.Forms.Button();
            this.buttonDulceDeLeche = new System.Windows.Forms.Button();
            this.buttonDurazno = new System.Windows.Forms.Button();
            this.buttonLimon = new System.Windows.Forms.Button();
            this.buttonFrutilla = new System.Windows.Forms.Button();
            this.buttonVainilla = new System.Windows.Forms.Button();
            this.buttonGranizado = new System.Windows.Forms.Button();
            this.buttonCrema = new System.Windows.Forms.Button();
            this.buttonChocolateAmargo = new System.Windows.Forms.Button();
            this.buttonChocolateConAlmendras = new System.Windows.Forms.Button();
            this.buttonChocolate = new System.Windows.Forms.Button();
            this.pictureBoxEnvase = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelSabores = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonConfirmarPedido = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSabores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnvase)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
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
            // ctrlEnvases
            // 
            this.ctrlEnvases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlEnvases.BackColor = System.Drawing.Color.Transparent;
            this.ctrlEnvases.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctrlEnvases.BackgroundImage")));
            this.ctrlEnvases.Location = new System.Drawing.Point(1100, 0);
            this.ctrlEnvases.Name = "ctrlEnvases";
            this.ctrlEnvases.Size = new System.Drawing.Size(100, 600);
            this.ctrlEnvases.TabIndex = 9;
            // 
            // groupBoxSabores
            // 
            this.groupBoxSabores.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSabores.Controls.Add(this.buttonMenta);
            this.groupBoxSabores.Controls.Add(this.buttonCremaDelCielo);
            this.groupBoxSabores.Controls.Add(this.buttonDulceDeLeche);
            this.groupBoxSabores.Controls.Add(this.buttonDurazno);
            this.groupBoxSabores.Controls.Add(this.buttonLimon);
            this.groupBoxSabores.Controls.Add(this.buttonFrutilla);
            this.groupBoxSabores.Controls.Add(this.buttonVainilla);
            this.groupBoxSabores.Controls.Add(this.buttonGranizado);
            this.groupBoxSabores.Controls.Add(this.buttonCrema);
            this.groupBoxSabores.Controls.Add(this.buttonChocolateAmargo);
            this.groupBoxSabores.Controls.Add(this.buttonChocolateConAlmendras);
            this.groupBoxSabores.Controls.Add(this.buttonChocolate);
            this.groupBoxSabores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSabores.Location = new System.Drawing.Point(461, 0);
            this.groupBoxSabores.Name = "groupBoxSabores";
            this.groupBoxSabores.Size = new System.Drawing.Size(610, 245);
            this.groupBoxSabores.TabIndex = 10;
            this.groupBoxSabores.TabStop = false;
            // 
            // buttonMenta
            // 
            this.buttonMenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenta.Location = new System.Drawing.Point(458, 167);
            this.buttonMenta.Name = "buttonMenta";
            this.buttonMenta.Size = new System.Drawing.Size(150, 75);
            this.buttonMenta.TabIndex = 11;
            this.buttonMenta.Text = "Menta";
            this.buttonMenta.UseCompatibleTextRendering = true;
            this.buttonMenta.UseVisualStyleBackColor = true;
            this.buttonMenta.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonCremaDelCielo
            // 
            this.buttonCremaDelCielo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCremaDelCielo.Location = new System.Drawing.Point(458, 90);
            this.buttonCremaDelCielo.Name = "buttonCremaDelCielo";
            this.buttonCremaDelCielo.Size = new System.Drawing.Size(150, 75);
            this.buttonCremaDelCielo.TabIndex = 10;
            this.buttonCremaDelCielo.Text = "Crema Del Cielo";
            this.buttonCremaDelCielo.UseCompatibleTextRendering = true;
            this.buttonCremaDelCielo.UseVisualStyleBackColor = true;
            this.buttonCremaDelCielo.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonDulceDeLeche
            // 
            this.buttonDulceDeLeche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDulceDeLeche.Location = new System.Drawing.Point(458, 13);
            this.buttonDulceDeLeche.Name = "buttonDulceDeLeche";
            this.buttonDulceDeLeche.Size = new System.Drawing.Size(150, 75);
            this.buttonDulceDeLeche.TabIndex = 9;
            this.buttonDulceDeLeche.Text = "Dulce De Leche";
            this.buttonDulceDeLeche.UseCompatibleTextRendering = true;
            this.buttonDulceDeLeche.UseVisualStyleBackColor = true;
            this.buttonDulceDeLeche.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonDurazno
            // 
            this.buttonDurazno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDurazno.Location = new System.Drawing.Point(306, 167);
            this.buttonDurazno.Name = "buttonDurazno";
            this.buttonDurazno.Size = new System.Drawing.Size(150, 75);
            this.buttonDurazno.TabIndex = 8;
            this.buttonDurazno.Text = "Durazno";
            this.buttonDurazno.UseCompatibleTextRendering = true;
            this.buttonDurazno.UseVisualStyleBackColor = true;
            this.buttonDurazno.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonLimon
            // 
            this.buttonLimon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLimon.Location = new System.Drawing.Point(306, 90);
            this.buttonLimon.Name = "buttonLimon";
            this.buttonLimon.Size = new System.Drawing.Size(150, 75);
            this.buttonLimon.TabIndex = 7;
            this.buttonLimon.Text = "Limon";
            this.buttonLimon.UseCompatibleTextRendering = true;
            this.buttonLimon.UseVisualStyleBackColor = true;
            this.buttonLimon.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonFrutilla
            // 
            this.buttonFrutilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonFrutilla.Location = new System.Drawing.Point(306, 13);
            this.buttonFrutilla.Name = "buttonFrutilla";
            this.buttonFrutilla.Size = new System.Drawing.Size(150, 75);
            this.buttonFrutilla.TabIndex = 6;
            this.buttonFrutilla.Text = "Frutilla";
            this.buttonFrutilla.UseCompatibleTextRendering = true;
            this.buttonFrutilla.UseVisualStyleBackColor = true;
            this.buttonFrutilla.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonVainilla
            // 
            this.buttonVainilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonVainilla.Location = new System.Drawing.Point(154, 167);
            this.buttonVainilla.Name = "buttonVainilla";
            this.buttonVainilla.Size = new System.Drawing.Size(150, 75);
            this.buttonVainilla.TabIndex = 5;
            this.buttonVainilla.Text = "Vainilla";
            this.buttonVainilla.UseCompatibleTextRendering = true;
            this.buttonVainilla.UseVisualStyleBackColor = true;
            this.buttonVainilla.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonGranizado
            // 
            this.buttonGranizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGranizado.Location = new System.Drawing.Point(154, 90);
            this.buttonGranizado.Name = "buttonGranizado";
            this.buttonGranizado.Size = new System.Drawing.Size(150, 75);
            this.buttonGranizado.TabIndex = 4;
            this.buttonGranizado.Text = "Granizado";
            this.buttonGranizado.UseCompatibleTextRendering = true;
            this.buttonGranizado.UseVisualStyleBackColor = true;
            this.buttonGranizado.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonCrema
            // 
            this.buttonCrema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCrema.Location = new System.Drawing.Point(154, 13);
            this.buttonCrema.Name = "buttonCrema";
            this.buttonCrema.Size = new System.Drawing.Size(150, 75);
            this.buttonCrema.TabIndex = 3;
            this.buttonCrema.Text = "Crema";
            this.buttonCrema.UseCompatibleTextRendering = true;
            this.buttonCrema.UseVisualStyleBackColor = true;
            this.buttonCrema.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonChocolateAmargo
            // 
            this.buttonChocolateAmargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChocolateAmargo.Location = new System.Drawing.Point(2, 167);
            this.buttonChocolateAmargo.Name = "buttonChocolateAmargo";
            this.buttonChocolateAmargo.Size = new System.Drawing.Size(150, 75);
            this.buttonChocolateAmargo.TabIndex = 2;
            this.buttonChocolateAmargo.Text = "Chocolate Amargo";
            this.buttonChocolateAmargo.UseVisualStyleBackColor = true;
            this.buttonChocolateAmargo.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonChocolateConAlmendras
            // 
            this.buttonChocolateConAlmendras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChocolateConAlmendras.Location = new System.Drawing.Point(2, 90);
            this.buttonChocolateConAlmendras.Name = "buttonChocolateConAlmendras";
            this.buttonChocolateConAlmendras.Size = new System.Drawing.Size(150, 75);
            this.buttonChocolateConAlmendras.TabIndex = 1;
            this.buttonChocolateConAlmendras.Text = "Chocolate Con Almendras";
            this.buttonChocolateConAlmendras.UseCompatibleTextRendering = true;
            this.buttonChocolateConAlmendras.UseVisualStyleBackColor = true;
            this.buttonChocolateConAlmendras.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // buttonChocolate
            // 
            this.buttonChocolate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChocolate.BackgroundImage")));
            this.buttonChocolate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChocolate.Location = new System.Drawing.Point(2, 13);
            this.buttonChocolate.Name = "buttonChocolate";
            this.buttonChocolate.Size = new System.Drawing.Size(150, 75);
            this.buttonChocolate.TabIndex = 0;
            this.buttonChocolate.Text = "Chocolate";
            this.buttonChocolate.UseCompatibleTextRendering = true;
            this.buttonChocolate.UseVisualStyleBackColor = true;
            this.buttonChocolate.Click += new System.EventHandler(this.ButtonSabor_Click);
            // 
            // pictureBoxEnvase
            // 
            this.pictureBoxEnvase.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnvase.Location = new System.Drawing.Point(150, 3);
            this.pictureBoxEnvase.Name = "pictureBoxEnvase";
            this.pictureBoxEnvase.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxEnvase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnvase.TabIndex = 11;
            this.pictureBoxEnvase.TabStop = false;
            // 
            // flowLayoutPanelSabores
            // 
            this.flowLayoutPanelSabores.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelSabores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSabores.Location = new System.Drawing.Point(150, 320);
            this.flowLayoutPanelSabores.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSabores.Name = "flowLayoutPanelSabores";
            this.flowLayoutPanelSabores.Size = new System.Drawing.Size(300, 265);
            this.flowLayoutPanelSabores.TabIndex = 12;
            // 
            // buttonConfirmarPedido
            // 
            this.buttonConfirmarPedido.BackColor = System.Drawing.Color.LightGreen;
            this.buttonConfirmarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmarPedido.Location = new System.Drawing.Point(588, 499);
            this.buttonConfirmarPedido.Name = "buttonConfirmarPedido";
            this.buttonConfirmarPedido.Size = new System.Drawing.Size(150, 60);
            this.buttonConfirmarPedido.TabIndex = 13;
            this.buttonConfirmarPedido.Text = "Confirmar\r\nPedido";
            this.buttonConfirmarPedido.UseCompatibleTextRendering = true;
            this.buttonConfirmarPedido.UseVisualStyleBackColor = false;
            this.buttonConfirmarPedido.Click += new System.EventHandler(this.ButtonConfirmarPedido_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(826, 499);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 60);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseCompatibleTextRendering = true;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 22;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // FormVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmarPedido);
            this.Controls.Add(this.flowLayoutPanelSabores);
            this.Controls.Add(this.pictureBoxEnvase);
            this.Controls.Add(this.groupBoxSabores);
            this.Controls.Add(this.ctrlEnvases);
            this.Controls.Add(this.ctrlOpciones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVenta_FormClosing);
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.groupBoxSabores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnvase)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CtrlOpciones ctrlOpciones;
        private CtrlEnvases ctrlEnvases;
        private System.Windows.Forms.GroupBox groupBoxSabores;
        private System.Windows.Forms.Button buttonMenta;
        private System.Windows.Forms.Button buttonCremaDelCielo;
        private System.Windows.Forms.Button buttonDulceDeLeche;
        private System.Windows.Forms.Button buttonDurazno;
        private System.Windows.Forms.Button buttonLimon;
        private System.Windows.Forms.Button buttonFrutilla;
        private System.Windows.Forms.Button buttonVainilla;
        private System.Windows.Forms.Button buttonGranizado;
        private System.Windows.Forms.Button buttonCrema;
        private System.Windows.Forms.Button buttonChocolateAmargo;
        private System.Windows.Forms.Button buttonChocolateConAlmendras;
        private System.Windows.Forms.Button buttonChocolate;
        private System.Windows.Forms.PictureBox pictureBoxEnvase;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSabores;
        private System.Windows.Forms.Button buttonConfirmarPedido;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}