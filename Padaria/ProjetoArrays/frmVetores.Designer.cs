namespace ProjetoArrays
{
    partial class Vetores
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
            this.gpbnomes = new System.Windows.Forms.GroupBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtB2Nome = new System.Windows.Forms.TextBox();
            this.lbl2Nome = new System.Windows.Forms.Label();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.lbl1Tamanho = new System.Windows.Forms.Label();
            this.lblListadeNomes = new System.Windows.Forms.Label();
            this.ltbNomes = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.gpbnomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbnomes
            // 
            this.gpbnomes.Controls.Add(this.btn2);
            this.gpbnomes.Controls.Add(this.txtB2Nome);
            this.gpbnomes.Controls.Add(this.lbl2Nome);
            this.gpbnomes.Controls.Add(this.txtB1);
            this.gpbnomes.Controls.Add(this.lbl1Tamanho);
            this.gpbnomes.Controls.Add(this.lblListadeNomes);
            this.gpbnomes.Controls.Add(this.ltbNomes);
            this.gpbnomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbnomes.Location = new System.Drawing.Point(34, 49);
            this.gpbnomes.Name = "gpbnomes";
            this.gpbnomes.Size = new System.Drawing.Size(728, 313);
            this.gpbnomes.TabIndex = 0;
            this.gpbnomes.TabStop = false;
            this.gpbnomes.Text = "Nomes";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(10, 241);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 35);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Enviar";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtB2Nome
            // 
            this.txtB2Nome.Location = new System.Drawing.Point(6, 191);
            this.txtB2Nome.MaxLength = 10;
            this.txtB2Nome.Name = "txtB2Nome";
            this.txtB2Nome.Size = new System.Drawing.Size(157, 26);
            this.txtB2Nome.TabIndex = 5;
            // 
            // lbl2Nome
            // 
            this.lbl2Nome.AutoSize = true;
            this.lbl2Nome.Location = new System.Drawing.Point(6, 155);
            this.lbl2Nome.Name = "lbl2Nome";
            this.lbl2Nome.Size = new System.Drawing.Size(122, 20);
            this.lbl2Nome.TabIndex = 4;
            this.lbl2Nome.Text = "Insira um  nome";
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(10, 81);
            this.txtB1.MaxLength = 10;
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(118, 26);
            this.txtB1.TabIndex = 3;
            // 
            // lbl1Tamanho
            // 
            this.lbl1Tamanho.AutoSize = true;
            this.lbl1Tamanho.Location = new System.Drawing.Point(18, 41);
            this.lbl1Tamanho.Name = "lbl1Tamanho";
            this.lbl1Tamanho.Size = new System.Drawing.Size(76, 20);
            this.lbl1Tamanho.TabIndex = 2;
            this.lbl1Tamanho.Text = "Tamanho";
            // 
            // lblListadeNomes
            // 
            this.lblListadeNomes.AutoSize = true;
            this.lblListadeNomes.Location = new System.Drawing.Point(371, 32);
            this.lblListadeNomes.Name = "lblListadeNomes";
            this.lblListadeNomes.Size = new System.Drawing.Size(119, 20);
            this.lblListadeNomes.TabIndex = 1;
            this.lblListadeNomes.Text = "Lista de Nomes";
            // 
            // ltbNomes
            // 
            this.ltbNomes.FormattingEnabled = true;
            this.ltbNomes.ItemHeight = 20;
            this.ltbNomes.Location = new System.Drawing.Point(366, 65);
            this.ltbNomes.Name = "ltbNomes";
            this.ltbNomes.Size = new System.Drawing.Size(321, 204);
            this.ltbNomes.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(34, 384);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(176, 60);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Carrega";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Vetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.gpbnomes);
            this.MaximizeBox = false;
            this.Name = "Vetores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVetores";
            
            this.gpbnomes.ResumeLayout(false);
            this.gpbnomes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbnomes;
        private System.Windows.Forms.Label lblListadeNomes;
        private System.Windows.Forms.ListBox ltbNomes;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Label lbl1Tamanho;
        private System.Windows.Forms.TextBox txtB2Nome;
        private System.Windows.Forms.Label lbl2Nome;
        private System.Windows.Forms.Button btn2;
    }
}