
namespace MVC_Francisco_Quezada.View
{
    partial class RegVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saludo = new System.Windows.Forms.Label();
            this.dgvvehiculo = new System.Windows.Forms.DataGridView();
            this.txtVenta = new System.Windows.Forms.Label();
            this.txtAuto = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtventaID = new System.Windows.Forms.TextBox();
            this.txtAutoID = new System.Windows.Forms.TextBox();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.Registrar = new System.Windows.Forms.Button();
            this.Abortar = new System.Windows.Forms.Button();
            this.dgvreporteventas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporteventas)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Location = new System.Drawing.Point(358, 13);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(126, 13);
            this.saludo.TabIndex = 1;
            this.saludo.Text = "Registremos esas Ventas";
            this.saludo.Click += new System.EventHandler(this.saludo_Click);
            // 
            // dgvvehiculo
            // 
            this.dgvvehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvehiculo.Location = new System.Drawing.Point(205, 29);
            this.dgvvehiculo.Name = "dgvvehiculo";
            this.dgvvehiculo.Size = new System.Drawing.Size(434, 181);
            this.dgvvehiculo.TabIndex = 2;
            this.dgvvehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvehiculo_CellContentClick);
            // 
            // txtVenta
            // 
            this.txtVenta.AutoSize = true;
            this.txtVenta.Location = new System.Drawing.Point(52, 244);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(46, 13);
            this.txtVenta.TabIndex = 3;
            this.txtVenta.Text = "VentaID";
            this.txtVenta.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAuto
            // 
            this.txtAuto.AutoSize = true;
            this.txtAuto.Location = new System.Drawing.Point(222, 244);
            this.txtAuto.Name = "txtAuto";
            this.txtAuto.Size = new System.Drawing.Size(40, 13);
            this.txtAuto.TabIndex = 4;
            this.txtAuto.Text = "AutoID";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.Location = new System.Drawing.Point(324, 310);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(50, 13);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.Text = "ClienteID";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.AutoSize = true;
            this.txtEmpleado.Location = new System.Drawing.Point(417, 247);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(65, 13);
            this.txtEmpleado.TabIndex = 6;
            this.txtEmpleado.Text = "EmpleadoID";
            this.txtEmpleado.Click += new System.EventHandler(this.txtEmpleado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "FechaVenta";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(519, 314);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(62, 13);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "Precio Final";
            // 
            // txtventaID
            // 
            this.txtventaID.Location = new System.Drawing.Point(116, 244);
            this.txtventaID.Name = "txtventaID";
            this.txtventaID.Size = new System.Drawing.Size(100, 20);
            this.txtventaID.TabIndex = 9;
            this.txtventaID.TextChanged += new System.EventHandler(this.txtventaID_TextChanged);
            // 
            // txtAutoID
            // 
            this.txtAutoID.Location = new System.Drawing.Point(282, 244);
            this.txtAutoID.Name = "txtAutoID";
            this.txtAutoID.Size = new System.Drawing.Size(100, 20);
            this.txtAutoID.TabIndex = 10;
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.Location = new System.Drawing.Point(506, 244);
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleadoID.TabIndex = 11;
            this.txtEmpleadoID.TextChanged += new System.EventHandler(this.txtEmpleadoID_TextChanged);
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(384, 307);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(100, 20);
            this.txtClienteID.TabIndex = 13;
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(608, 307);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioFinal.TabIndex = 14;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(104, 307);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 15;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(268, 349);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(129, 33);
            this.Registrar.TabIndex = 16;
            this.Registrar.Text = "Registrar Venta";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Abortar
            // 
            this.Abortar.Location = new System.Drawing.Point(442, 349);
            this.Abortar.Name = "Abortar";
            this.Abortar.Size = new System.Drawing.Size(129, 33);
            this.Abortar.TabIndex = 17;
            this.Abortar.Text = "Abortar";
            this.Abortar.UseVisualStyleBackColor = true;
            // 
            // dgvreporteventas
            // 
            this.dgvreporteventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreporteventas.Location = new System.Drawing.Point(116, 388);
            this.dgvreporteventas.Name = "dgvreporteventas";
            this.dgvreporteventas.Size = new System.Drawing.Size(604, 104);
            this.dgvreporteventas.TabIndex = 18;
            // 
            // RegVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 504);
            this.Controls.Add(this.dgvreporteventas);
            this.Controls.Add(this.Abortar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.dtpFechaVenta);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtEmpleadoID);
            this.Controls.Add(this.txtAutoID);
            this.Controls.Add(this.txtventaID);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtAuto);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.dgvvehiculo);
            this.Controls.Add(this.saludo);
            this.Name = "RegVenta";
            this.Text = "RegVenta";
            this.Load += new System.EventHandler(this.RegVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreporteventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.DataGridView dgvvehiculo;
        private System.Windows.Forms.Label txtVenta;
        private System.Windows.Forms.Label txtAuto;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label txtEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.TextBox txtventaID;
        private System.Windows.Forms.TextBox txtAutoID;
        private System.Windows.Forms.TextBox txtEmpleadoID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Abortar;
        private System.Windows.Forms.DataGridView dgvreporteventas;
    }
}