
namespace Calculo_IMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtPeso = new System.Windows.Forms.TextBox();
            txtAltura = new System.Windows.Forms.TextBox();
            txtIMC = new System.Windows.Forms.TextBox();
            btnVerificar = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            btnSair = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.DarkOrange;
            label1.Location = new System.Drawing.Point(120, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(178, 23);
            label1.TabIndex = 0;
            label1.Text = "CÁLCULO DE IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(72, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 21);
            label2.TabIndex = 1;
            label2.Text = "DIGITE SEU PESO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(52, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(161, 21);
            label3.TabIndex = 2;
            label3.Text = "DIGITE SUA ALTURA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(124, 131);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 21);
            label4.TabIndex = 3;
            label4.Text = "SEU IMC É";
            label4.Click += label4_Click;
            // 
            // txtPeso
            // 
            txtPeso.Location = new System.Drawing.Point(217, 59);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new System.Drawing.Size(100, 23);
            txtPeso.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new System.Drawing.Point(217, 94);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new System.Drawing.Size(100, 23);
            txtAltura.TabIndex = 5;
            // 
            // txtIMC
            // 
            txtIMC.Location = new System.Drawing.Point(217, 129);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new System.Drawing.Size(100, 23);
            txtIMC.TabIndex = 6;
            // 
            // btnVerificar
            // 
            btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnVerificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVerificar.Location = new System.Drawing.Point(37, 379);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new System.Drawing.Size(98, 43);
            btnVerificar.TabIndex = 7;
            btnVerificar.Text = "VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnLimpar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLimpar.Location = new System.Drawing.Point(141, 379);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(99, 42);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnSair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSair.Location = new System.Drawing.Point(246, 379);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(98, 43);
            btnSair.TabIndex = 9;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(98, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(204, 174);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(414, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnVerificar);
            Controls.Add(txtIMC);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

