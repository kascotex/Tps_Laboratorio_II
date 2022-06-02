
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ctrlOpciones = new Heladeria.CtrlOpciones();
            this.groupBoxEditar = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxEditar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 600);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
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
            // groupBoxEditar
            // 
            this.groupBoxEditar.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEditar.Controls.Add(this.labelId);
            this.groupBoxEditar.Controls.Add(this.textBoxNombre);
            this.groupBoxEditar.Controls.Add(this.textBoxApellido);
            this.groupBoxEditar.Controls.Add(this.textBoxDni);
            this.groupBoxEditar.Enabled = false;
            this.groupBoxEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEditar.Location = new System.Drawing.Point(815, 80);
            this.groupBoxEditar.Name = "groupBoxEditar";
            this.groupBoxEditar.Size = new System.Drawing.Size(373, 185);
            this.groupBoxEditar.TabIndex = 13;
            this.groupBoxEditar.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelId.Location = new System.Drawing.Point(10, 136);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(100, 29);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID: 0000";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // textBoxDni
            // 
            this.textBoxDni.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDni.Location = new System.Drawing.Point(160, 136);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.PlaceholderText = "DNI";
            this.textBoxDni.Size = new System.Drawing.Size(200, 29);
            this.textBoxDni.TabIndex = 5;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(437, 304);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 53);
            this.buttonEliminar.TabIndex = 16;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.Gold;
            this.buttonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditar.Location = new System.Drawing.Point(312, 304);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 53);
            this.buttonEditar.TabIndex = 15;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.Location = new System.Drawing.Point(187, 304);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 53);
            this.buttonAgregar.TabIndex = 14;
            this.buttonAgregar.Text = "Elejir";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(177, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 185);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(10, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nombre";
            this.textBox1.Size = new System.Drawing.Size(350, 29);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(10, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Apellido";
            this.textBox2.Size = new System.Drawing.Size(350, 29);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(160, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "DNI";
            this.textBox3.Size = new System.Drawing.Size(200, 29);
            this.textBox3.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxId.Location = new System.Drawing.Point(10, 136);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.PlaceholderText = "ID";
            this.textBoxId.Size = new System.Drawing.Size(100, 29);
            this.textBoxId.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(940, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.groupBoxEditar);
            this.Controls.Add(this.ctrlOpciones);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBoxEditar.ResumeLayout(false);
            this.groupBoxEditar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private CtrlOpciones ctrlOpciones;
        private System.Windows.Forms.GroupBox groupBoxEditar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button button1;
    }
}

