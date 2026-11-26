namespace Porky
{
    partial class Consulta_por_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_por_Cliente));
            txtBuscarCliente = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            btnVolver = new Button();
            dgvServicios = new DataGridView();
            lblResultados = new Label();
            lblBusquedaCliente = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(170, 51);
            txtBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(431, 27);
            txtBuscarCliente.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(65, 111);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(114, 56);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(246, 111);
            btnMostrarTodos.Margin = new Padding(3, 4, 3, 4);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(129, 56);
            btnMostrarTodos.TabIndex = 2;
            btnMostrarTodos.Text = "Mostrar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(445, 111);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 56);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(26, 240);
            dgvServicios.Margin = new Padding(3, 4, 3, 4);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.Size = new Size(433, 261);
            dgvServicios.TabIndex = 4;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(159, 203);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(166, 20);
            lblResultados.TabIndex = 5;
            lblResultados.Text = "Resumen de Resultados";
            // 
            // lblBusquedaCliente
            // 
            lblBusquedaCliente.AutoSize = true;
            lblBusquedaCliente.Location = new Point(26, 55);
            lblBusquedaCliente.Name = "lblBusquedaCliente";
            lblBusquedaCliente.Size = new Size(145, 20);
            lblBusquedaCliente.TabIndex = 6;
            lblBusquedaCliente.Text = "Búsqueda de Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(606, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Consulta_por_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(lblBusquedaCliente);
            Controls.Add(lblResultados);
            Controls.Add(dgvServicios);
            Controls.Add(btnVolver);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Consulta_por_Cliente";
            Text = "Consulta por Cliente";
            Load += Consulta_por_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarCliente;
        private Button button1;
        private Button btnBuscar;
        private Button btnMostrarTodos;
        private Button btnVolver;
        private DataGridView dgvServicios;
        private Label lblResultados;
        private Label lblBusquedaCliente;
        private PictureBox pictureBox1;
    }
}