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
    public partial class RegVenta : Form
    {
        public RegVenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            int ventaID = int.Parse(txtventaID.Text);
            int autoID = int.Parse(txtAutoID.Text);
            int empleadoID = int.Parse(txtEmpleadoID.Text);
            DateTime fecha = dtpFechaVenta.Value;
            int clienteID = int.Parse(txtClienteID.Text);
            decimal precio = decimal.Parse(txtPrecioFinal.Text);

            // Aquí iría la llamada a tu Controller para insertar en la tabla Venta y actualizar stock
            MessageBox.Show($"Venta registrada:\nventaID: {ventaID} \nAutoID: {autoID} \nEmpleadoID: {empleadoID} \nClienteID: {clienteID}\nPrecio: {precio}");
        }

        private void RegVenta_Load(object sender, EventArgs e)
        {

        }

        private void txtventaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpleadoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpleado_Click(object sender, EventArgs e)
        {

        }

        private void dgvvehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saludo_Click(object sender, EventArgs e)
        {

        }
    }
}
