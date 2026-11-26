using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Porky
{
    public partial class Registro_de_servicios : Form
    {
        private readonly string rutaCsv = Path.Combine(Application.StartupPath, "servicios_limpieza.csv");

        private decimal manoObra = 0;
        private decimal montoDescuento = 0;
        private decimal subtotal = 0;
        private decimal iva = 0;
        private decimal total = 0;

        public Registro_de_servicios()
        {
            InitializeComponent();
            this.Text = "Porky - Registro de Servicios";
            this.StartPosition = FormStartPosition.CenterScreen;
            InicializarControles();
        }

        private void InicializarControles()
        {
            cmbTipoLimpieza.Items.Clear();
            cmbTipoLimpieza.Items.AddRange(new string[] {
                "Residencial / Hogar",
                "Oficinas y Corporativo",
                "Industrial / Bodegas",
                "Post-Construcción",
                "Vidrios y Fachadas"
            });
            cmbTipoLimpieza.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new string[] {
                "Pendiente",
                "En Proceso",
                "Finalizado"
            });
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.SelectedIndex = 0;

            txtDescuentoPorc.Text = "0";
            ReiniciarEtiquetasCalculo();
        }

        private void ReiniciarEtiquetasCalculo()
        {
            lblManoObra.Text = "Resultados Mano de Obra: $0";
            lblDescuento.Text = "Resultados de Descuentos (%): $0";
            lblSubtotal.Text = "Subtotal: $0";
            lblIva.Text = "IVA (19%): $0";
            lblTotal.Text = "Total: $0";
        }

        private bool ValidarYCalcular()
        {
            // Validar campos obligatorios vacíos
            if (string.IsNullOrWhiteSpace(txtNumServicio.Text) ||
                string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(txtRut.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                cmbTipoLimpieza.SelectedIndex == -1 ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todos los campos obligatorios (N° Servicio, Cliente, RUT, Dirección, Tipo de limpieza y Estado).",
                    "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar campos numéricos
            if (!int.TryParse(txtTrabajadores.Text.Trim(), out int trabajadores) || trabajadores <= 0)
            {
                MessageBox.Show("La cantidad de trabajadores debe ser un número entero mayor a 0.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrabajadores.Focus();
                return false;
            }

            string horasTexto = txtHoras.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(horasTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal horas) || horas <= 0)
            {
                MessageBox.Show("Las horas trabajadas deben ser un número mayor a 0.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoras.Focus();
                return false;
            }

            if (!decimal.TryParse(txtValorHora.Text.Trim(), out decimal valorHora) || valorHora <= 0)
            {
                MessageBox.Show("El valor por hora debe ser un monto válido mayor a 0.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorHora.Focus();
                return false;
            }

            if (!decimal.TryParse(txtMateriales.Text.Trim(), out decimal costoMateriales) || costoMateriales < 0)
            {
                MessageBox.Show("El costo de materiales debe ser un número mayor o igual a 0.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMateriales.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDescuentoPorc.Text.Trim(), out decimal porcDescuento) || porcDescuento < 0 || porcDescuento > 100)
            {
                MessageBox.Show("El porcentaje de descuento debe estar entre 0 y 100.",
                    "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescuentoPorc.Focus();
                return false;
            }

            // Cálculos matemáticos del Proyecto 7
            manoObra = Math.Round(trabajadores * horas * valorHora, 0);
            decimal costoBruto = manoObra + Math.Round(costoMateriales, 0);
            montoDescuento = Math.Round(costoBruto * (porcDescuento / 100m), 0);
            subtotal = costoBruto - montoDescuento;
            iva = Math.Round(subtotal * 0.19m, 0);
            total = subtotal + iva;

            // Mostrar resultados en los 5 Labels
            lblManoObra.Text = $"${manoObra:N0}";
            lblDescuento.Text = $"-${montoDescuento:N0} ({porcDescuento}%)";
            lblSubtotal.Text = $"${subtotal:N0}";
            lblIva.Text = $"${iva:N0}";
            lblTotal.Text = $"${total:N0}";

            return true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidarYCalcular();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarYCalcular())
            {
                return;
            }

            try
            {
                if (!File.Exists(rutaCsv))
                {
                    string encabezado = "NumeroServicio,Fecha,Cliente,RUT,Direccion,TipoLimpieza,Trabajadores,Horas,ValorHora,ManoObra,CostoMateriales,PorcentajeDescuento,MontoDescuento,Subtotal,IVA,Total,Estado";
                    File.WriteAllText(rutaCsv, encabezado + Environment.NewLine, Encoding.UTF8);
                }

                string numServicio = txtNumServicio.Text.Trim().Replace(",", " ");
                string fecha = dtpFecha.Value.ToString("dd-MM-yyyy");
                string cliente = txtCliente.Text.Trim().Replace(",", " ");
                string rut = txtRut.Text.Trim().Replace(",", " ");
                string direccion = txtDireccion.Text.Trim().Replace(",", " - ");
                string tipoLimpieza = cmbTipoLimpieza.SelectedItem.ToString();
                string trabajadores = txtTrabajadores.Text.Trim();
                string horas = txtHoras.Text.Trim().Replace(',', '.');
                string valorHora = Math.Round(decimal.Parse(txtValorHora.Text.Trim()), 0).ToString();
                string materiales = Math.Round(decimal.Parse(txtMateriales.Text.Trim()), 0).ToString();
                string porcDesc = txtDescuentoPorc.Text.Trim().Replace(',', '.');
                string estado = cmbEstado.SelectedItem.ToString();

                string nuevaLinea = string.Join(",",
                    numServicio,
                    fecha,
                    cliente,
                    rut,
                    direccion,
                    tipoLimpieza,
                    trabajadores,
                    horas,
                    valorHora,
                    manoObra,
                    materiales,
                    porcDesc,
                    montoDescuento,
                    subtotal,
                    iva,
                    total,
                    estado
                );

                File.AppendAllText(rutaCsv, nuevaLinea + Environment.NewLine, Encoding.UTF8);

                MessageBox.Show("Servicio guardado correctamente en servicios_limpieza.csv.",
                    "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo CSV: {ex.Message}",
                    "Error de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNumServicio.Clear();
            dtpFecha.Value = DateTime.Now;
            txtCliente.Clear();
            txtRut.Clear();
            txtDireccion.Clear();
            cmbTipoLimpieza.SelectedIndex = -1;
            txtTrabajadores.Clear();
            txtHoras.Clear();
            txtValorHora.Clear();
            txtMateriales.Clear();
            txtDescuentoPorc.Text = "0";
            cmbEstado.SelectedIndex = 0;
            ReiniciarEtiquetasCalculo();
            txtNumServicio.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos previos conservados para mantener compatibilidad con el diseñador
        private void Registro_de_servicios_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dtpFecha_ValueChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void labelNomCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescuento_Click(object sender, EventArgs e)
        {

        }
    }
}