
namespace MVC_Francisco_Quezada.View
{
    partial class FiltBusqueda
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
            this.Filtremos = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.AñoProd = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.AñoProd1 = new System.Windows.Forms.TextBox();
            this.Modelo1 = new System.Windows.Forms.TextBox();
            this.CateID = new System.Windows.Forms.TextBox();
            this.PrecioMax1 = new System.Windows.Forms.TextBox();
            this.PrecioMin1 = new System.Windows.Forms.TextBox();
            this.PrecioMin = new System.Windows.Forms.Label();
            this.PrecioMax = new System.Windows.Forms.Label();
            this.Buscar1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtremos
            // 
            this.Filtremos.AutoSize = true;
            this.Filtremos.Location = new System.Drawing.Point(340, 27);
            this.Filtremos.Name = "Filtremos";
            this.Filtremos.Size = new System.Drawing.Size(120, 13);
            this.Filtremos.TabIndex = 0;
            this.Filtremos.Text = "Filtremos tus busquedas";
            // 
            // Modelo
            // 
            this.Modelo.AutoSize = true;
            this.Modelo.Location = new System.Drawing.Point(52, 81);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(42, 13);
            this.Modelo.TabIndex = 1;
            this.Modelo.Text = "Modelo";
            // 
            // AñoProd
            // 
            this.AñoProd.AutoSize = true;
            this.AñoProd.Location = new System.Drawing.Point(278, 81);
            this.AñoProd.Name = "AñoProd";
            this.AñoProd.Size = new System.Drawing.Size(98, 13);
            this.AñoProd.TabIndex = 2;
            this.AñoProd.Text = "Año de Produccion";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(567, 75);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 3;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // AñoProd1
            // 
            this.AñoProd1.Location = new System.Drawing.Point(393, 78);
            this.AñoProd1.Name = "AñoProd1";
            this.AñoProd1.Size = new System.Drawing.Size(100, 20);
            this.AñoProd1.TabIndex = 4;
            // 
            // Modelo1
            // 
            this.Modelo1.Location = new System.Drawing.Point(121, 78);
            this.Modelo1.Name = "Modelo1";
            this.Modelo1.Size = new System.Drawing.Size(100, 20);
            this.Modelo1.TabIndex = 5;
            // 
            // CateID
            // 
            this.CateID.Location = new System.Drawing.Point(567, 170);
            this.CateID.Name = "CateID";
            this.CateID.Size = new System.Drawing.Size(100, 20);
            this.CateID.TabIndex = 6;
            // 
            // PrecioMax1
            // 
            this.PrecioMax1.Location = new System.Drawing.Point(343, 170);
            this.PrecioMax1.Name = "PrecioMax1";
            this.PrecioMax1.Size = new System.Drawing.Size(100, 20);
            this.PrecioMax1.TabIndex = 7;
            // 
            // PrecioMin1
            // 
            this.PrecioMin1.Location = new System.Drawing.Point(121, 170);
            this.PrecioMin1.Name = "PrecioMin1";
            this.PrecioMin1.Size = new System.Drawing.Size(100, 20);
            this.PrecioMin1.TabIndex = 8;
            // 
            // PrecioMin
            // 
            this.PrecioMin.AutoSize = true;
            this.PrecioMin.Location = new System.Drawing.Point(21, 173);
            this.PrecioMin.Name = "PrecioMin";
            this.PrecioMin.Size = new System.Drawing.Size(73, 13);
            this.PrecioMin.TabIndex = 9;
            this.PrecioMin.Text = "Precio Minimo";
            // 
            // PrecioMax
            // 
            this.PrecioMax.AutoSize = true;
            this.PrecioMax.Location = new System.Drawing.Point(251, 173);
            this.PrecioMax.Name = "PrecioMax";
            this.PrecioMax.Size = new System.Drawing.Size(76, 13);
            this.PrecioMax.TabIndex = 10;
            this.PrecioMax.Text = "Precio Maximo";
            // 
            // Buscar1
            // 
            this.Buscar1.Location = new System.Drawing.Point(701, 170);
            this.Buscar1.Name = "Buscar1";
            this.Buscar1.Size = new System.Drawing.Size(75, 23);
            this.Buscar1.TabIndex = 11;
            this.Buscar1.Text = "Buscar";
            this.Buscar1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "CategoriaID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(94, 213);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(620, 225);
            this.dgvResult.TabIndex = 14;
            // 
            // FiltBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Buscar1);
            this.Controls.Add(this.PrecioMax);
            this.Controls.Add(this.PrecioMin);
            this.Controls.Add(this.PrecioMin1);
            this.Controls.Add(this.PrecioMax1);
            this.Controls.Add(this.CateID);
            this.Controls.Add(this.Modelo1);
            this.Controls.Add(this.AñoProd1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.AñoProd);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Filtremos);
            this.Name = "FiltBusqueda";
            this.Text = "FiltBusqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Filtremos;
        private System.Windows.Forms.Label Modelo;
        private System.Windows.Forms.Label AñoProd;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox AñoProd1;
        private System.Windows.Forms.TextBox Modelo1;
        private System.Windows.Forms.TextBox CateID;
        private System.Windows.Forms.TextBox PrecioMax1;
        private System.Windows.Forms.TextBox PrecioMin1;
        private System.Windows.Forms.Label PrecioMin;
        private System.Windows.Forms.Label PrecioMax;
        private System.Windows.Forms.Button Buscar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}