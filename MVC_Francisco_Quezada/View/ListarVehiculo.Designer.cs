
namespace MVC_Francisco_Quezada.View
{
    partial class ListarVehiculo
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
            this.Saludo = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Ordenepor = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Button();
            this.Marca = new System.Windows.Forms.Button();
            this.AñoFab = new System.Windows.Forms.Button();
            this.AñoProd = new System.Windows.Forms.Button();
            this.dgvListarvehiculo = new System.Windows.Forms.DataGridView();
            this.autoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoFabricacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoProduccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cilindrajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoAplicadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autosNARLADataSet = new MVC_Francisco_Quezada.AutosNARLADataSet();
            this.autoTableAdapter = new MVC_Francisco_Quezada.AutosNARLADataSetTableAdapters.AutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarvehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Location = new System.Drawing.Point(300, 18);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(239, 13);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Aca tiene todos los vehiculos que estan en stock";
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(376, 47);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(83, 27);
            this.Mostrar.TabIndex = 1;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // Ordenepor
            // 
            this.Ordenepor.AutoSize = true;
            this.Ordenepor.Location = new System.Drawing.Point(3, 428);
            this.Ordenepor.Name = "Ordenepor";
            this.Ordenepor.Size = new System.Drawing.Size(76, 13);
            this.Ordenepor.TabIndex = 3;
            this.Ordenepor.Text = "Ordenelos por:";
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(100, 423);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(75, 23);
            this.Modelo.TabIndex = 4;
            this.Modelo.Text = "Modelo";
            this.Modelo.UseVisualStyleBackColor = true;
            this.Modelo.Click += new System.EventHandler(this.Modelo_Click);
            // 
            // Marca
            // 
            this.Marca.Location = new System.Drawing.Point(210, 423);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(75, 23);
            this.Marca.TabIndex = 5;
            this.Marca.Text = "Marca";
            this.Marca.UseVisualStyleBackColor = true;
            // 
            // AñoFab
            // 
            this.AñoFab.Location = new System.Drawing.Point(303, 423);
            this.AñoFab.Name = "AñoFab";
            this.AñoFab.Size = new System.Drawing.Size(145, 23);
            this.AñoFab.TabIndex = 6;
            this.AñoFab.Text = "Año de Fabricacion";
            this.AñoFab.UseVisualStyleBackColor = true;
            // 
            // AñoProd
            // 
            this.AñoProd.Location = new System.Drawing.Point(471, 423);
            this.AñoProd.Name = "AñoProd";
            this.AñoProd.Size = new System.Drawing.Size(145, 23);
            this.AñoProd.TabIndex = 7;
            this.AñoProd.Text = "Año de Produccion";
            this.AñoProd.UseVisualStyleBackColor = true;
            this.AñoProd.Click += new System.EventHandler(this.AñoProd_Click);
            // 
            // dgvListarvehiculo
            // 
            this.dgvListarvehiculo.AllowUserToOrderColumns = true;
            this.dgvListarvehiculo.AutoGenerateColumns = false;
            this.dgvListarvehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarvehiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoIDDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.añoFabricacionDataGridViewTextBoxColumn,
            this.añoProduccionDataGridViewTextBoxColumn,
            this.cilindrajeDataGridViewTextBoxColumn,
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.precioCompraDataGridViewTextBoxColumn,
            this.precioVentaDataGridViewTextBoxColumn,
            this.descuentoAplicadoDataGridViewTextBoxColumn,
            this.categoriaIDDataGridViewTextBoxColumn,
            this.proveedorIDDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dgvListarvehiculo.DataSource = this.autoBindingSource;
            this.dgvListarvehiculo.Location = new System.Drawing.Point(26, 91);
            this.dgvListarvehiculo.Name = "dgvListarvehiculo";
            this.dgvListarvehiculo.Size = new System.Drawing.Size(744, 232);
            this.dgvListarvehiculo.TabIndex = 8;
            this.dgvListarvehiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // autoIDDataGridViewTextBoxColumn
            // 
            this.autoIDDataGridViewTextBoxColumn.DataPropertyName = "AutoID";
            this.autoIDDataGridViewTextBoxColumn.HeaderText = "AutoID";
            this.autoIDDataGridViewTextBoxColumn.Name = "autoIDDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // añoFabricacionDataGridViewTextBoxColumn
            // 
            this.añoFabricacionDataGridViewTextBoxColumn.DataPropertyName = "AñoFabricacion";
            this.añoFabricacionDataGridViewTextBoxColumn.HeaderText = "AñoFabricacion";
            this.añoFabricacionDataGridViewTextBoxColumn.Name = "añoFabricacionDataGridViewTextBoxColumn";
            // 
            // añoProduccionDataGridViewTextBoxColumn
            // 
            this.añoProduccionDataGridViewTextBoxColumn.DataPropertyName = "AñoProduccion";
            this.añoProduccionDataGridViewTextBoxColumn.HeaderText = "AñoProduccion";
            this.añoProduccionDataGridViewTextBoxColumn.Name = "añoProduccionDataGridViewTextBoxColumn";
            // 
            // cilindrajeDataGridViewTextBoxColumn
            // 
            this.cilindrajeDataGridViewTextBoxColumn.DataPropertyName = "Cilindraje";
            this.cilindrajeDataGridViewTextBoxColumn.HeaderText = "Cilindraje";
            this.cilindrajeDataGridViewTextBoxColumn.Name = "cilindrajeDataGridViewTextBoxColumn";
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            // 
            // precioCompraDataGridViewTextBoxColumn
            // 
            this.precioCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.HeaderText = "PrecioCompra";
            this.precioCompraDataGridViewTextBoxColumn.Name = "precioCompraDataGridViewTextBoxColumn";
            // 
            // precioVentaDataGridViewTextBoxColumn
            // 
            this.precioVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.HeaderText = "PrecioVenta";
            this.precioVentaDataGridViewTextBoxColumn.Name = "precioVentaDataGridViewTextBoxColumn";
            // 
            // descuentoAplicadoDataGridViewTextBoxColumn
            // 
            this.descuentoAplicadoDataGridViewTextBoxColumn.DataPropertyName = "DescuentoAplicado";
            this.descuentoAplicadoDataGridViewTextBoxColumn.HeaderText = "DescuentoAplicado";
            this.descuentoAplicadoDataGridViewTextBoxColumn.Name = "descuentoAplicadoDataGridViewTextBoxColumn";
            // 
            // categoriaIDDataGridViewTextBoxColumn
            // 
            this.categoriaIDDataGridViewTextBoxColumn.DataPropertyName = "CategoriaID";
            this.categoriaIDDataGridViewTextBoxColumn.HeaderText = "CategoriaID";
            this.categoriaIDDataGridViewTextBoxColumn.Name = "categoriaIDDataGridViewTextBoxColumn";
            // 
            // proveedorIDDataGridViewTextBoxColumn
            // 
            this.proveedorIDDataGridViewTextBoxColumn.DataPropertyName = "ProveedorID";
            this.proveedorIDDataGridViewTextBoxColumn.HeaderText = "ProveedorID";
            this.proveedorIDDataGridViewTextBoxColumn.Name = "proveedorIDDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "Auto";
            this.autoBindingSource.DataSource = this.autosNARLADataSet;
            // 
            // autosNARLADataSet
            // 
            this.autosNARLADataSet.DataSetName = "AutosNARLADataSet";
            this.autosNARLADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // ListarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarvehiculo);
            this.Controls.Add(this.AñoProd);
            this.Controls.Add(this.AñoFab);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Ordenepor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Saludo);
            this.Name = "ListarVehiculo";
            this.Text = "ListarVehiculo";
            this.Load += new System.EventHandler(this.ListarVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarvehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button Mostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ordenepor;
        private System.Windows.Forms.Button Modelo;
        private System.Windows.Forms.Button Marca;
        private System.Windows.Forms.Button AñoFab;
        private System.Windows.Forms.Button AñoProd;
        private System.Windows.Forms.DataGridView dgvListarvehiculo;
        private AutosNARLADataSet autosNARLADataSet;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private AutosNARLADataSetTableAdapters.AutoTableAdapter autoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoFabricacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoProduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cilindrajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoAplicadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}