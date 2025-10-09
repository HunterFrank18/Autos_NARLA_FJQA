
namespace MVC_Francisco_Quezada
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bienvenida = new System.Windows.Forms.Label();
            this.Saludo1 = new System.Windows.Forms.Label();
            this.Opc1 = new System.Windows.Forms.Button();
            this.opc2 = new System.Windows.Forms.Button();
            this.opc5 = new System.Windows.Forms.Button();
            this.opc3 = new System.Windows.Forms.Button();
            this.opc4 = new System.Windows.Forms.Button();
            this.opc6 = new System.Windows.Forms.Button();
            this.opc7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Bienvenida.Font = new System.Drawing.Font("Bungee", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bienvenida.Location = new System.Drawing.Point(3, 9);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(796, 122);
            this.Bienvenida.TabIndex = 0;
            this.Bienvenida.Text = "Bienvenido a Autos Narla";
            this.Bienvenida.Click += new System.EventHandler(this.Bienvenida_Click);
            // 
            // Saludo1
            // 
            this.Saludo1.AutoSize = true;
            this.Saludo1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo1.Location = new System.Drawing.Point(246, 162);
            this.Saludo1.Name = "Saludo1";
            this.Saludo1.Size = new System.Drawing.Size(465, 23);
            this.Saludo1.TabIndex = 1;
            this.Saludo1.Text = "Favor elija la opcion que mas desee";
            this.Saludo1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Opc1
            // 
            this.Opc1.Location = new System.Drawing.Point(164, 240);
            this.Opc1.Name = "Opc1";
            this.Opc1.Size = new System.Drawing.Size(165, 31);
            this.Opc1.TabIndex = 2;
            this.Opc1.Text = "Listar vehículos";
            this.Opc1.UseVisualStyleBackColor = true;
            this.Opc1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opc2
            // 
            this.opc2.Location = new System.Drawing.Point(368, 239);
            this.opc2.Name = "opc2";
            this.opc2.Size = new System.Drawing.Size(190, 32);
            this.opc2.TabIndex = 3;
            this.opc2.Text = "Consultar detalle por código";
            this.opc2.UseVisualStyleBackColor = true;
            this.opc2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // opc5
            // 
            this.opc5.Location = new System.Drawing.Point(368, 313);
            this.opc5.Name = "opc5";
            this.opc5.Size = new System.Drawing.Size(190, 34);
            this.opc5.TabIndex = 4;
            this.opc5.Text = "Registrar venta";
            this.opc5.UseVisualStyleBackColor = true;
            this.opc5.Click += new System.EventHandler(this.opc5_Click);
            // 
            // opc3
            // 
            this.opc3.Location = new System.Drawing.Point(607, 239);
            this.opc3.Name = "opc3";
            this.opc3.Size = new System.Drawing.Size(160, 32);
            this.opc3.TabIndex = 5;
            this.opc3.Text = "Agregar vehículo";
            this.opc3.UseVisualStyleBackColor = true;
            this.opc3.Click += new System.EventHandler(this.opc3_Click);
            // 
            // opc4
            // 
            this.opc4.Location = new System.Drawing.Point(164, 312);
            this.opc4.Name = "opc4";
            this.opc4.Size = new System.Drawing.Size(165, 35);
            this.opc4.TabIndex = 6;
            this.opc4.Text = "Filtrar y ordenar inventario";
            this.opc4.UseVisualStyleBackColor = true;
            this.opc4.Click += new System.EventHandler(this.opc4_Click);
            // 
            // opc6
            // 
            this.opc6.Location = new System.Drawing.Point(607, 312);
            this.opc6.Name = "opc6";
            this.opc6.Size = new System.Drawing.Size(160, 35);
            this.opc6.TabIndex = 7;
            this.opc6.Text = "Aplicar descuento";
            this.opc6.UseVisualStyleBackColor = true;
            this.opc6.Click += new System.EventHandler(this.opc6_Click);
            // 
            // opc7
            // 
            this.opc7.Location = new System.Drawing.Point(368, 381);
            this.opc7.Name = "opc7";
            this.opc7.Size = new System.Drawing.Size(190, 36);
            this.opc7.TabIndex = 8;
            this.opc7.Text = "Consultas Especiales";
            this.opc7.UseVisualStyleBackColor = true;
            this.opc7.Click += new System.EventHandler(this.opc7_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.opc7);
            this.Controls.Add(this.opc6);
            this.Controls.Add(this.opc4);
            this.Controls.Add(this.opc3);
            this.Controls.Add(this.opc5);
            this.Controls.Add(this.opc2);
            this.Controls.Add(this.Opc1);
            this.Controls.Add(this.Saludo1);
            this.Controls.Add(this.Bienvenida);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Label Saludo1;
        private System.Windows.Forms.Button Opc1;
        private System.Windows.Forms.Button opc2;
        private System.Windows.Forms.Button opc5;
        private System.Windows.Forms.Button opc3;
        private System.Windows.Forms.Button opc4;
        private System.Windows.Forms.Button opc6;
        private System.Windows.Forms.Button opc7;
    }
}

