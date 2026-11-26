using System;
using System.Windows.Forms;

namespace Porky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Porky - Menú Principal";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIrRegistro_Click(object sender, EventArgs e)
        {
            Registro_de_servicios frmRegistro = new Registro_de_servicios();
            this.Hide();
            frmRegistro.ShowDialog();
            this.Show();
        }

        private void btnIrConsulta_Click(object sender, EventArgs e)
        {
            Consulta_por_Cliente frmConsulta = new Consulta_por_Cliente();
            this.Hide();
            frmConsulta.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema Porky?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}