using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Francisco_Quezada.Models;
using MVC_Francisco_Quezada.Controllers;
using System.Data.SqlClient;

namespace MVC_Francisco_Quezada.View
{
    public partial class AdVehiculo : Form
    {
        public AdVehiculo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAfab_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAprod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCilindraje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prov1D_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Stock1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Auto nuevo = new Auto
                {
                    AutoID = int.Parse(txtAutoID.Text),
                    Codigo = int.Parse(txtcodigo.Text),
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    AñoFabricacion = int.Parse(txtAfab.Text),
                    AñoProduccion = int.Parse(txtAprod.Text),
                    Cilindraje = decimal.Parse(txtCilindraje.Text),
                    TipoVehiculo = tipove.Text,
                    PrecioCompra = decimal.Parse(txtPrecompra.Text),
                    PrecioVenta = decimal.Parse(txtPrecioVenta.Text),
                    CategoriaID = int.Parse(Cat1D.Text),
                    ProveedorID = (int)Prov1D.Value,
                    Stock = (int)Stock1.Value
                };

                AutoController control = new AutoController();
                control.InsertarVehiculo(nuevo);

                MessageBox.Show("✅ Vehículo agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar vehículo: " + ex.Message);
            }
        }
    }
}
