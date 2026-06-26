namespace Ejercicio_del_Mes
{
    partial class Form1
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
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_extra = new System.Windows.Forms.Label();
            this.txt_extra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_horas = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Items.AddRange(new object[] {
            "Motocicleta",
            "Automovil",
            "Camioneta"});
            this.cboVehiculo.Location = new System.Drawing.Point(118, 91);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cboVehiculo.TabIndex = 0;
            this.cboVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboVehiculo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion de cobro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de vehiculo";
            // 
            // lbl_extra
            // 
            this.lbl_extra.AutoSize = true;
            this.lbl_extra.Location = new System.Drawing.Point(289, 99);
            this.lbl_extra.Name = "lbl_extra";
            this.lbl_extra.Size = new System.Drawing.Size(30, 13);
            this.lbl_extra.TabIndex = 3;
            this.lbl_extra.Text = "extra";
            // 
            // txt_extra
            // 
            this.txt_extra.Location = new System.Drawing.Point(325, 96);
            this.txt_extra.Name = "txt_extra";
            this.txt_extra.Size = new System.Drawing.Size(100, 20);
            this.txt_extra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "horas :";
            // 
            // txt_horas
            // 
            this.txt_horas.Location = new System.Drawing.Point(192, 161);
            this.txt_horas.Name = "txt_horas";
            this.txt_horas.Size = new System.Drawing.Size(100, 20);
            this.txt_horas.TabIndex = 6;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(179, 277);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(276, 277);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 8;
            this.limpiar.Text = "limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(250, 209);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_horas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_extra);
            this.Controls.Add(this.lbl_extra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVehiculo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_extra;
        private System.Windows.Forms.TextBox txt_extra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_horas;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
    }
}

