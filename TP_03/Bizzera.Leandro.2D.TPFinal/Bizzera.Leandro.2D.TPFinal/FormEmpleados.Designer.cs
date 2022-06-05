
namespace Heladeria
{
    partial class FormEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.labelEdad = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelEmpleados = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlOpciones = new Heladeria.CtrlOpciones();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBoxEditar = new System.Windows.Forms.GroupBox();
            this.comboBoxPuesto = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.groupBoxEditar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre.Location = new System.Drawing.Point(10, 28);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(350, 29);
            this.textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxApellido.Location = new System.Drawing.Point(10, 82);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.PlaceholderText = "Apellido";
            this.textBoxApellido.Size = new System.Drawing.Size(350, 29);
            this.textBoxApellido.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelId.Location = new System.Drawing.Point(10, 190);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(100, 29);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID: 0000";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownEdad.Location = new System.Drawing.Point(300, 136);
            this.numericUpDownEdad.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(60, 29);
            this.numericUpDownEdad.TabIndex = 3;
            this.numericUpDownEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownEdad.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelEdad
            // 
            this.labelEdad.BackColor = System.Drawing.SystemColors.Window;
            this.labelEdad.Location = new System.Drawing.Point(248, 136);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(50, 29);
            this.labelEdad.TabIndex = 4;
            this.labelEdad.Text = "Edad:";
            this.labelEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDni
            // 
            this.textBoxDni.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDni.Location = new System.Drawing.Point(10, 136);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.PlaceholderText = "DNI";
            this.textBoxDni.Size = new System.Drawing.Size(200, 29);
            this.textBoxDni.TabIndex = 5;
            // 
            // flowLayoutPanelEmpleados
            // 
            this.flowLayoutPanelEmpleados.AutoScroll = true;
            this.flowLayoutPanelEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelEmpleados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEmpleados.Location = new System.Drawing.Point(146, 92);
            this.flowLayoutPanelEmpleados.Name = "flowLayoutPanelEmpleados";
            this.flowLayoutPanelEmpleados.Size = new System.Drawing.Size(650, 500);
            this.flowLayoutPanelEmpleados.TabIndex = 6;
            this.flowLayoutPanelEmpleados.WrapContents = false;
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
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.Location = new System.Drawing.Point(825, 503);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 53);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Gold;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(950, 503);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 53);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(1075, 503);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 53);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // groupBoxEditar
            // 
            this.groupBoxEditar.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEditar.Controls.Add(this.comboBoxPuesto);
            this.groupBoxEditar.Controls.Add(this.labelId);
            this.groupBoxEditar.Controls.Add(this.textBoxNombre);
            this.groupBoxEditar.Controls.Add(this.textBoxApellido);
            this.groupBoxEditar.Controls.Add(this.numericUpDownEdad);
            this.groupBoxEditar.Controls.Add(this.labelEdad);
            this.groupBoxEditar.Controls.Add(this.textBoxDni);
            this.groupBoxEditar.Enabled = false;
            this.groupBoxEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxEditar.Location = new System.Drawing.Point(815, 80);
            this.groupBoxEditar.Name = "groupBoxEditar";
            this.groupBoxEditar.Size = new System.Drawing.Size(373, 235);
            this.groupBoxEditar.TabIndex = 12;
            this.groupBoxEditar.TabStop = false;
            // 
            // comboBoxPuesto
            // 
            this.comboBoxPuesto.FormattingEnabled = true;
            this.comboBoxPuesto.Location = new System.Drawing.Point(120, 191);
            this.comboBoxPuesto.Name = "comboBoxPuesto";
            this.comboBoxPuesto.Size = new System.Drawing.Size(240, 29);
            this.comboBoxPuesto.TabIndex = 6;
            // 
            // statusStrip
            // 
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
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FormEmpleados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.ctrlOpciones);
            this.Controls.Add(this.flowLayoutPanelEmpleados);
            this.Controls.Add(this.groupBoxEditar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.groupBoxEditar.ResumeLayout(false);
            this.groupBoxEditar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmpleados;
        private CtrlOpciones ctrlOpciones;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBoxEditar;
        private System.Windows.Forms.ComboBox comboBoxPuesto;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}