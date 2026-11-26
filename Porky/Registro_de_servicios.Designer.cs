namespace Porky
{
    partial class Registro_de_servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_de_servicios));
            labelNumServicio = new Label();
            labelFecha = new Label();
            labelNomCliente = new Label();
            labelRUN = new Label();
            labelDireccion = new Label();
            labeltipolimpieza = new Label();
            labelCantTrabajadores = new Label();
            labelHorasTrabajadas = new Label();
            labelValorPorHora = new Label();
            labelCostoMateriales = new Label();
            labelDescuento = new Label();
            labelEstadoServicio = new Label();
            txtNumServicio = new TextBox();
            dtpFecha = new DateTimePicker();
            txtCliente = new TextBox();
            txtRut = new TextBox();
            txtDireccion = new TextBox();
            cmbTipoLimpieza = new ComboBox();
            txtTrabajadores = new TextBox();
            txtHoras = new TextBox();
            txtValorHora = new TextBox();
            txtMateriales = new TextBox();
            txtDescuentoPorc = new TextBox();
            cmbEstado = new ComboBox();
            lblManoObra = new Label();
            lblDescuento = new Label();
            lblSubtotal = new Label();
            lblIva = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelNumServicio
            // 
            labelNumServicio.AutoSize = true;
            labelNumServicio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumServicio.ForeColor = SystemColors.ActiveCaptionText;
            labelNumServicio.Location = new Point(22, 38);
            labelNumServicio.Name = "labelNumServicio";
            labelNumServicio.Size = new Size(150, 20);
            labelNumServicio.TabIndex = 0;
            labelNumServicio.Text = "Número de Servicio:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = SystemColors.ActiveCaptionText;
            labelFecha.Location = new Point(22, 89);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(53, 20);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha:";
            // 
            // labelNomCliente
            // 
            labelNomCliente.AutoSize = true;
            labelNomCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomCliente.ForeColor = SystemColors.ActiveCaptionText;
            labelNomCliente.Location = new Point(22, 129);
            labelNomCliente.Name = "labelNomCliente";
            labelNomCliente.Size = new Size(146, 40);
            labelNomCliente.TabIndex = 2;
            labelNomCliente.Text = "Nombre del Cliente \r\no Empresa :";
            labelNomCliente.Click += labelNomCliente_Click;
            // 
            // labelRUN
            // 
            labelRUN.AutoSize = true;
            labelRUN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRUN.ForeColor = SystemColors.ActiveCaptionText;
            labelRUN.Location = new Point(22, 196);
            labelRUN.Name = "labelRUN";
            labelRUN.Size = new Size(79, 20);
            labelRUN.TabIndex = 3;
            labelRUN.Text = "RUN/RUT:";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDireccion.ForeColor = SystemColors.ActiveCaptionText;
            labelDireccion.Location = new Point(22, 242);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(78, 20);
            labelDireccion.TabIndex = 4;
            labelDireccion.Text = "Dirección:";
            // 
            // labeltipolimpieza
            // 
            labeltipolimpieza.AutoSize = true;
            labeltipolimpieza.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltipolimpieza.ForeColor = SystemColors.ActiveCaptionText;
            labeltipolimpieza.Location = new Point(22, 293);
            labeltipolimpieza.Name = "labeltipolimpieza";
            labeltipolimpieza.Size = new Size(128, 20);
            labeltipolimpieza.TabIndex = 5;
            labeltipolimpieza.Text = "Tipo de Limpieza:";
            // 
            // labelCantTrabajadores
            // 
            labelCantTrabajadores.AutoSize = true;
            labelCantTrabajadores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCantTrabajadores.ForeColor = SystemColors.ActiveCaptionText;
            labelCantTrabajadores.Location = new Point(22, 326);
            labelCantTrabajadores.Name = "labelCantTrabajadores";
            labelCantTrabajadores.Size = new Size(122, 40);
            labelCantTrabajadores.TabIndex = 6;
            labelCantTrabajadores.Text = "Cantidad\r\nde Trabajadores:";
            // 
            // labelHorasTrabajadas
            // 
            labelHorasTrabajadas.AutoSize = true;
            labelHorasTrabajadas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHorasTrabajadas.ForeColor = SystemColors.ActiveCaptionText;
            labelHorasTrabajadas.Location = new Point(22, 396);
            labelHorasTrabajadas.Name = "labelHorasTrabajadas";
            labelHorasTrabajadas.Size = new Size(130, 20);
            labelHorasTrabajadas.TabIndex = 7;
            labelHorasTrabajadas.Text = "Horas Trabajadas:";
            // 
            // labelValorPorHora
            // 
            labelValorPorHora.AutoSize = true;
            labelValorPorHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelValorPorHora.ForeColor = SystemColors.ActiveCaptionText;
            labelValorPorHora.Location = new Point(22, 450);
            labelValorPorHora.Name = "labelValorPorHora";
            labelValorPorHora.Size = new Size(113, 20);
            labelValorPorHora.TabIndex = 8;
            labelValorPorHora.Text = "Valor por hora:";
            // 
            // labelCostoMateriales
            // 
            labelCostoMateriales.AutoSize = true;
            labelCostoMateriales.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCostoMateriales.ForeColor = SystemColors.ActiveCaptionText;
            labelCostoMateriales.Location = new Point(22, 496);
            labelCostoMateriales.Name = "labelCostoMateriales";
            labelCostoMateriales.Size = new Size(147, 20);
            labelCostoMateriales.TabIndex = 9;
            labelCostoMateriales.Text = "Costo de Materiales:";
            // 
            // labelDescuento
            // 
            labelDescuento.AutoSize = true;
            labelDescuento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDescuento.ForeColor = SystemColors.ActiveCaptionText;
            labelDescuento.Location = new Point(22, 555);
            labelDescuento.Name = "labelDescuento";
            labelDescuento.Size = new Size(112, 20);
            labelDescuento.TabIndex = 10;
            labelDescuento.Text = "Descuento (%):";
            // 
            // labelEstadoServicio
            // 
            labelEstadoServicio.AutoSize = true;
            labelEstadoServicio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstadoServicio.ForeColor = SystemColors.ActiveCaptionText;
            labelEstadoServicio.Location = new Point(22, 608);
            labelEstadoServicio.Name = "labelEstadoServicio";
            labelEstadoServicio.Size = new Size(142, 20);
            labelEstadoServicio.TabIndex = 11;
            labelEstadoServicio.Text = "Estado del Servicio:";
            // 
            // txtNumServicio
            // 
            txtNumServicio.Location = new Point(171, 35);
            txtNumServicio.Margin = new Padding(3, 4, 3, 4);
            txtNumServicio.Name = "txtNumServicio";
            txtNumServicio.Size = new Size(351, 27);
            txtNumServicio.TabIndex = 12;
            txtNumServicio.TextChanged += textBox1_TextChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(171, 89);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(351, 27);
            dtpFecha.TabIndex = 13;
            dtpFecha.Value = new DateTime(2026, 11, 24, 13, 33, 36, 0);
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(171, 142);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(351, 27);
            txtCliente.TabIndex = 14;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(171, 196);
            txtRut.Margin = new Padding(3, 4, 3, 4);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(351, 27);
            txtRut.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(171, 239);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(351, 27);
            txtDireccion.TabIndex = 16;
            // 
            // cmbTipoLimpieza
            // 
            cmbTipoLimpieza.FormattingEnabled = true;
            cmbTipoLimpieza.Location = new Point(171, 290);
            cmbTipoLimpieza.Margin = new Padding(3, 4, 3, 4);
            cmbTipoLimpieza.Name = "cmbTipoLimpieza";
            cmbTipoLimpieza.Size = new Size(351, 28);
            cmbTipoLimpieza.TabIndex = 17;
            cmbTipoLimpieza.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTrabajadores
            // 
            txtTrabajadores.Location = new Point(171, 339);
            txtTrabajadores.Margin = new Padding(3, 4, 3, 4);
            txtTrabajadores.Name = "txtTrabajadores";
            txtTrabajadores.Size = new Size(351, 27);
            txtTrabajadores.TabIndex = 18;
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(171, 393);
            txtHoras.Margin = new Padding(3, 4, 3, 4);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(351, 27);
            txtHoras.TabIndex = 19;
            // 
            // txtValorHora
            // 
            txtValorHora.Location = new Point(171, 447);
            txtValorHora.Margin = new Padding(3, 4, 3, 4);
            txtValorHora.Name = "txtValorHora";
            txtValorHora.Size = new Size(351, 27);
            txtValorHora.TabIndex = 20;
            // 
            // txtMateriales
            // 
            txtMateriales.Location = new Point(171, 493);
            txtMateriales.Margin = new Padding(3, 4, 3, 4);
            txtMateriales.Name = "txtMateriales";
            txtMateriales.Size = new Size(351, 27);
            txtMateriales.TabIndex = 21;
            // 
            // txtDescuentoPorc
            // 
            txtDescuentoPorc.Location = new Point(171, 548);
            txtDescuentoPorc.Margin = new Padding(3, 4, 3, 4);
            txtDescuentoPorc.Name = "txtDescuentoPorc";
            txtDescuentoPorc.Size = new Size(351, 27);
            txtDescuentoPorc.TabIndex = 22;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(171, 605);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(351, 28);
            cmbEstado.TabIndex = 23;
            // 
            // lblManoObra
            // 
            lblManoObra.AutoSize = true;
            lblManoObra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManoObra.ForeColor = SystemColors.ActiveCaptionText;
            lblManoObra.Location = new Point(631, 39);
            lblManoObra.Name = "lblManoObra";
            lblManoObra.Size = new Size(185, 20);
            lblManoObra.TabIndex = 24;
            lblManoObra.Text = "Resultados Mano de Obra";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.ForeColor = SystemColors.ActiveCaptionText;
            lblDescuento.Location = new Point(631, 89);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(212, 20);
            lblDescuento.TabIndex = 25;
            lblDescuento.Text = "Resultados de Descuentos (%)";
            lblDescuento.Click += lblDescuento_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = SystemColors.ActiveCaptionText;
            lblSubtotal.Location = new Point(631, 139);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(66, 20);
            lblSubtotal.TabIndex = 26;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIva.ForeColor = SystemColors.ActiveCaptionText;
            lblIva.Location = new Point(631, 176);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(73, 20);
            lblIva.TabIndex = 27;
            lblIva.Text = "IVA (19%)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ActiveCaptionText;
            lblTotal.Location = new Point(631, 215);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "Total";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 224, 192);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCalcular.Location = new Point(615, 269);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 44);
            btnCalcular.TabIndex = 29;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 224, 192);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGuardar.Location = new Point(779, 269);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 44);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 224, 192);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLimpiar.Location = new Point(922, 269);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(113, 44);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 224, 192);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnVolver.Location = new Point(1056, 269);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(115, 44);
            btnVolver.TabIndex = 32;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(721, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // Registro_de_servicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1253, 839);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(lblIva);
            Controls.Add(lblSubtotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblManoObra);
            Controls.Add(cmbEstado);
            Controls.Add(txtDescuentoPorc);
            Controls.Add(txtMateriales);
            Controls.Add(txtValorHora);
            Controls.Add(txtHoras);
            Controls.Add(txtTrabajadores);
            Controls.Add(cmbTipoLimpieza);
            Controls.Add(txtDireccion);
            Controls.Add(txtRut);
            Controls.Add(txtCliente);
            Controls.Add(dtpFecha);
            Controls.Add(txtNumServicio);
            Controls.Add(labelEstadoServicio);
            Controls.Add(labelDescuento);
            Controls.Add(labelCostoMateriales);
            Controls.Add(labelValorPorHora);
            Controls.Add(labelHorasTrabajadas);
            Controls.Add(labelCantTrabajadores);
            Controls.Add(labeltipolimpieza);
            Controls.Add(labelDireccion);
            Controls.Add(labelRUN);
            Controls.Add(labelNomCliente);
            Controls.Add(labelFecha);
            Controls.Add(labelNumServicio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registro_de_servicios";
            Text = "Registro de Servicios";
            Load += Registro_de_servicios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumServicio;
        private Label labelFecha;
        private Label labelNomCliente;
        private Label labelRUN;
        private Label labelDireccion;
        private Label labeltipolimpieza;
        private Label labelCantTrabajadores;
        private Label labelHorasTrabajadas;
        private Label labelValorPorHora;
        private Label labelCostoMateriales;
        private Label labelDescuento;
        private Label labelEstadoServicio;
        private TextBox txtNumServicio;
        private DateTimePicker dtpFecha;
        private TextBox txtCliente;
        private TextBox txtRut;
        private TextBox txtDireccion;
        private ComboBox cmbTipoLimpieza;
        private TextBox txtTrabajadores;
        private TextBox txtHoras;
        private TextBox txtValorHora;
        private TextBox txtMateriales;
        private TextBox txtDescuentoPorc;
        private ComboBox cmbEstado;
        private Label lblManoObra;
        private Label lblDescuento;
        private Label lblSubtotal;
        private Label lblIva;
        private Label lblTotal;
        private Button btnCalcular;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pictureBox1;
    }
}