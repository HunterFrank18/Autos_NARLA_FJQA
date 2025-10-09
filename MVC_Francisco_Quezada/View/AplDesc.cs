using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Francisco_Quezada.Controllers;

namespace MVC_Francisco_Quezada.View
{
    public partial class AplDesc : Form
    {
        private AutoController controller = new AutoController();

        public AplDesc()
        {
            InitializeComponent();
        }
        private void AplDesc_Load(object sender, EventArgs e)
        {
            dgvVehic.DataSource = controller.ListarVehiculo(); // cargar lista al iniciar
        }

        private void saludo_Click(object sender, EventArgs e)
        {

        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            if (dgvVehic.CurrentRow != null)
            {
                // Tomamos el precio original del TextBox
                decimal precioOriginal = decimal.Parse(txtpreventa.Text);

                // Tomamos el % de descuento del NumericUpDown
                decimal descuento = numericUpDown1.Value; // entre 0 y 10

                // Calculamos el precio final
                decimal precioFinal = precioOriginal - (precioOriginal * descuento / 100);

                // Mostramos el resultado
                txtPrecioFinal.Text = precioFinal.ToString("F2");

                MessageBox.Show($"Descuento aplicado: {descuento}%\nPrecio final: {precioFinal:C}",
                                "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("⚠️ Selecciona un vehículo primero.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


            private void txtmarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpreventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtpreventa.Text, out decimal precioOriginal))
            {
                decimal descuento = numericUpDown1.Value;
                decimal precioFinal = precioOriginal - (precioOriginal * descuento / 100);
                txtPrecioFinal.Text = precioFinal.ToString("F2");
            }
        }

        private void txtpreciofin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        private void dgvVehic_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehic.CurrentRow != null)
            {
                // Tomamos la fila seleccionada
                DataGridViewRow fila = dgvVehic.CurrentRow;

                // Llenamos los TextBox
                txtmarca.Text = fila.Cells["Marca"].Value.ToString();
                txtmodelo.Text = fila.Cells["Modelo"].Value.ToString();
                txtpreventa.Text = fila.Cells["PrecioVenta"].Value.ToString();
            }
        }
    }

}

