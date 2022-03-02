namespace IMCForm
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgrau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(122, 175);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 0;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaltura_KeyPress);
            this.txtaltura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.altura_MouseDown);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(122, 218);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(147, 345);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altura(Metros)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peso(Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IMC";
            // 
            // txtimc
            // 
            this.txtimc.Enabled = false;
            this.txtimc.Location = new System.Drawing.Point(122, 260);
            this.txtimc.Name = "txtimc";
            this.txtimc.Size = new System.Drawing.Size(100, 20);
            this.txtimc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grau";
            // 
            // txtgrau
            // 
            this.txtgrau.Enabled = false;
            this.txtgrau.Location = new System.Drawing.Point(122, 307);
            this.txtgrau.Name = "txtgrau";
            this.txtgrau.Size = new System.Drawing.Size(100, 20);
            this.txtgrau.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calcule seu IMC digitando a altura em Metros e o peso em Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgrau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.txtaltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgrau;
        private System.Windows.Forms.Label label5;
    }
}

