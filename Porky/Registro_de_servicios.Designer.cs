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
            SuspendLayout();
            // 
            // labelNumServicio
            // 
            labelNumServicio.AutoSize = true;
            labelNumServicio.Location = new Point(30, 29);
            labelNumServicio.Name = "labelNumServicio";
            labelNumServicio.Size = new Size(111, 15);
            labelNumServicio.TabIndex = 0;
            labelNumServicio.Text = "Número de Servicio";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(30, 67);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(38, 15);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "Fecha";
            // 
            // labelNomCliente
            // 
            labelNomCliente.AutoSize = true;
            labelNomCliente.Location = new Point(30, 107);
            labelNomCliente.Name = "labelNomCliente";
            labelNomCliente.Size = new Size(160, 15);
            labelNomCliente.TabIndex = 2;
            labelNomCliente.Text = "Nombre del Cliente/Empresa";
            // 
            // labelRUN
            // 
            labelRUN.AutoSize = true;
            labelRUN.Location = new Point(30, 147);
            labelRUN.Name = "labelRUN";
            labelRUN.Size = new Size(58, 15);
            labelRUN.TabIndex = 3;
            labelRUN.Text = "RUN/RUT";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(30, 182);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(57, 15);
            labelDireccion.TabIndex = 4;
            labelDireccion.Text = "Dirección";
            // 
            // labeltipolimpieza
            // 
            labeltipolimpieza.AutoSize = true;
            labeltipolimpieza.Location = new Point(30, 220);
            labeltipolimpieza.Name = "labeltipolimpieza";
            labeltipolimpieza.Size = new Size(97, 15);
            labeltipolimpieza.TabIndex = 5;
            labeltipolimpieza.Text = "Tipo de Limpieza";
            // 
            // labelCantTrabajadores
            // 
            labelCantTrabajadores.AutoSize = true;
            labelCantTrabajadores.Location = new Point(30, 257);
            labelCantTrabajadores.Name = "labelCantTrabajadores";
            labelCantTrabajadores.Size = new Size(141, 15);
            labelCantTrabajadores.TabIndex = 6;
            labelCantTrabajadores.Text = "Cantidad de Trabajadores";
            // 
            // labelHorasTrabajadas
            // 
            labelHorasTrabajadas.AutoSize = true;
            labelHorasTrabajadas.Location = new Point(30, 297);
            labelHorasTrabajadas.Name = "labelHorasTrabajadas";
            labelHorasTrabajadas.Size = new Size(97, 15);
            labelHorasTrabajadas.TabIndex = 7;
            labelHorasTrabajadas.Text = "Horas Trabajadas";
            // 
            // labelValorPorHora
            // 
            labelValorPorHora.AutoSize = true;
            labelValorPorHora.Location = new Point(30, 338);
            labelValorPorHora.Name = "labelValorPorHora";
            labelValorPorHora.Size = new Size(81, 15);
            labelValorPorHora.TabIndex = 8;
            labelValorPorHora.Text = "Valor por hora";
            // 
            // labelCostoMateriales
            // 
            labelCostoMateriales.AutoSize = true;
            labelCostoMateriales.Location = new Point(30, 375);
            labelCostoMateriales.Name = "labelCostoMateriales";
            labelCostoMateriales.Size = new Size(111, 15);
            labelCostoMateriales.TabIndex = 9;
            labelCostoMateriales.Text = "Costo de Materiales";
            // 
            // labelDescuento
            // 
            labelDescuento.AutoSize = true;
            labelDescuento.Location = new Point(30, 416);
            labelDescuento.Name = "labelDescuento";
            labelDescuento.Size = new Size(63, 15);
            labelDescuento.TabIndex = 10;
            labelDescuento.Text = "Descuento";
            // 
            // labelEstadoServicio
            // 
            labelEstadoServicio.AutoSize = true;
            labelEstadoServicio.Location = new Point(30, 457);
            labelEstadoServicio.Name = "labelEstadoServicio";
            labelEstadoServicio.Size = new Size(105, 15);
            labelEstadoServicio.TabIndex = 11;
            labelEstadoServicio.Text = "Estado del Servicio";
            // 
            // Registro_de_servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
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
            Name = "Registro_de_servicios";
            Text = "Registro de Servicios";
            Load += Registro_de_servicios_Load;
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
    }
}