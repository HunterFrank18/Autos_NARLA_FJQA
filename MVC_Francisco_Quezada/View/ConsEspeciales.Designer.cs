
namespace MVC_Francisco_Quezada.View
{
    partial class ConsEspeciales
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
            this.btnmasantiguo = new System.Windows.Forms.Button();
            this.btnclindraje = new System.Windows.Forms.Button();
            this.btnmasbajo = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.autosNARLADataSet1 = new MVC_Francisco_Quezada.AutosNARLADataSet1();
            this.autosNARLADataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autosNARLADataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Location = new System.Drawing.Point(303, 36);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(192, 13);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Haga sus consultas especiales por aca";
            // 
            // btnmasantiguo
            // 
            this.btnmasantiguo.Location = new System.Drawing.Point(86, 74);
            this.btnmasantiguo.Name = "btnmasantiguo";
            this.btnmasantiguo.Size = new System.Drawing.Size(198, 23);
            this.btnmasantiguo.TabIndex = 1;
            this.btnmasantiguo.Text = "Vehiculo mas antiguo";
            this.btnmasantiguo.UseVisualStyleBackColor = true;
            this.btnmasantiguo.Click += new System.EventHandler(this.btnmasantiguo_Click);
            // 
            // btnclindraje
            // 
            this.btnclindraje.Location = new System.Drawing.Point(342, 74);
            this.btnclindraje.Name = "btnclindraje";
            this.btnclindraje.Size = new System.Drawing.Size(167, 23);
            this.btnclindraje.TabIndex = 2;
            this.btnclindraje.Text = "Mayor Cilindraje";
            this.btnclindraje.UseVisualStyleBackColor = true;
            this.btnclindraje.Click += new System.EventHandler(this.btnclindraje_Click);
            // 
            // btnmasbajo
            // 
            this.btnmasbajo.Location = new System.Drawing.Point(545, 74);
            this.btnmasbajo.Name = "btnmasbajo";
            this.btnmasbajo.Size = new System.Drawing.Size(160, 23);
            this.btnmasbajo.TabIndex = 3;
            this.btnmasbajo.Text = "Precio mas bajo";
            this.btnmasbajo.UseVisualStyleBackColor = true;
            this.btnmasbajo.Click += new System.EventHandler(this.btnmasbajo_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AutoGenerateColumns = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.DataSource = this.autosNARLADataSet1BindingSource1;
            this.dgvResultado.Location = new System.Drawing.Point(86, 138);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(619, 247);
            this.dgvResultado.TabIndex = 4;
            // 
            // autosNARLADataSet1
            // 
            this.autosNARLADataSet1.DataSetName = "AutosNARLADataSet1";
            this.autosNARLADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autosNARLADataSet1BindingSource
            // 
            this.autosNARLADataSet1BindingSource.DataSource = this.autosNARLADataSet1;
            this.autosNARLADataSet1BindingSource.Position = 0;
            // 
            // autosNARLADataSet1BindingSource1
            // 
            this.autosNARLADataSet1BindingSource1.DataSource = this.autosNARLADataSet1;
            this.autosNARLADataSet1BindingSource1.Position = 0;
            // 
            // ConsEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnmasbajo);
            this.Controls.Add(this.btnclindraje);
            this.Controls.Add(this.btnmasantiguo);
            this.Controls.Add(this.saludo);
            this.Name = "ConsEspeciales";
            this.Text = "ConsEspeciales";
            this.Load += new System.EventHandler(this.ConsEspeciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosNARLADataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button btnmasantiguo;
        private System.Windows.Forms.Button btnclindraje;
        private System.Windows.Forms.Button btnmasbajo;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.BindingSource autosNARLADataSet1BindingSource;
        private AutosNARLADataSet1 autosNARLADataSet1;
        private System.Windows.Forms.BindingSource autosNARLADataSet1BindingSource1;
    }
}