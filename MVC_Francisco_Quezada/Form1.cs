using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_Francisco_Quezada.View;
using MVC_Francisco_Quezada.Models;
using MVC_Francisco_Quezada.Controllers;


namespace MVC_Francisco_Quezada
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AutoController controller = new AutoController();
          //  dgvListarvehiculo.DataSource = controller.ListarVehiculo();

        }

        private void Bienvenida_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear instancia del formulario de listar vehículos
            ListarVehiculo frm = new ListarVehiculo();

            // Ocultar el menú principal mientras se abre la lista
            this.Hide();

            // Evento para que cuando se cierre el formulario de listar, se muestre de nuevo el menú
            frm.FormClosed += (s, args) => this.Show();

            // Mostrar el formulario de listar vehículos
            frm.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Crear instancia del formulario de listar vehículos
            DetVehiculo frm = new DetVehiculo();

            // Ocultar el menú principal mientras se abre la lista
            this.Hide();

            // Evento para que cuando se cierre el formulario de listar, se muestre de nuevo el menú
            frm.FormClosed += (s, args) => this.Show();

            // Mostrar el formulario de listar vehículos
            frm.Show();

        }

        private void opc7_Click(object sender, EventArgs e)
        {
            ConsEspeciales frm = new ConsEspeciales();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void opc3_Click(object sender, EventArgs e)
        {
            AdVehiculo frm = new AdVehiculo();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void opc4_Click(object sender, EventArgs e)
        {
            FiltBusqueda frm = new FiltBusqueda();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void opc5_Click(object sender, EventArgs e)
        {
            RegVenta frm = new RegVenta();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }

        private void opc6_Click(object sender, EventArgs e)
        {
            AplDesc frm = new AplDesc();
            this.Hide();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
        }
    }
}
