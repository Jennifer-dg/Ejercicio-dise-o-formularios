namespace Calculadora_4_operaciones
{
    partial class Form1
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
            lblTitulo = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblOperacion = new Label();
            lblTituloRespuesta = new Label();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Gill Sans Ultra Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(0, 0, 64);
            lblTitulo.Location = new Point(282, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 42);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculadora";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(331, 107);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(271, 27);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(331, 143);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(271, 27);
            txtNumero2.TabIndex = 2;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero1.ForeColor = Color.FromArgb(0, 0, 64);
            lblNumero1.Location = new Point(177, 109);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(122, 20);
            lblNumero1.TabIndex = 3;
            lblNumero1.Text = "Primer Número:";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero2.ForeColor = Color.FromArgb(0, 0, 64);
            lblNumero2.Location = new Point(177, 145);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(136, 20);
            lblNumero2.TabIndex = 4;
            lblNumero2.Text = "Segundo Número:";
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.ForeColor = Color.FromArgb(0, 0, 64);
            btnSumar.Location = new Point(175, 241);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 53);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += button1_Click;
            // 
            // btnRestar
            // 
            btnRestar.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestar.ForeColor = Color.FromArgb(0, 0, 64);
            btnRestar.Location = new Point(286, 241);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(94, 53);
            btnRestar.TabIndex = 0;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.ForeColor = Color.FromArgb(0, 0, 64);
            btnMultiplicar.Location = new Point(395, 241);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 53);
            btnMultiplicar.TabIndex = 5;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.ForeColor = Color.FromArgb(0, 0, 64);
            btnDividir.Location = new Point(506, 241);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(94, 53);
            btnDividir.TabIndex = 6;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += button4_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperacion.ForeColor = Color.FromArgb(0, 0, 64);
            lblOperacion.Location = new Point(296, 205);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(188, 20);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "Seleccione Una Operación";
            // 
            // lblTituloRespuesta
            // 
            lblTituloRespuesta.AutoSize = true;
            lblTituloRespuesta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRespuesta.ForeColor = Color.FromArgb(0, 0, 64);
            lblTituloRespuesta.Location = new Point(346, 322);
            lblTituloRespuesta.Name = "lblTituloRespuesta";
            lblTituloRespuesta.Size = new Size(85, 20);
            lblTituloRespuesta.TabIndex = 8;
            lblTituloRespuesta.Text = "Respuesta:";
            lblTituloRespuesta.Click += label5_Click;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.BackColor = Color.White;
            lblRespuesta.Location = new Point(381, 366);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(50, 20);
            lblRespuesta.TabIndex = 9;
            lblRespuesta.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRespuesta);
            Controls.Add(lblTituloRespuesta);
            Controls.Add(lblOperacion);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblNumero1;
        private Label lblNumero2;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblOperacion;
        private Label lblTituloRespuesta;
        private Label lblRespuesta;
    }
}
