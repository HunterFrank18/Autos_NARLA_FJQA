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
    public partial class ListarVehiculo : Form
    {
        public ListarVehiculo()
        {
            InitializeComponent();
        }

        private void AñoProd_Click(object sender, EventArgs e)
        {

        }

        private void ListarVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autosNARLADataSet.Auto' Puede moverla o quitarla según sea necesario.
            this.autoTableAdapter.Fill(this.autosNARLADataSet.Auto);

        }

        private void Modelo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AutoController controller = new AutoController();
            dgvListarvehiculo.DataSource = controller.ListarVehiculo();

        }
    }
}
