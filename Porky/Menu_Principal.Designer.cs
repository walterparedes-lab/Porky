namespace Porky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIrRegistro = new Button();
            btnIrConsulta = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIrRegistro
            // 
            btnIrRegistro.BackColor = Color.FromArgb(255, 128, 255);
            btnIrRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrRegistro.ForeColor = SystemColors.ButtonHighlight;
            btnIrRegistro.Location = new Point(12, 224);
            btnIrRegistro.Margin = new Padding(3, 4, 3, 4);
            btnIrRegistro.Name = "btnIrRegistro";
            btnIrRegistro.Size = new Size(266, 77);
            btnIrRegistro.TabIndex = 0;
            btnIrRegistro.Text = "Ir a Registro";
            btnIrRegistro.UseVisualStyleBackColor = false;
            btnIrRegistro.Click += btnIrRegistro_Click;
            // 
            // btnIrConsulta
            // 
            btnIrConsulta.BackColor = Color.FromArgb(255, 128, 255);
            btnIrConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIrConsulta.ForeColor = SystemColors.ButtonHighlight;
            btnIrConsulta.Location = new Point(497, 224);
            btnIrConsulta.Margin = new Padding(3, 4, 3, 4);
            btnIrConsulta.Name = "btnIrConsulta";
            btnIrConsulta.Size = new Size(266, 77);
            btnIrConsulta.TabIndex = 1;
            btnIrConsulta.Text = "Ir a Consulta";
            btnIrConsulta.UseVisualStyleBackColor = false;
            btnIrConsulta.Click += btnIrConsulta_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 255);
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(254, 331);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(266, 78);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(775, 442);
            Controls.Add(btnIrConsulta);
            Controls.Add(btnIrRegistro);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Menú principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIrRegistro;
        private Button btnIrConsulta;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}
