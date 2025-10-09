
namespace MVC_Francisco_Quezada.View
{
    partial class AdVehiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutoID = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtCilindraje = new System.Windows.Forms.TextBox();
            this.txtAprod = new System.Windows.Forms.TextBox();
            this.txtAfab = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.tipove = new System.Windows.Forms.ComboBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecompra = new System.Windows.Forms.TextBox();
            this.Cat1D = new System.Windows.Forms.NumericUpDown();
            this.Prov1D = new System.Windows.Forms.NumericUpDown();
            this.Stock1 = new System.Windows.Forms.NumericUpDown();
            this.Registrar = new System.Windows.Forms.Button();
            this.AutoID = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.AñoFabr = new System.Windows.Forms.Label();
            this.AñoProd = new System.Windows.Forms.Label();
            this.Cilindraje = new System.Windows.Forms.Label();
            this.Tipoveh = new System.Windows.Forms.Label();
            this.PrecioCompra = new System.Windows.Forms.Label();
            this.PrecioVenta = new System.Windows.Forms.Label();
            this.CatID = new System.Windows.Forms.Label();
            this.ProvID = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cat1D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prov1D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregue los vehiculos que desee";
            // 
            // txtAutoID
            // 
            this.txtAutoID.Location = new System.Drawing.Point(88, 91);
            this.txtAutoID.Name = "txtAutoID";
            this.txtAutoID.Size = new System.Drawing.Size(100, 20);
            this.txtAutoID.TabIndex = 1;
            this.txtAutoID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(421, 91);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 2;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(259, 91);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtCilindraje
            // 
            this.txtCilindraje.Location = new System.Drawing.Point(421, 157);
            this.txtCilindraje.Name = "txtCilindraje";
            this.txtCilindraje.Size = new System.Drawing.Size(100, 20);
            this.txtCilindraje.TabIndex = 4;
            this.txtCilindraje.TextChanged += new System.EventHandler(this.txtCilindraje_TextChanged);
            // 
            // txtAprod
            // 
            this.txtAprod.Location = new System.Drawing.Point(259, 157);
            this.txtAprod.Name = "txtAprod";
            this.txtAprod.Size = new System.Drawing.Size(100, 20);
            this.txtAprod.TabIndex = 5;
            this.txtAprod.TextChanged += new System.EventHandler(this.txtAprod_TextChanged);
            // 
            // txtAfab
            // 
            this.txtAfab.Location = new System.Drawing.Point(88, 157);
            this.txtAfab.Name = "txtAfab";
            this.txtAfab.Size = new System.Drawing.Size(100, 20);
            this.txtAfab.TabIndex = 6;
            this.txtAfab.TextChanged += new System.EventHandler(this.txtAfab_TextChanged);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(573, 91);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // tipove
            // 
            this.tipove.FormattingEnabled = true;
            this.tipove.Items.AddRange(new object[] {
            "325",
            "350Z",
            "370Z",
            "530",
            "57",
            "80",
            "A8",
            "Acadia",
            "Cabriolet",
            "Cayman",
            "Challenger",
            "Charger",
            "CLS-Class",
            "Dakota",
            "DTS",
            "Elantra",
            "ES",
            "Escalade ESV",
            "Escape",
            "F350",
            "FR-S",
            "Galant",
            "Impala",
            "Journey",
            "Legacy",
            "LS",
            "M-Class",
            "Mulsanne",
            "Murcielago",
            "New Beetle",
            "Optima",
            "Pajero",
            "Ram 1500",
            "Ram Van 3500",
            "Ranger",
            "Rapide",
            "Riviera",
            "SL-Class",
            "Sonata",
            "Stealth",
            "Storm",
            "Sunfire",
            "Tacoma",
            "Trans Sport",
            "Trooper",
            "Voyager"});
            this.tipove.Location = new System.Drawing.Point(573, 157);
            this.tipove.Name = "tipove";
            this.tipove.Size = new System.Drawing.Size(121, 21);
            this.tipove.TabIndex = 8;
            this.tipove.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(259, 227);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 9;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // txtPrecompra
            // 
            this.txtPrecompra.Location = new System.Drawing.Point(88, 227);
            this.txtPrecompra.Name = "txtPrecompra";
            this.txtPrecompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecompra.TabIndex = 10;
            this.txtPrecompra.TextChanged += new System.EventHandler(this.txtPrecompra_TextChanged);
            // 
            // Cat1D
            // 
            this.Cat1D.Location = new System.Drawing.Point(421, 227);
            this.Cat1D.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Cat1D.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cat1D.Name = "Cat1D";
            this.Cat1D.Size = new System.Drawing.Size(120, 20);
            this.Cat1D.TabIndex = 11;
            this.Cat1D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cat1D.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Prov1D
            // 
            this.Prov1D.Location = new System.Drawing.Point(573, 226);
            this.Prov1D.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Prov1D.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prov1D.Name = "Prov1D";
            this.Prov1D.Size = new System.Drawing.Size(120, 20);
            this.Prov1D.TabIndex = 12;
            this.Prov1D.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Prov1D.ValueChanged += new System.EventHandler(this.Prov1D_ValueChanged);
            // 
            // Stock1
            // 
            this.Stock1.Location = new System.Drawing.Point(88, 293);
            this.Stock1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Stock1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Stock1.Name = "Stock1";
            this.Stock1.Size = new System.Drawing.Size(120, 20);
            this.Stock1.TabIndex = 13;
            this.Stock1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Stock1.ValueChanged += new System.EventHandler(this.Stock1_ValueChanged);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(336, 357);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(130, 40);
            this.Registrar.TabIndex = 14;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // AutoID
            // 
            this.AutoID.AutoSize = true;
            this.AutoID.Location = new System.Drawing.Point(121, 75);
            this.AutoID.Name = "AutoID";
            this.AutoID.Size = new System.Drawing.Size(40, 13);
            this.AutoID.TabIndex = 15;
            this.AutoID.Text = "AutoID";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(291, 75);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 16;
            this.Codigo.Text = "Codigo";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(450, 75);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 17;
            this.Marca.Text = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(594, 75);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(42, 13);
            this.Modelo.TabIndex = 18;
            this.Modelo.Text = "Modelo";
            // 
            // AñoFabr
            // 
            this.AñoFabr.AutoSize = true;
            this.AñoFabr.Location = new System.Drawing.Point(89, 141);
            this.AñoFabr.Name = "AñoFabr";
            this.AñoFabr.Size = new System.Drawing.Size(99, 13);
            this.AñoFabr.TabIndex = 19;
            this.AñoFabr.Text = "Año de Fabricacion";
            // 
            // AñoProd
            // 
            this.AñoProd.AutoSize = true;
            this.AñoProd.Location = new System.Drawing.Point(261, 141);
            this.AñoProd.Name = "AñoProd";
            this.AñoProd.Size = new System.Drawing.Size(98, 13);
            this.AñoProd.TabIndex = 20;
            this.AñoProd.Text = "Año de Produccion";
            // 
            // Cilindraje
            // 
            this.Cilindraje.AutoSize = true;
            this.Cilindraje.Location = new System.Drawing.Point(450, 141);
            this.Cilindraje.Name = "Cilindraje";
            this.Cilindraje.Size = new System.Drawing.Size(49, 13);
            this.Cilindraje.TabIndex = 21;
            this.Cilindraje.Text = "Cilindraje";
            // 
            // Tipoveh
            // 
            this.Tipoveh.AutoSize = true;
            this.Tipoveh.Location = new System.Drawing.Point(594, 141);
            this.Tipoveh.Name = "Tipoveh";
            this.Tipoveh.Size = new System.Drawing.Size(86, 13);
            this.Tipoveh.TabIndex = 22;
            this.Tipoveh.Text = "Tipo de vehiculo";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSize = true;
            this.PrecioCompra.Location = new System.Drawing.Point(89, 210);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(91, 13);
            this.PrecioCompra.TabIndex = 23;
            this.PrecioCompra.Text = "Precio de Compra";
            this.PrecioCompra.Click += new System.EventHandler(this.label10_Click);
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSize = true;
            this.PrecioVenta.Location = new System.Drawing.Point(261, 210);
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Size = new System.Drawing.Size(83, 13);
            this.PrecioVenta.TabIndex = 24;
            this.PrecioVenta.Text = "Precio de Venta";
            // 
            // CatID
            // 
            this.CatID.AutoSize = true;
            this.CatID.Location = new System.Drawing.Point(444, 211);
            this.CatID.Name = "CatID";
            this.CatID.Size = new System.Drawing.Size(63, 13);
            this.CatID.TabIndex = 25;
            this.CatID.Text = "CategoriaID";
            // 
            // ProvID
            // 
            this.ProvID.AutoSize = true;
            this.ProvID.Location = new System.Drawing.Point(588, 210);
            this.ProvID.Name = "ProvID";
            this.ProvID.Size = new System.Drawing.Size(67, 13);
            this.ProvID.TabIndex = 26;
            this.ProvID.Text = "ProveedorID";
            this.ProvID.Click += new System.EventHandler(this.label13_Click);
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(115, 277);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(35, 13);
            this.Stock.TabIndex = 27;
            this.Stock.Text = "Stock";
            // 
            // AdVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.ProvID);
            this.Controls.Add(this.CatID);
            this.Controls.Add(this.PrecioVenta);
            this.Controls.Add(this.PrecioCompra);
            this.Controls.Add(this.Tipoveh);
            this.Controls.Add(this.Cilindraje);
            this.Controls.Add(this.AñoProd);
            this.Controls.Add(this.AñoFabr);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.AutoID);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Stock1);
            this.Controls.Add(this.Prov1D);
            this.Controls.Add(this.Cat1D);
            this.Controls.Add(this.txtPrecompra);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.tipove);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtAfab);
            this.Controls.Add(this.txtAprod);
            this.Controls.Add(this.txtCilindraje);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtAutoID);
            this.Controls.Add(this.label1);
            this.Name = "AdVehiculo";
            this.Text = "AdVehiculo";
            this.Load += new System.EventHandler(this.AdVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cat1D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prov1D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stock1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutoID;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtCilindraje;
        private System.Windows.Forms.TextBox txtAprod;
        private System.Windows.Forms.TextBox txtAfab;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox tipove;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecompra;
        private System.Windows.Forms.NumericUpDown Cat1D;
        private System.Windows.Forms.NumericUpDown Prov1D;
        private System.Windows.Forms.NumericUpDown Stock1;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Label AutoID;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label AñoFabr;
        private System.Windows.Forms.Label AñoProd;
        private System.Windows.Forms.Label Cilindraje;
        private System.Windows.Forms.Label Tipoveh;
        private System.Windows.Forms.Label PrecioCompra;
        private System.Windows.Forms.Label PrecioVenta;
        private System.Windows.Forms.Label CatID;
        private System.Windows.Forms.Label ProvID;
        private System.Windows.Forms.Label Stock;
    }
}