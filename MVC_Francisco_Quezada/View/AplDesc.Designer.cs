
namespace MVC_Francisco_Quezada.View
{
    partial class AplDesc
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
            this.components = new System.ComponentModel.Container();
            this.saludo = new System.Windows.Forms.Label();
            this.dgvVehic = new System.Windows.Forms.DataGridView();
            this.autosNARLADataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autosNARLADataSet = new MVC_Francisco_Quezada.AutosNARLADataSet();
            this.Ingrese = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtpreciofin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.txtpreventa = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.Preventa = new System.Windows.Forms.Label();
            this.Aplicar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.autosNARLADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecioFinal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Location = new System.Drawing.Point(366, 19);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(138, 13);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Selecciones esos vehiculos";
            this.saludo.Click += new System.EventHandler(this.saludo_Click);
            // 
            // dgvVehic
            // 
            this.dgvVehic.AllowUserToOrderColumns = true;
            this.dgvVehic.AutoGenerateColumns = false;
            this.dgvVehic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehic.DataSource = this.autosNARLADataSetBindingSource1;
            this.dgvVehic.Location = new System.Drawing.Point(265, 35);
            this.dgvVehic.Name = "dgvVehic";
            this.dgvVehic.Size = new System.Drawing.Size(362, 150);
            this.dgvVehic.TabIndex = 1;
            this.dgvVehic.SelectionChanged += new System.EventHandler(this.dgvVehic_SelectionChanged);
            // 
            // autosNARLADataSetBindingSource1
            // 
            this.autosNARLADataSetBindingSource1.DataSource = this.autosNARLADataSet;
            this.autosNARLADataSetBindingSource1.Position = 0;
            // 
            // autosNARLADataSet
            // 
            this.autosNARLADataSet.DataSetName = "AutosNARLADataSet";
            this.autosNARLADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ingrese
            // 
            this.Ingrese.AutoSize = true;
            this.Ingrese.Location = new System.Drawing.Point(49, 209);
            this.Ingrese.Name = "Ingrese";
            this.Ingrese.Size = new System.Drawing.Size(180, 13);
            this.Ingrese.TabIndex = 2;
            this.Ingrese.Text = "Ingrese el porcentaje de descuento: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 234);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtpreciofin
            // 
            this.txtpreciofin.Location = new System.Drawing.Point(330, 234);
            this.txtpreciofin.Name = "txtpreciofin";
            this.txtpreciofin.Size = new System.Drawing.Size(100, 20);
            this.txtpreciofin.TabIndex = 4;
            this.txtpreciofin.TextChanged += new System.EventHandler(this.txtpreciofin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio con su descuento:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(146, 86);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(100, 20);
            this.txtmodelo.TabIndex = 6;
            this.txtmodelo.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // txtpreventa
            // 
            this.txtpreventa.Location = new System.Drawing.Point(146, 128);
            this.txtpreventa.Name = "txtpreventa";
            this.txtpreventa.Size = new System.Drawing.Size(100, 20);
            this.txtpreventa.TabIndex = 7;
            this.txtpreventa.TextChanged += new System.EventHandler(this.txtpreventa_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(146, 49);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 8;
            this.txtmarca.TextChanged += new System.EventHandler(this.txtmarca_TextChanged);
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(96, 52);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 9;
            this.Marca.Text = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(96, 93);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(42, 13);
            this.Modelo.TabIndex = 10;
            this.Modelo.Text = "Modelo";
            // 
            // Preventa
            // 
            this.Preventa.AutoSize = true;
            this.Preventa.Location = new System.Drawing.Point(56, 135);
            this.Preventa.Name = "Preventa";
            this.Preventa.Size = new System.Drawing.Size(82, 13);
            this.Preventa.TabIndex = 11;
            this.Preventa.Text = "Precio de venta";
            // 
            // Aplicar
            // 
            this.Aplicar.Location = new System.Drawing.Point(265, 293);
            this.Aplicar.Name = "Aplicar";
            this.Aplicar.Size = new System.Drawing.Size(75, 23);
            this.Aplicar.TabIndex = 12;
            this.Aplicar.Text = "Aplicar Descuento";
            this.Aplicar.UseVisualStyleBackColor = true;
            this.Aplicar.Click += new System.EventHandler(this.Aplicar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(462, 293);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // autosNARLADataSetBindingSource
            // 
            this.autosNARLADataSetBindingSource.DataSource = this.autosNARLADataSet;
            this.autosNARLADataSetBindingSource.Position = 0;
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.AutoSize = true;
            this.txtPrecioFinal.Location = new System.Drawing.Point(570, 209);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(62, 13);
            this.txtPrecioFinal.TabIndex = 14;
            this.txtPrecioFinal.Text = "Precio Final";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AplDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aplicar);
            this.Controls.Add(this.Preventa);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtpreventa);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpreciofin);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Ingrese);
            this.Controls.Add(this.dgvVehic);
            this.Controls.Add(this.saludo);
            this.Name = "AplDesc";
            this.Text = "AplDesc";
            this.Load += new System.EventHandler(this.AplDesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.DataGridView dgvVehic;
        private System.Windows.Forms.Label Ingrese;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtpreciofin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtpreventa;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label Preventa;
        private System.Windows.Forms.Button Aplicar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.BindingSource autosNARLADataSetBindingSource1;
        private AutosNARLADataSet autosNARLADataSet;
        private System.Windows.Forms.BindingSource autosNARLADataSetBindingSource;
        private System.Windows.Forms.Label txtPrecioFinal;
        private System.Windows.Forms.TextBox textBox1;
    }
}