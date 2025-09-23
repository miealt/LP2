namespace Pimc
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
            this.mskbxPeso = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskbxPeso
            // 
            this.mskbxPeso.Location = new System.Drawing.Point(118, 101);
            this.mskbxPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxPeso.Mask = "000";
            this.mskbxPeso.Name = "mskbxPeso";
            this.mskbxPeso.Size = new System.Drawing.Size(144, 20);
            this.mskbxPeso.TabIndex = 0;
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Location = new System.Drawing.Point(118, 144);
            this.mskbxAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(144, 20);
            this.mskbxAltura.TabIndex = 1;
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Location = new System.Drawing.Point(119, 187);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(143, 20);
            this.txtIMC.TabIndex = 2;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(71, 101);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(71, 148);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(72, 190);
            this.lblIMC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(26, 13);
            this.lblIMC.TabIndex = 5;
            this.lblIMC.Text = "IMC";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(374, 54);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(92, 42);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(374, 132);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(92, 42);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(374, 213);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 42);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 300);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.mskbxPeso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskbxPeso;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

