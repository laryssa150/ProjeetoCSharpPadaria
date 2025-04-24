namespace ProjetoArrays
{
    partial class frmMatriz
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
            this.ltblista = new System.Windows.Forms.ListBox();
            this.lbl1linha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl2coluna = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn1Carrega = new System.Windows.Forms.Button();
            this.btn2Limpa = new System.Windows.Forms.Button();
            this.btn3Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltblista
            // 
            this.ltblista.FormattingEnabled = true;
            this.ltblista.Location = new System.Drawing.Point(479, 32);
            this.ltblista.Name = "ltblista";
            this.ltblista.Size = new System.Drawing.Size(261, 394);
            this.ltblista.TabIndex = 0;
            // 
            // lbl1linha
            // 
            this.lbl1linha.AutoSize = true;
            this.lbl1linha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1linha.Location = new System.Drawing.Point(24, 64);
            this.lbl1linha.Name = "lbl1linha";
            this.lbl1linha.Size = new System.Drawing.Size(39, 16);
            this.lbl1linha.TabIndex = 1;
            this.lbl1linha.Text = "Linha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lbl2coluna
            // 
            this.lbl2coluna.AutoSize = true;
            this.lbl2coluna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2coluna.Location = new System.Drawing.Point(12, 160);
            this.lbl2coluna.Name = "lbl2coluna";
            this.lbl2coluna.Size = new System.Drawing.Size(49, 16);
            this.lbl2coluna.TabIndex = 3;
            this.lbl2coluna.Text = "Coluna";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btn1Carrega
            // 
            this.btn1Carrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Carrega.Location = new System.Drawing.Point(27, 379);
            this.btn1Carrega.Name = "btn1Carrega";
            this.btn1Carrega.Size = new System.Drawing.Size(113, 46);
            this.btn1Carrega.TabIndex = 5;
            this.btn1Carrega.Text = "&Carrega Matriz";
            this.btn1Carrega.UseVisualStyleBackColor = true;
            this.btn1Carrega.Click += new System.EventHandler(this.btn1Carrega_Click);
            // 
            // btn2Limpa
            // 
            this.btn2Limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Limpa.Location = new System.Drawing.Point(186, 379);
            this.btn2Limpa.Name = "btn2Limpa";
            this.btn2Limpa.Size = new System.Drawing.Size(113, 46);
            this.btn2Limpa.TabIndex = 6;
            this.btn2Limpa.Text = "&Limpar";
            this.btn2Limpa.UseVisualStyleBackColor = true;
            // 
            // btn3Sair
            // 
            this.btn3Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Sair.Location = new System.Drawing.Point(349, 379);
            this.btn3Sair.Name = "btn3Sair";
            this.btn3Sair.Size = new System.Drawing.Size(113, 46);
            this.btn3Sair.TabIndex = 7;
            this.btn3Sair.Text = "&Sair";
            this.btn3Sair.UseVisualStyleBackColor = true;
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn3Sair);
            this.Controls.Add(this.btn2Limpa);
            this.Controls.Add(this.btn1Carrega);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl2coluna);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl1linha);
            this.Controls.Add(this.ltblista);
            this.Name = "frmMatriz";
            this.Text = "frmMatriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltblista;
        private System.Windows.Forms.Label lbl1linha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl2coluna;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn1Carrega;
        private System.Windows.Forms.Button btn2Limpa;
        private System.Windows.Forms.Button btn3Sair;
    }
}