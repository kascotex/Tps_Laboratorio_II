
using Heladeria;

namespace Heladeria
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.ctrlOpciones = new Heladeria.CtrlOpciones();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxNumSocio = new System.Windows.Forms.TextBox();
            this.labelSocio = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonModo = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxCliente.SuspendLayout();
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
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(728, 256);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 53);
            this.buttonEliminar.TabIndex = 16;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSeleccionar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSeleccionar.Location = new System.Drawing.Point(528, 256);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(150, 53);
            this.buttonSeleccionar.TabIndex = 14;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = false;
            this.buttonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionar_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCliente.Controls.Add(this.labelDni);
            this.groupBoxCliente.Controls.Add(this.textBoxNumSocio);
            this.groupBoxCliente.Controls.Add(this.textBoxNombre);
            this.groupBoxCliente.Controls.Add(this.labelSocio);
            this.groupBoxCliente.Controls.Add(this.textBoxDni);
            this.groupBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCliente.Location = new System.Drawing.Point(518, 81);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(373, 134);
            this.groupBoxCliente.TabIndex = 17;
            this.groupBoxCliente.TabStop = false;
            // 
            // labelDni
            // 
            this.labelDni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDni.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDni.Location = new System.Drawing.Point(164, 82);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(51, 34);
            this.labelDni.TabIndex = 7;
            this.labelDni.Text = "DNI:";
            this.labelDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNumSocio
            // 
            this.textBoxNumSocio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxNumSocio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNumSocio.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNumSocio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumSocio.Location = new System.Drawing.Point(78, 82);
            this.textBoxNumSocio.Multiline = true;
            this.textBoxNumSocio.Name = "textBoxNumSocio";
            this.textBoxNumSocio.PlaceholderText = "0000";
            this.textBoxNumSocio.Size = new System.Drawing.Size(60, 34);
            this.textBoxNumSocio.TabIndex = 6;
            this.textBoxNumSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumSocio.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // labelSocio
            // 
            this.labelSocio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSocio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSocio.Location = new System.Drawing.Point(10, 82);
            this.labelSocio.Name = "labelSocio";
            this.labelSocio.Size = new System.Drawing.Size(70, 34);
            this.labelSocio.TabIndex = 6;
            this.labelSocio.Text = "Socio:";
            this.labelSocio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDni
            // 
            this.textBoxDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDni.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDni.Location = new System.Drawing.Point(214, 82);
            this.textBoxDni.Multiline = true;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.PlaceholderText = "0";
            this.textBoxDni.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDni.Size = new System.Drawing.Size(146, 34);
            this.textBoxDni.TabIndex = 5;
            this.textBoxDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDni.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNombre.Location = new System.Drawing.Point(10, 33);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.PlaceholderText = "Apellido, Nombre";
            this.textBoxNombre.Size = new System.Drawing.Size(350, 34);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // buttonModo
            // 
            this.buttonModo.BackColor = System.Drawing.Color.LightGreen;
            this.buttonModo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModo.Location = new System.Drawing.Point(928, 26);
            this.buttonModo.Name = "buttonModo";
            this.buttonModo.Size = new System.Drawing.Size(100, 52);
            this.buttonModo.TabIndex = 18;
            this.buttonModo.Text = "Agregar";
            this.buttonModo.UseVisualStyleBackColor = false;
            this.buttonModo.Click += new System.EventHandler(this.ButtonModo_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(518, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(373, 52);
            this.labelTitulo.TabIndex = 19;
            this.labelTitulo.Text = "Buscar Cliente";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 21;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(728, 256);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 53);
            this.buttonCancelar.TabIndex = 23;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.Location = new System.Drawing.Point(528, 256);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(150, 53);
            this.buttonAgregar.TabIndex = 22;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonModo);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.ctrlOpciones);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAgregar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CtrlOpciones ctrlOpciones;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxNumSocio;
        private System.Windows.Forms.Button buttonModo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelSocio;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAgregar;
    }
}

