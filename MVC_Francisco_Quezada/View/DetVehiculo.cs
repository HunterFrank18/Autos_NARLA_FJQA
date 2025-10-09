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
using MVC_Francisco_Quezada.Models;

namespace MVC_Francisco_Quezada.View
{
    public partial class DetVehiculo : Form
    {
        public DetVehiculo()
        {
            InitializeComponent();
        }

        private void DetVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void Pict3_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            string codigo = ingcod.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingresa un código de vehículo.");
                return;
            }

            DetVehiculoController controller = new DetVehiculoController();
            Auto auto = controller.ObtenerVehiculoPorCodigo(codigo);

            if (auto != null)
            {
                label5.Text = auto.Marca;
                label6.Text = auto.Modelo;
                label7.Text = auto.AñoFabricacion.ToString();
                label8.Text = auto.PrecioVenta.ToString("C");

                // Las fotos de momento pueden quedar vacías o un placeholder
                // pb1.Image = Image.FromFile("ruta_placeholder.png");
            }
            else
            {
                MessageBox.Show("Vehículo no encontrado.");
                label5.Text = "-";
                label6.Text = "-";
                label7.Text = "-";
                label8.Text = "-";
            }
        }
    }
}

