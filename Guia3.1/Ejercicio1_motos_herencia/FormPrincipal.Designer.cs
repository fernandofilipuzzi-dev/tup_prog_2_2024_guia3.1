namespace Ejercicio1
{
    partial class FormPrincipal
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
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.tbValorFabrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupAñoCalcular = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTasaDepreciacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoCalcular)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(436, 117);
            this.btnCalcularCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(132, 52);
            this.btnCalcularCosto.TabIndex = 0;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(264, 393);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 52);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(276, 77);
            this.nupModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupModelo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupModelo.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(80, 26);
            this.nupModelo.TabIndex = 2;
            this.nupModelo.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // tbValorFabrica
            // 
            this.tbValorFabrica.Location = new System.Drawing.Point(276, 117);
            this.tbValorFabrica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbValorFabrica.Name = "tbValorFabrica";
            this.tbValorFabrica.Size = new System.Drawing.Size(146, 26);
            this.tbValorFabrica.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo (Año)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor de fabricación $";
            // 
            // nupAñoCalcular
            // 
            this.nupAñoCalcular.Location = new System.Drawing.Point(276, 67);
            this.nupAñoCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupAñoCalcular.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupAñoCalcular.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nupAñoCalcular.Name = "nupAñoCalcular";
            this.nupAñoCalcular.Size = new System.Drawing.Size(80, 26);
            this.nupAñoCalcular.TabIndex = 6;
            this.nupAñoCalcular.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Año a calcular";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(276, 41);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(146, 26);
            this.tbMarca.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca";
            // 
            // tbTasaDepreciacion
            // 
            this.tbTasaDepreciacion.Location = new System.Drawing.Point(276, 107);
            this.tbTasaDepreciacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            this.tbTasaDepreciacion.Size = new System.Drawing.Size(84, 26);
            this.tbTasaDepreciacion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tasa de depreciación:";
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(276, 143);
            this.tbVidaUtil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(84, 26);
            this.tbVidaUtil.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vida Útil(años):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nupModelo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbValorFabrica);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehículo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAnual);
            this.groupBox2.Controls.Add(this.rbLineal);
            this.groupBox2.Controls.Add(this.nupAñoCalcular);
            this.groupBox2.Controls.Add(this.btnCalcularCosto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbVidaUtil);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTasaDepreciacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 189);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo depreciación";
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(276, 25);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(68, 24);
            this.rbAnual.TabIndex = 1;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(129, 25);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(69, 24);
            this.rbLineal.TabIndex = 0;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            this.rbLineal.CheckedChanged += new System.EventHandler(this.rbLineal_CheckedChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoCalcular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown nupModelo;
        private System.Windows.Forms.TextBox tbValorFabrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupAñoCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTasaDepreciacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbLineal;
    }
}

