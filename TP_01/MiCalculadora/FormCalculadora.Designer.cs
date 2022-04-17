
namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.labelResultado = new System.Windows.Forms.Label();
            this.textBoxNumero1 = new System.Windows.Forms.TextBox();
            this.textBoxNumero2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonConvertirEnBinario = new System.Windows.Forms.Button();
            this.buttonConvertirEnDecimal = new System.Windows.Forms.Button();
            this.listBoxOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.Color.Silver;
            this.labelResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.ForeColor = System.Drawing.Color.Black;
            this.labelResultado.Location = new System.Drawing.Point(7, 7);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(633, 80);
            this.labelResultado.TabIndex = 1;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNumero1
            // 
            this.textBoxNumero1.BackColor = System.Drawing.Color.Silver;
            this.textBoxNumero1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumero1.Location = new System.Drawing.Point(7, 96);
            this.textBoxNumero1.Name = "textBoxNumero1";
            this.textBoxNumero1.Size = new System.Drawing.Size(272, 61);
            this.textBoxNumero1.TabIndex = 2;
            this.textBoxNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumero2
            // 
            this.textBoxNumero2.BackColor = System.Drawing.Color.Silver;
            this.textBoxNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumero2.Location = new System.Drawing.Point(370, 96);
            this.textBoxNumero2.Name = "textBoxNumero2";
            this.textBoxNumero2.Size = new System.Drawing.Size(270, 61);
            this.textBoxNumero2.TabIndex = 4;
            this.textBoxNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.BackColor = System.Drawing.Color.Silver;
            this.comboBoxOperador.DropDownHeight = 360;
            this.comboBoxOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperador.DropDownWidth = 80;
            this.comboBoxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxOperador.ForeColor = System.Drawing.Color.Black;
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.IntegralHeight = false;
            this.comboBoxOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperador.Location = new System.Drawing.Point(285, 95);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(79, 62);
            this.comboBoxOperador.TabIndex = 3;
            // 
            // buttonOperar
            // 
            this.buttonOperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOperar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOperar.Location = new System.Drawing.Point(7, 172);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(209, 81);
            this.buttonOperar.TabIndex = 5;
            this.buttonOperar.Text = "&Operar";
            this.buttonOperar.UseVisualStyleBackColor = false;
            this.buttonOperar.Click += new System.EventHandler(this.ButtonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLimpiar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLimpiar.Location = new System.Drawing.Point(219, 172);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(209, 81);
            this.buttonLimpiar.TabIndex = 6;
            this.buttonLimpiar.Text = "&Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.ButtonLimpiar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCerrar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCerrar.Location = new System.Drawing.Point(431, 172);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(209, 81);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "&Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.ButtonCerrar_Click);
            // 
            // buttonConvertirEnBinario
            // 
            this.buttonConvertirEnBinario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConvertirEnBinario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConvertirEnBinario.Location = new System.Drawing.Point(7, 266);
            this.buttonConvertirEnBinario.Name = "buttonConvertirEnBinario";
            this.buttonConvertirEnBinario.Size = new System.Drawing.Size(315, 81);
            this.buttonConvertirEnBinario.TabIndex = 8;
            this.buttonConvertirEnBinario.Text = "Convertir a &Binario";
            this.buttonConvertirEnBinario.UseVisualStyleBackColor = false;
            this.buttonConvertirEnBinario.Click += new System.EventHandler(this.ButtonConvertirEnBinario_Click);
            // 
            // buttonConvertirEnDecimal
            // 
            this.buttonConvertirEnDecimal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConvertirEnDecimal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConvertirEnDecimal.Location = new System.Drawing.Point(325, 266);
            this.buttonConvertirEnDecimal.Name = "buttonConvertirEnDecimal";
            this.buttonConvertirEnDecimal.Size = new System.Drawing.Size(315, 81);
            this.buttonConvertirEnDecimal.TabIndex = 9;
            this.buttonConvertirEnDecimal.Text = "Convertir a &Decimal";
            this.buttonConvertirEnDecimal.UseVisualStyleBackColor = false;
            this.buttonConvertirEnDecimal.Click += new System.EventHandler(this.ButtonConvertirEnDecimal_Click);
            // 
            // listBoxOperaciones
            // 
            this.listBoxOperaciones.BackColor = System.Drawing.Color.Silver;
            this.listBoxOperaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxOperaciones.FormattingEnabled = true;
            this.listBoxOperaciones.ItemHeight = 28;
            this.listBoxOperaciones.Location = new System.Drawing.Point(646, 7);
            this.listBoxOperaciones.Name = "listBoxOperaciones";
            this.listBoxOperaciones.Size = new System.Drawing.Size(230, 340);
            this.listBoxOperaciones.TabIndex = 10;
            this.listBoxOperaciones.TabStop = false;
            // 
            // FormCalculadora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(884, 356);
            this.Controls.Add(this.listBoxOperaciones);
            this.Controls.Add(this.buttonConvertirEnDecimal);
            this.Controls.Add(this.buttonConvertirEnBinario);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.textBoxNumero2);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textBoxNumero1);
            this.Controls.Add(this.labelResultado);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de [Bizzera Leandro] del curso [2°D]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.TextBox textBoxNumero1;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.TextBox textBoxNumero2;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonConvertirEnBinario;
        private System.Windows.Forms.Button buttonConvertirEnDecimal;
        private System.Windows.Forms.ListBox listBoxOperaciones;
    }
}

