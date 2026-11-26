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
    public partial class Consulta_por_Cliente : Form
    {
        private readonly string rutaCsv = Path.Combine(Application.StartupPath, "servicios_limpieza.csv");
        private DataTable tablaServicios = new DataTable();

        public Consulta_por_Cliente()
        {
            InitializeComponent();
            this.Text = "Porky - Consulta por Cliente";
            this.StartPosition = FormStartPosition.CenterScreen;
            AplicarEstilos();
            CargarDatosCsv();
        }

        private void AplicarEstilos()
        {
            // Color de fondo del formulario 
            this.BackColor = Color.FromArgb(192, 192, 255);

            // Estilo para los botones
            EstilizarBoton(btnBuscar, Color.FromArgb(236, 72, 153), Color.White);       // Rosa vibrante
            EstilizarBoton(btnMostrarTodos, Color.FromArgb(59, 130, 246), Color.White); // Azul
            EstilizarBoton(btnVolver, Color.FromArgb(107, 114, 128), Color.White);      // Gris

            // Estilo de la tabla 
            dgvServicios.BackgroundColor = Color.White;
            dgvServicios.EnableHeadersVisualStyles = false; 
            dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(236, 72, 153); 
            dgvServicios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvServicios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvServicios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 242, 248); 

            // Etiqueta de resultados y caja de texto
            lblResultados.ForeColor = Color.FromArgb(31, 41, 55);
            lblResultados.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            txtBuscarCliente.BackColor = Color.White;
        }

        private void EstilizarBoton(Button btn, Color fondo, Color texto)
        {
            btn.BackColor = fondo;
            btn.ForeColor = texto;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }




        private void CargarDatosCsv()
        {
            tablaServicios = new DataTable();

            if (!File.Exists(rutaCsv))
            {
                MessageBox.Show("Aún no existen registros guardados (el archivo servicios_limpieza.csv todavía no se ha creado).",
                    "Sin registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblResultados.Text = "Registros encontrados: 0 | Total acumulado: $0";
                return;
            }

            try
            {
                string[] lineas = File.ReadAllLines(rutaCsv, Encoding.UTF8);

                if (lineas.Length == 0)
                {
                    return;
                }

                string[] encabezados = lineas[0].Split(',');
                foreach (string col in encabezados)
                {
                    tablaServicios.Columns.Add(col.Trim());
                }

                for (int i = 1; i < lineas.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lineas[i]))
                    {
                        string[] datos = lineas[i].Split(',');
                        tablaServicios.Rows.Add(datos);
                    }
                }

                dgvServicios.DataSource = tablaServicios;
                dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvServicios.ReadOnly = true;
                dgvServicios.AllowUserToAddRows = false;

                ActualizarResumen(tablaServicios.DefaultView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo CSV: {ex.Message}",
                    "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarResumen(DataView vista)
        {
            int cantidad = vista.Count;
            decimal sumaTotales = 0;

            foreach (DataRowView fila in vista)
            {
                if (decimal.TryParse(fila["Total"].ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal totalFila))
                {
                    sumaTotales += totalFila;
                }
            }

            lblResultados.Text = $"Registros encontrados: {cantidad} | Total acumulado: ${sumaTotales:N0}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tablaServicios.Rows.Count == 0)
            {
                return;
            }

            string filtroCliente = txtBuscarCliente.Text.Trim().Replace("'", "''");

            if (string.IsNullOrEmpty(filtroCliente))
            {
                tablaServicios.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                tablaServicios.DefaultView.RowFilter = $"Cliente LIKE '%{filtroCliente}%'";
            }

            ActualizarResumen(tablaServicios.DefaultView);

            if (tablaServicios.DefaultView.Count == 0)
            {
                MessageBox.Show("No se encontraron servicios para ese cliente.",
                    "Sin coincidencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscarCliente.Clear();
            if (tablaServicios.Rows.Count > 0)
            {
                tablaServicios.DefaultView.RowFilter = string.Empty;
                ActualizarResumen(tablaServicios.DefaultView);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_por_Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}