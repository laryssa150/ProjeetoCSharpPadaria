﻿namespace Padaria
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtNúmero1 = new System.Windows.Forms.TextBox();
            this.lblNúmero2 = new System.Windows.Forms.Label();
            this.txtNúmero2 = new System.Windows.Forms.TextBox();
            this.rbSomar = new System.Windows.Forms.RadioButton();
            this.rbSubtarir = new System.Windows.Forms.RadioButton();
            this.rbMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbDivisão = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpOperações = new System.Windows.Forms.GroupBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.grpOperações.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero1.Location = new System.Drawing.Point(48, 58);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(78, 20);
            this.lblNumero1.TabIndex = 1;
            this.lblNumero1.Text = "Número 1";
            this.lblNumero1.UseWaitCursor = true;
            // 
            // txtNúmero1
            // 
            this.txtNúmero1.Location = new System.Drawing.Point(52, 81);
            this.txtNúmero1.MaxLength = 10;
            this.txtNúmero1.Name = "txtNúmero1";
            this.txtNúmero1.Size = new System.Drawing.Size(272, 26);
            this.txtNúmero1.TabIndex = 2;
            this.txtNúmero1.UseWaitCursor = true;
            // 
            // lblNúmero2
            // 
            this.lblNúmero2.AutoSize = true;
            this.lblNúmero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmero2.Location = new System.Drawing.Point(48, 152);
            this.lblNúmero2.Name = "lblNúmero2";
            this.lblNúmero2.Size = new System.Drawing.Size(78, 20);
            this.lblNúmero2.TabIndex = 3;
            this.lblNúmero2.Text = "Número 2";
            this.lblNúmero2.UseWaitCursor = true;
            // 
            // txtNúmero2
            // 
            this.txtNúmero2.Location = new System.Drawing.Point(51, 175);
            this.txtNúmero2.MaxLength = 10;
            this.txtNúmero2.Name = "txtNúmero2";
            this.txtNúmero2.Size = new System.Drawing.Size(272, 26);
            this.txtNúmero2.TabIndex = 4;
            this.txtNúmero2.UseWaitCursor = true;
            // 
            // rbSomar
            // 
            this.rbSomar.AutoSize = true;
            this.rbSomar.Location = new System.Drawing.Point(48, 40);
            this.rbSomar.Name = "rbSomar";
            this.rbSomar.Size = new System.Drawing.Size(74, 24);
            this.rbSomar.TabIndex = 6;
            this.rbSomar.TabStop = true;
            this.rbSomar.Text = "Somar";
            this.rbSomar.UseVisualStyleBackColor = true;
            this.rbSomar.UseWaitCursor = true;
            // 
            // rbSubtarir
            // 
            this.rbSubtarir.AutoSize = true;
            this.rbSubtarir.Location = new System.Drawing.Point(48, 70);
            this.rbSubtarir.Name = "rbSubtarir";
            this.rbSubtarir.Size = new System.Drawing.Size(78, 24);
            this.rbSubtarir.TabIndex = 7;
            this.rbSubtarir.TabStop = true;
            this.rbSubtarir.Text = "Subtair";
            this.rbSubtarir.UseVisualStyleBackColor = true;
            this.rbSubtarir.UseWaitCursor = true;
            // 
            // rbMultiplicar
            // 
            this.rbMultiplicar.AutoSize = true;
            this.rbMultiplicar.Location = new System.Drawing.Point(48, 100);
            this.rbMultiplicar.Name = "rbMultiplicar";
            this.rbMultiplicar.Size = new System.Drawing.Size(97, 24);
            this.rbMultiplicar.TabIndex = 8;
            this.rbMultiplicar.TabStop = true;
            this.rbMultiplicar.Text = "Multiplicar";
            this.rbMultiplicar.UseVisualStyleBackColor = true;
            this.rbMultiplicar.UseWaitCursor = true;
            // 
            // rbDivisão
            // 
            this.rbDivisão.AutoSize = true;
            this.rbDivisão.Location = new System.Drawing.Point(48, 130);
            this.rbDivisão.Name = "rbDivisão";
            this.rbDivisão.Size = new System.Drawing.Size(78, 24);
            this.rbDivisão.TabIndex = 9;
            this.rbDivisão.TabStop = true;
            this.rbDivisão.Text = "Divisão";
            this.rbDivisão.UseVisualStyleBackColor = true;
            this.rbDivisão.UseWaitCursor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(886, 43);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 64);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.UseWaitCursor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(886, 127);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(157, 64);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.UseWaitCursor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(886, 215);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(157, 64);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.UseWaitCursor = true;
            // 
            // grpOperações
            // 
            this.grpOperações.Controls.Add(this.rbDivisão);
            this.grpOperações.Controls.Add(this.rbMultiplicar);
            this.grpOperações.Controls.Add(this.rbSubtarir);
            this.grpOperações.Controls.Add(this.rbSomar);
            this.grpOperações.Location = new System.Drawing.Point(483, 43);
            this.grpOperações.Name = "grpOperações";
            this.grpOperações.Size = new System.Drawing.Size(218, 197);
            this.grpOperações.TabIndex = 5;
            this.grpOperações.TabStop = false;
            this.grpOperações.Text = "Operações";
            this.grpOperações.UseWaitCursor = true;
            // 
            // txtResposta
            // 
            this.txtResposta.Enabled = false;
            this.txtResposta.Location = new System.Drawing.Point(51, 266);
            this.txtResposta.MaxLength = 10;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(272, 26);
            this.txtResposta.TabIndex = 14;
            this.txtResposta.UseWaitCursor = true;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(48, 243);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(78, 20);
            this.lblResposta.TabIndex = 13;
            this.lblResposta.Text = "Resposta";
            this.lblResposta.UseWaitCursor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.grpOperações);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNúmero2);
            this.Controls.Add(this.lblNúmero2);
            this.Controls.Add(this.txtNúmero1);
            this.Controls.Add(this.lblNumero1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.UseWaitCursor = true;
            this.grpOperações.ResumeLayout(false);
            this.grpOperações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtNúmero1;
        private System.Windows.Forms.Label lblNúmero2;
        private System.Windows.Forms.TextBox txtNúmero2;
        private System.Windows.Forms.RadioButton rbSomar;
        private System.Windows.Forms.RadioButton rbSubtarir;
        private System.Windows.Forms.RadioButton rbMultiplicar;
        private System.Windows.Forms.RadioButton rbDivisão;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpOperações;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
    }
}