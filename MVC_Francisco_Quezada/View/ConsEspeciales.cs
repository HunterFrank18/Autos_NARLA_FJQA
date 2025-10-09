using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Francisco_Quezada.View
{
    public partial class ConsEspeciales : Form
    {
        public ConsEspeciales()
        {
            InitializeComponent();
        }

        private void ConsEspeciales_Load(object sender, EventArgs e)
        {

        }

        private void btnmasantiguo_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("Cilindraje");
            tabla.Columns.Add("AñoFabricacion");

            // Luego: SELECT TOP 1 ... ORDER BY Cilindraje DESC
            tabla.Rows.Add("B202", "Nissan", "350Z", "3.5", "2010");

            dgvResultado.DataSource = tabla;
        }

        private void btnclindraje_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("Cilindraje");

            // Luego: SELECT TOP 1 ... ORDER BY Cilindraje DESC
            tabla.Rows.Add("B202", "Nissan", "350Z", "3.5");

            dgvResultado.DataSource = tabla;
        }

        private void btnmasbajo_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Codigo");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Modelo");
            tabla.Columns.Add("PrecioVenta");

            // Luego: SELECT TOP 1 ... ORDER BY PrecioVenta ASC
            tabla.Rows.Add("C303", "Kia", "Rio", "7500");

            dgvResultado.DataSource = tabla;
        }
    }
}
